// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;
using Hexa.NET.SPIRV.Core;

namespace Hexa.NET.SPIRVReflect
{
	/// <summary>
	/// <br/>
	/// <summary>
	/// To be documented.
	/// </summary>
	/// <br/>
	/// <summary>
	/// To be documented.
	/// </summary>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SpvReflectTypeDescription")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SpvReflectTypeDescription
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.StructOrClass, "SpvReflectTypeDescription::Traits")]
		[StructLayout(LayoutKind.Sequential)]
		public partial struct TraitsUnion
		{
			/// <summary>
			/// To be documented.
			/// </summary>
			[NativeName(NativeNameType.Field, "numeric")]
			[NativeName(NativeNameType.Type, "SpvReflectNumericTraits")]
			public SpvReflectNumericTraits Numeric;

			/// <summary>
			/// To be documented.
			/// </summary>
			[NativeName(NativeNameType.Field, "image")]
			[NativeName(NativeNameType.Type, "SpvReflectImageTraits")]
			public SpvReflectImageTraits Image;

			/// <summary>
			/// To be documented.
			/// </summary>
			[NativeName(NativeNameType.Field, "array")]
			[NativeName(NativeNameType.Type, "SpvReflectArrayTraits")]
			public SpvReflectArrayTraits Array;


			/// <summary>
			/// To be documented.
			/// </summary>
			public unsafe TraitsUnion(SpvReflectNumericTraits numeric = default, SpvReflectImageTraits image = default, SpvReflectArrayTraits array = default)
			{
				Numeric = numeric;
				Image = image;
				Array = array;
			}


		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "id")]
		[NativeName(NativeNameType.Type, "uint32_t")]
		public uint Id;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "op")]
		[NativeName(NativeNameType.Type, "SpvOp")]
		public SpvOp Op;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "type_name")]
		[NativeName(NativeNameType.Type, "char const *")]
		public unsafe byte* TypeName;

		/// <summary>
		/// Non-NULL if type is member of a struct<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "struct_member_name")]
		[NativeName(NativeNameType.Type, "char const *")]
		public unsafe byte* StructMemberName;

		/// <summary>
		/// The storage class (SpvStorageClass) if the type, and -1 if it does not have a storage class.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "storage_class")]
		[NativeName(NativeNameType.Type, "int")]
		public int StorageClass;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "type_flags")]
		[NativeName(NativeNameType.Type, "SpvReflectTypeFlags")]
		public SpvReflectTypeFlags TypeFlags;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "decoration_flags")]
		[NativeName(NativeNameType.Type, "SpvReflectDecorationFlags")]
		public SpvReflectDecorationFlags DecorationFlags;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "traits")]
		[NativeName(NativeNameType.Type, "Traits")]
		public TraitsUnion Traits;

		/// <summary>
		/// If underlying type is a struct (ex. array of structs)<br/>
		/// this gives access to the OpTypeStruct<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "struct_type_description")]
		[NativeName(NativeNameType.Type, "SpvReflectTypeDescription *")]
		public unsafe SpvReflectTypeDescription* StructTypeDescription;

		/// <summary>
		/// Some pointers to SpvReflectTypeDescription are really<br/>
		/// just copies of another reference to the same OpType<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "copied")]
		[NativeName(NativeNameType.Type, "uint32_t")]
		public uint Copied;

		/// <summary>
		/// <br/>
		/// <summary>
		/// To be documented.
		/// </summary>
		/// </summary>
		[NativeName(NativeNameType.Field, "member_count")]
		[NativeName(NativeNameType.Type, "uint32_t")]
		public uint MemberCount;

		/// <summary>
		/// <br/>
		/// <summary>
		/// To be documented.
		/// </summary>
		/// </summary>
		[NativeName(NativeNameType.Field, "members")]
		[NativeName(NativeNameType.Type, "SpvReflectTypeDescription *")]
		public unsafe SpvReflectTypeDescription* Members;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe SpvReflectTypeDescription(uint id = default, SpvOp op = default, byte* typeName = default, byte* structMemberName = default, int storageClass = default, SpvReflectTypeFlags typeFlags = default, SpvReflectDecorationFlags decorationFlags = default, TraitsUnion traits = default, SpvReflectTypeDescription* structTypeDescription = default, uint copied = default, uint memberCount = default, SpvReflectTypeDescription* members = default)
		{
			Id = id;
			Op = op;
			TypeName = typeName;
			StructMemberName = structMemberName;
			StorageClass = storageClass;
			TypeFlags = typeFlags;
			DecorationFlags = decorationFlags;
			Traits = traits;
			StructTypeDescription = structTypeDescription;
			Copied = copied;
			MemberCount = memberCount;
			Members = members;
		}


	}

}
