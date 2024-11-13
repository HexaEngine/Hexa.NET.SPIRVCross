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
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SpvReflectBlockVariable")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SpvReflectBlockVariable
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.StructOrClass, "SpvReflectBlockVariable::")]
		[StructLayout(LayoutKind.Sequential)]
		public partial struct WordOffsetUnion
		{
			/// <summary>
			/// To be documented.
			/// </summary>
			[NativeName(NativeNameType.Field, "offset")]
			[NativeName(NativeNameType.Type, "uint32_t")]
			public uint Offset;


			/// <summary>
			/// To be documented.
			/// </summary>
			public unsafe WordOffsetUnion(uint offset = default)
			{
				Offset = offset;
			}


		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "spirv_id")]
		[NativeName(NativeNameType.Type, "uint32_t")]
		public uint SpirvId;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "name")]
		[NativeName(NativeNameType.Type, "char const *")]
		public unsafe byte* Name;

		/// <summary>
		/// Measured in bytes<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "offset")]
		[NativeName(NativeNameType.Type, "uint32_t")]
		public uint Offset;

		/// <summary>
		/// Measured in bytes<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "absolute_offset")]
		[NativeName(NativeNameType.Type, "uint32_t")]
		public uint AbsoluteOffset;

		/// <summary>
		/// Measured in bytes<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "size")]
		[NativeName(NativeNameType.Type, "uint32_t")]
		public uint Size;

		/// <summary>
		/// Measured in bytes<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "padded_size")]
		[NativeName(NativeNameType.Type, "uint32_t")]
		public uint PaddedSize;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "decoration_flags")]
		[NativeName(NativeNameType.Type, "SpvReflectDecorationFlags")]
		public SpvReflectDecorationFlags DecorationFlags;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "numeric")]
		[NativeName(NativeNameType.Type, "SpvReflectNumericTraits")]
		public SpvReflectNumericTraits Numeric;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "array")]
		[NativeName(NativeNameType.Type, "SpvReflectArrayTraits")]
		public SpvReflectArrayTraits Array;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "flags")]
		[NativeName(NativeNameType.Type, "SpvReflectVariableFlags")]
		public SpvReflectVariableFlags Flags;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "member_count")]
		[NativeName(NativeNameType.Type, "uint32_t")]
		public uint MemberCount;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "members")]
		[NativeName(NativeNameType.Type, "SpvReflectBlockVariable *")]
		public unsafe SpvReflectBlockVariable* Members;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "type_description")]
		[NativeName(NativeNameType.Type, "SpvReflectTypeDescription *")]
		public unsafe SpvReflectTypeDescription* TypeDescription;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "word_offset")]
		[NativeName(NativeNameType.Type, "")]
		public WordOffsetUnion WordOffset;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe SpvReflectBlockVariable(uint spirvId = default, byte* name = default, uint offset = default, uint absoluteOffset = default, uint size = default, uint paddedSize = default, SpvReflectDecorationFlags decorationFlags = default, SpvReflectNumericTraits numeric = default, SpvReflectArrayTraits array = default, SpvReflectVariableFlags flags = default, uint memberCount = default, SpvReflectBlockVariable* members = default, SpvReflectTypeDescription* typeDescription = default, WordOffsetUnion wordOffset = default)
		{
			SpirvId = spirvId;
			Name = name;
			Offset = offset;
			AbsoluteOffset = absoluteOffset;
			Size = size;
			PaddedSize = paddedSize;
			DecorationFlags = decorationFlags;
			Numeric = numeric;
			Array = array;
			Flags = flags;
			MemberCount = memberCount;
			Members = members;
			TypeDescription = typeDescription;
			WordOffset = wordOffset;
		}


	}

}
