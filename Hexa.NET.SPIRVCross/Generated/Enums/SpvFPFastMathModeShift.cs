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
	[NativeName(NativeNameType.Enum, "SpvFPFastMathModeShift_")]
	[Flags]
	public enum SpvFPFastMathModeShift : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvFPFastMathModeNotNaNShift")]
		[NativeName(NativeNameType.Value, "0")]
		NotNaNShift = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvFPFastMathModeNotInfShift")]
		[NativeName(NativeNameType.Value, "1")]
		NotInfShift = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvFPFastMathModeNSZShift")]
		[NativeName(NativeNameType.Value, "2")]
		NszShift = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvFPFastMathModeAllowRecipShift")]
		[NativeName(NativeNameType.Value, "3")]
		AllowRecipShift = unchecked(3),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvFPFastMathModeFastShift")]
		[NativeName(NativeNameType.Value, "4")]
		Shift = unchecked(4),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvFPFastMathModeAllowContractFastINTELShift")]
		[NativeName(NativeNameType.Value, "16")]
		AllowContractFastIntelShift = unchecked(16),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvFPFastMathModeAllowReassocINTELShift")]
		[NativeName(NativeNameType.Value, "17")]
		AllowReassocIntelShift = unchecked(17),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvFPFastMathModeMax")]
		[NativeName(NativeNameType.Value, "2147483647")]
		Max = unchecked(2147483647),
	}
}