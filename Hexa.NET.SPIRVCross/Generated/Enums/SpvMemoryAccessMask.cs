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

namespace Hexa.NET.SPIRVCross
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.Enum, "SpvMemoryAccessMask_")]
	[Flags]
	public enum SpvMemoryAccessMask : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvMemoryAccessMaskNone")]
		[NativeName(NativeNameType.Value, "0")]
		None = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvMemoryAccessVolatileMask")]
		[NativeName(NativeNameType.Value, "1")]
		VolatileMask = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvMemoryAccessAlignedMask")]
		[NativeName(NativeNameType.Value, "2")]
		AlignedMask = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvMemoryAccessNontemporalMask")]
		[NativeName(NativeNameType.Value, "4")]
		NontemporalMask = unchecked(4),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvMemoryAccessMakePointerAvailableMask")]
		[NativeName(NativeNameType.Value, "8")]
		MakePointerAvailableMask = unchecked(8),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvMemoryAccessMakePointerAvailableKHRMask")]
		[NativeName(NativeNameType.Value, "8")]
		MakePointerAvailableKhrMask = unchecked(8),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvMemoryAccessMakePointerVisibleMask")]
		[NativeName(NativeNameType.Value, "16")]
		MakePointerVisibleMask = unchecked(16),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvMemoryAccessMakePointerVisibleKHRMask")]
		[NativeName(NativeNameType.Value, "16")]
		MakePointerVisibleKhrMask = unchecked(16),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvMemoryAccessNonPrivatePointerMask")]
		[NativeName(NativeNameType.Value, "32")]
		NonPrivatePointerMask = unchecked(32),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvMemoryAccessNonPrivatePointerKHRMask")]
		[NativeName(NativeNameType.Value, "32")]
		NonPrivatePointerKhrMask = unchecked(32),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvMemoryAccessAliasScopeINTELMaskMask")]
		[NativeName(NativeNameType.Value, "65536")]
		AliasScopeIntelMaskMask = unchecked(65536),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvMemoryAccessNoAliasINTELMaskMask")]
		[NativeName(NativeNameType.Value, "131072")]
		NoAliasIntelMaskMask = unchecked(131072),
	}
}
