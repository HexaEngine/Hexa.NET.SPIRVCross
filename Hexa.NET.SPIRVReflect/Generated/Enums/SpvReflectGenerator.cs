// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;
using Hexa.NET.SPIRV.Core;

namespace Hexa.NET.SPIRVReflect
{
	/// <summary>
	/// <br/>
	/// <summary>
	/// To be documented.
	/// </summary>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SpvReflectGenerator")]
	[Flags]
	public enum SpvReflectGenerator : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPV_REFLECT_GENERATOR_KHRONOS_LLVM_SPIRV_TRANSLATOR")]
		[NativeName(NativeNameType.Value, "6")]
		KhronosLlvmSpirvTranslator = unchecked(6),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPV_REFLECT_GENERATOR_KHRONOS_SPIRV_TOOLS_ASSEMBLER")]
		[NativeName(NativeNameType.Value, "7")]
		KhronosSpirvToolsAssembler = unchecked(7),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPV_REFLECT_GENERATOR_KHRONOS_GLSLANG_REFERENCE_FRONT_END")]
		[NativeName(NativeNameType.Value, "8")]
		KhronosGlslangReferenceFrontEnd = unchecked(8),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPV_REFLECT_GENERATOR_GOOGLE_SHADERC_OVER_GLSLANG")]
		[NativeName(NativeNameType.Value, "13")]
		GoogleShadercOverGlslang = unchecked(13),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPV_REFLECT_GENERATOR_GOOGLE_SPIREGG")]
		[NativeName(NativeNameType.Value, "14")]
		GoogleSpiregg = unchecked(14),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPV_REFLECT_GENERATOR_GOOGLE_RSPIRV")]
		[NativeName(NativeNameType.Value, "15")]
		GoogleRspirv = unchecked(15),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPV_REFLECT_GENERATOR_X_LEGEND_MESA_MESAIR_SPIRV_TRANSLATOR")]
		[NativeName(NativeNameType.Value, "16")]
		XLegendMesaMesairSpirvTranslator = unchecked(16),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPV_REFLECT_GENERATOR_KHRONOS_SPIRV_TOOLS_LINKER")]
		[NativeName(NativeNameType.Value, "17")]
		KhronosSpirvToolsLinker = unchecked(17),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPV_REFLECT_GENERATOR_WINE_VKD3D_SHADER_COMPILER")]
		[NativeName(NativeNameType.Value, "18")]
		WineVkd3DShaderCompiler = unchecked(18),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPV_REFLECT_GENERATOR_CLAY_CLAY_SHADER_COMPILER")]
		[NativeName(NativeNameType.Value, "19")]
		ClayClayShaderCompiler = unchecked(19),
	}
}
