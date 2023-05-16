﻿namespace Generator
{
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using System.Security.Cryptography;
    using System.Text;
    using CppAst;

    public static partial class CsCodeGenerator
    {
        private static readonly HashSet<string> s_instanceFunctions = new()
        {
        };

        private static readonly HashSet<string> s_outReturnFunctions = new()
        {
        };

        private static void GenerateCommands(CppCompilation compilation, string outputPath)
        {
            // Generate Functions
            using var writer = new CodeWriter(Path.Combine(outputPath, "Commands.cs"),
                "System",
                "System.Runtime.CompilerServices",
                "System.Runtime.InteropServices"
                );

            var commands = new Dictionary<string, CppFunction>();
            var instanceCommands = new Dictionary<string, CppFunction>();
            var deviceCommands = new Dictionary<string, CppFunction>();
            foreach (CppFunction? cppFunction in compilation.Functions)
            {
                string? returnType = GetCsTypeName(cppFunction.ReturnType, false);
                bool canUseOut = s_outReturnFunctions.Contains(cppFunction.Name);
                string? csName = GetCsCleanName(cppFunction.Name);

                commands.Add(csName, cppFunction);

                if (cppFunction.Parameters.Count > 0)
                {
                    var firstParameter = cppFunction.Parameters[0];
                    if (firstParameter.Type is CppTypedef typedef)
                    {
                        deviceCommands.Add(csName, cppFunction);
                    }
                }
            }

            using (writer.PushBlock($"public unsafe partial class SPIRV"))
            {
                writer.WriteLine("internal const string LibName = \"spirv-cross-c-shared\";\n");
                foreach (KeyValuePair<string, CppFunction> command in commands)
                {
                    CppFunction cppFunction = command.Value;

                    string returnCsName = GetCsTypeName(cppFunction.ReturnType, false);
                    bool canUseOut = s_outReturnFunctions.Contains(cppFunction.Name);
                    var argumentsString = GetParameterSignature(cppFunction, canUseOut);

                    WriteCsSummary(cppFunction.Comment, writer);
                    writer.WriteLine($"[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = \"{cppFunction.Name}\")]");
                    writer.WriteLine($"public static extern {returnCsName} {command.Key}({argumentsString});");
                    writer.WriteLine();

                    var sigs = GetManagedWrapperParameterSignatures(cppFunction.Parameters, argumentsString, canUseOut);
                    GenerateManagedWrapperForSignatures(cppFunction, command.Key, argumentsString, sigs, writer);
                }
            }
        }

        [Flags]
        public enum ManagedWrapperFlags
        {
            None = 0,
            Refs = 1,
            StringOut = 2,
            StringIn = 4,
            StringInOut = StringOut | StringIn,
        }

        [Flags]
        public enum SignatureFlags
        {
            None,
            Pointer,
            String,
        }

        private static SignatureFlags Classify(IList<CppParameter> parameters)
        {
            SignatureFlags flags = SignatureFlags.None;

            for (int i = 0; i < parameters.Count; i++)
            {
                var param = parameters[i];
                if (IsString(param.Type))
                {
                    flags |= SignatureFlags.String;
                }
                if (IsPointer(param.Type))
                {
                    flags |= SignatureFlags.Pointer;
                }
            }

            return flags;
        }

        public static void GenerateManagedWrapperRefs(CppFunction cppFunction, string command, string signature, CodeWriter writer)
        {
            bool voidReturn = IsVoid(cppFunction.ReturnType);
            string returnCsName = GetCsTypeName(cppFunction.ReturnType, false);
            bool canUseOut = s_outReturnFunctions.Contains(cppFunction.Name);
            var argumentsString = GetManagedWrapperParameterSignature(cppFunction, canUseOut);

            if (argumentsString == signature)
                return;

            int stacks = 0;
            WriteCsSummary(cppFunction.Comment, writer);
            using (writer.PushBlock($"public static {returnCsName} {command}({argumentsString})"))
            {
                StringBuilder sb = new();
                if (!voidReturn)
                {
                    sb.Append("return ");
                }
                sb.Append($"{command}(");
                for (int i = 0; i < cppFunction.Parameters.Count; i++)
                {
                    var cppParameter = cppFunction.Parameters[i];
                    var paramCsTypeName = GetCsTypeName(cppParameter.Type, false);
                    var paramCsName = GetParameterName(cppParameter.Type, cppParameter.Name);
                    if (IsPointer(cppParameter.Type))
                    {
                        writer.BeginBlock($"fixed ({paramCsTypeName} p{paramCsName} = &{paramCsName})");
                        stacks++;
                        sb.Append($"p{paramCsName}");
                    }
                    else
                    {
                        sb.Append(paramCsName);
                    }
                    if (i != cppFunction.Parameters.Count - 1)
                        sb.Append(", ");
                }

                sb.Append(");");
                writer.WriteLine(sb.ToString());
                while (stacks > 0)
                {
                    stacks--;
                    writer.EndBlock();
                }
            }

            writer.WriteLine();
        }

        public static void GenerateManagedWrapperForSignatures(CppFunction cppFunction, string command, string nativeSignature, List<string> signatures, CodeWriter writer)
        {
            bool voidReturn = IsVoid(cppFunction.ReturnType);
            bool stringReturn = IsString(cppFunction.ReturnType);
            string returnCsName = GetCsTypeName(cppFunction.ReturnType, false);

            if (stringReturn)
            {
                WriteMethod(cppFunction, command, writer, voidReturn, true, "string", nativeSignature);
            }

            for (int i = 0; i < signatures.Count; i++)
            {
                string signature = signatures[i];

                if (stringReturn)
                    WriteMethod(cppFunction, command, writer, voidReturn, true, "string", signature);

                WriteMethod(cppFunction, command, writer, voidReturn, false, returnCsName, signature);
            }
        }

        private static void WriteMethod(CppFunction cppFunction, string command, CodeWriter writer, bool voidReturn, bool stringReturn, string returnCsName, string signature)
        {
            string[] paramList = signature.Split(',', StringSplitOptions.RemoveEmptyEntries);

            WriteCsSummary(cppFunction.Comment, writer);
            string header;

            if (stringReturn)
            {
                header = $"public static string {command}S({signature})";
            }
            else
            {
                header = $"public static {returnCsName} {command}({signature})";
            }

            using (writer.PushBlock(header))
            {
                StringBuilder sb = new();
                if (!voidReturn)
                {
                    sb.Append($"{returnCsName} result = ");
                }

                if (stringReturn)
                {
                    WriteStringConvertToManaged(sb, cppFunction.ReturnType);
                }

                sb.Append($"{command}(");
                int strings = 0;
                int stacks = 0;
                for (int j = 0; j < cppFunction.Parameters.Count; j++)
                {
                    var isRef = paramList[j].Contains("ref");
                    var isStr = paramList[j].Contains("string");
                    var cppParameter = cppFunction.Parameters[j];
                    var paramCsTypeName = GetCsTypeName(cppParameter.Type, false);
                    var paramCsName = GetParameterName(cppParameter.Type, cppParameter.Name);
                    if (isRef)
                    {
                        writer.BeginBlock($"fixed ({paramCsTypeName} p{paramCsName} = &{paramCsName})");
                        sb.Append($"p{paramCsName}");
                        stacks++;
                    }
                    else if (isStr)
                    {
                        WriteStringConvertToUnmanaged(writer, cppParameter.Type, paramCsName, strings);
                        sb.Append($"pStr{strings}");
                        strings++;
                    }
                    else
                    {
                        sb.Append(paramCsName);
                    }
                    if (j != cppFunction.Parameters.Count - 1)
                        sb.Append(", ");
                }

                if (stringReturn)
                    sb.Append("));");
                else
                    sb.Append(");");

                writer.WriteLine(sb.ToString());

                while (strings > 0)
                {
                    strings--;
                    writer.WriteLine($"Marshal.FreeHGlobal((nint)pStr{strings});");
                }

                if (!voidReturn)
                    writer.WriteLine("return result;");

                while (stacks > 0)
                {
                    stacks--;
                    writer.EndBlock();
                }
            }

            writer.WriteLine();
        }

        public static string GetParameterSignature(CppFunction cppFunction, bool canUseOut)
        {
            return GetParameterSignature(cppFunction.Parameters, canUseOut);
        }

        public static string GetManagedWrapperParameterSignature(CppFunction cppFunction, bool canUseOut)
        {
            return GetManagedWrapperParameterSignature(cppFunction.Parameters, canUseOut);
        }

        private static bool IsVoid(CppType cppType)
        {
            if (cppType is CppPrimitiveType type)
            {
                return type.Kind == CppPrimitiveKind.Void;
            }
            return false;
        }

        private static bool IsPointer(CppType cppType)
        {
            return cppType.TypeKind == CppTypeKind.Pointer;
        }

        private static bool IsString(CppType cppType, bool isPointer = false)
        {
            if (cppType is CppPointerType pointer && !isPointer)
            {
                return IsString(pointer.ElementType, true);
            }

            if (isPointer && cppType is CppQualifiedType qualified)
            {
                return IsString(qualified.ElementType, true);
            }

            if (isPointer && cppType is CppPrimitiveType primitive)
            {
                return primitive.Kind == CppPrimitiveKind.WChar || primitive.Kind == CppPrimitiveKind.Char;
            }

            return false;
        }

        private static CppPrimitiveKind GetPrimitiveKind(CppType cppType, bool isPointer)
        {
            if (cppType is CppPointerType pointer)
            {
                return GetPrimitiveKind(pointer.ElementType, true);
            }

            if (isPointer && cppType is CppQualifiedType qualified)
            {
                return GetPrimitiveKind(qualified.ElementType, true);
            }

            if (isPointer && cppType is CppPrimitiveType primitive)
            {
                return primitive.Kind;
            }

            return CppPrimitiveKind.Void;
        }

        private static void WriteStringConvertToManaged(StringBuilder sb, CppType type)
        {
            CppPrimitiveKind primitiveKind = GetPrimitiveKind(type, false);
            if (primitiveKind == CppPrimitiveKind.Char)
            {
                sb.Append("Marshal.PtrToStringAnsi((nint)");
            }
            if (primitiveKind == CppPrimitiveKind.WChar)
            {
                sb.Append("Marshal.PtrToStringUni((nint)");
            }
        }

        private static void WriteStringConvertToUnmanaged(CodeWriter writer, CppType type, string name, int i)
        {
            CppPrimitiveKind primitiveKind = GetPrimitiveKind(type, false);
            if (primitiveKind == CppPrimitiveKind.Char)
            {
                writer.WriteLine($"byte* pStr{i} = (byte*)Marshal.StringToHGlobalAnsi({name});");
            }
            if (primitiveKind == CppPrimitiveKind.WChar)
            {
                writer.WriteLine($"char* pStr{i} = (char*)Marshal.StringToHGlobalUni({name});");
            }
        }

        private static string GetParameterSignature(IList<CppParameter> parameters, bool canUseOut)
        {
            var argumentBuilder = new StringBuilder();
            int index = 0;

            foreach (CppParameter cppParameter in parameters)
            {
                string direction = string.Empty;
                var paramCsTypeName = GetCsTypeName(cppParameter.Type, false);
                var paramCsName = GetParameterName(cppParameter.Type, cppParameter.Name);

                if (canUseOut && CanBeUsedAsOutput(cppParameter.Type, out CppTypeDeclaration? cppTypeDeclaration))
                {
                    argumentBuilder.Append("out ");
                    paramCsTypeName = GetCsTypeName(cppTypeDeclaration, false);
                }

                argumentBuilder.Append(paramCsTypeName).Append(' ').Append(paramCsName);
                if (index < parameters.Count - 1)
                {
                    argumentBuilder.Append(", ");
                }

                index++;
            }

            return argumentBuilder.ToString();
        }

        private static string GetManagedWrapperParameterSignature(IList<CppParameter> parameters, bool canUseOut)
        {
            var argumentBuilder = new StringBuilder();
            int index = 0;

            foreach (CppParameter cppParameter in parameters)
            {
                string direction = string.Empty;
                var paramCsTypeName = GetCsWrapperTypeName(cppParameter.Type, false);
                var paramCsName = GetParameterName(cppParameter.Type, cppParameter.Name);

                if (canUseOut && CanBeUsedAsOutput(cppParameter.Type, out CppTypeDeclaration? cppTypeDeclaration))
                {
                    argumentBuilder.Append("out ");
                    paramCsTypeName = GetCsWrapperTypeName(cppTypeDeclaration, false);
                }

                argumentBuilder.Append(paramCsTypeName).Append(' ').Append(paramCsName);
                if (index < parameters.Count - 1)
                {
                    argumentBuilder.Append(", ");
                }

                index++;
            }

            return argumentBuilder.ToString();
        }

        private static List<string> GetManagedWrapperParameterSignatures(IList<CppParameter> parameters, string originalSig, bool canUseOut)
        {
            List<string> result = new();
            StringBuilder argumentBuilder = new();
            var flags = Classify(parameters);
            for (int ix = 0; ix < parameters.Count; ix++)
            {
                for (int iy = 0; iy < parameters.Count; iy++)
                {
                    int index = 0;
                    for (int j = 0; j < parameters.Count; j++)
                    {
                        CppParameter cppParameter = parameters[j];
                        string paramCsTypeName;
                        if (j == iy || j == ix)
                            paramCsTypeName = GetCsWrapperTypeName(cppParameter.Type, false);
                        else
                            paramCsTypeName = GetCsTypeName(cppParameter.Type, false);

                        var paramCsName = GetParameterName(cppParameter.Type, cppParameter.Name);

                        if (canUseOut && CanBeUsedAsOutput(cppParameter.Type, out CppTypeDeclaration? cppTypeDeclaration))
                        {
                            argumentBuilder.Append("out ");
                            paramCsTypeName = GetCsWrapperTypeName(cppTypeDeclaration, false);
                        }

                        argumentBuilder.Append(paramCsTypeName).Append(' ').Append(paramCsName);
                        if (index < parameters.Count - 1)
                        {
                            argumentBuilder.Append(", ");
                        }

                        index++;
                    }
                    string sig = argumentBuilder.ToString();
                    if (!result.Contains(sig) && sig != originalSig)
                        result.Add(sig);
                    argumentBuilder.Clear();
                    index = 0;
                    for (int j = 0; j < parameters.Count; j++)
                    {
                        CppParameter cppParameter = parameters[j];

                        string paramCsTypeName;
                        if (j == iy || j == ix)
                            paramCsTypeName = IsString(cppParameter.Type) ? "string" : GetCsWrapperTypeName(cppParameter.Type, false);
                        else
                            paramCsTypeName = GetCsTypeName(cppParameter.Type, false);

                        var paramCsName = GetParameterName(cppParameter.Type, cppParameter.Name);

                        if (canUseOut && CanBeUsedAsOutput(cppParameter.Type, out CppTypeDeclaration? cppTypeDeclaration))
                        {
                            argumentBuilder.Append("out ");
                            paramCsTypeName = GetCsWrapperTypeName(cppTypeDeclaration, false);
                        }

                        argumentBuilder.Append(paramCsTypeName).Append(' ').Append(paramCsName);
                        if (index < parameters.Count - 1)
                        {
                            argumentBuilder.Append(", ");
                        }

                        index++;
                    }
                    sig = argumentBuilder.ToString();
                    if (!result.Contains(sig) && sig != originalSig)
                        result.Add(sig);
                    argumentBuilder.Clear();
                }
            }

            return result;
        }

        private static string GetParameterName(CppType type, string name)
        {
            if (name == "event")
                return "@event";

            if (name == "object")
                return "@object";

            if (name == "base")
                return "@base";

            if (name.StartsWith('p') && char.IsUpper(name[1]))
            {
                name = char.ToLower(name[1]) + name[2..];
                return GetParameterName(type, name);
            }

            if (name == string.Empty)
            {
                switch (type.TypeKind)
                {
                    case CppTypeKind.Primitive:
                        return (type as CppPrimitiveType).GetDisplayName();

                    case CppTypeKind.Pointer:
                        return (type as CppPointerType).ElementType.GetDisplayName();

                    case CppTypeKind.Reference:
                        break;

                    case CppTypeKind.Array:
                        break;

                    case CppTypeKind.Qualified:
                        return (type as CppQualifiedType).ElementType.GetDisplayName();

                    case CppTypeKind.Function:
                        break;

                    case CppTypeKind.Typedef:
                        return GetParameterName((type as CppTypedef).ElementType, name);

                    case CppTypeKind.StructOrClass:
                        break;

                    case CppTypeKind.Enum:
                        return (type as CppEnum).GetDisplayName();

                    case CppTypeKind.TemplateParameterType:
                        break;

                    case CppTypeKind.TemplateParameterNonType:
                        break;

                    case CppTypeKind.Unexposed:
                        break;
                }
            }

            return NormalizeParameterName(name);
        }

        private static string NormalizeParameterName(string name)
        {
            var parts = name.Split('_', StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new();
            for (int i = 0; i < parts.Length; i++)
            {
                if (i == 0)
                {
                    sb.Append(char.ToLower(parts[i][0]));
                    sb.Append(parts[i][1..]);
                }
                else
                {
                    sb.Append(char.ToUpper(parts[i][0]));
                    sb.Append(parts[i][1..]);
                }
            }
            name = sb.ToString();
            if (s_keywords.Contains(name))
                return "@" + name;

            return name;
        }

        private static bool CanBeUsedAsOutput(CppType type, out CppTypeDeclaration? elementTypeDeclaration)
        {
            if (type is CppPointerType pointerType)
            {
                if (pointerType.ElementType is CppTypedef typedef)
                {
                    elementTypeDeclaration = typedef;
                    return true;
                }
                else if (pointerType.ElementType is CppClass @class
                    && @class.ClassKind != CppClassKind.Class
                    && @class.SizeOf > 0)
                {
                    elementTypeDeclaration = @class;
                    return true;
                }
                else if (pointerType.ElementType is CppEnum @enum
                    && @enum.SizeOf > 0)
                {
                    elementTypeDeclaration = @enum;
                    return true;
                }
            }

            elementTypeDeclaration = null;
            return false;
        }
    }
}