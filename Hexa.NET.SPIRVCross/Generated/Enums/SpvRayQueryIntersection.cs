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
	[NativeName(NativeNameType.Enum, "SpvRayQueryIntersection_")]
	[Flags]
	public enum SpvRayQueryIntersection : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvRayQueryIntersectionRayQueryCandidateIntersectionKHR")]
		[NativeName(NativeNameType.Value, "0")]
		CandidateIntersectionKhr = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvRayQueryIntersectionRayQueryCommittedIntersectionKHR")]
		[NativeName(NativeNameType.Value, "1")]
		CommittedIntersectionKhr = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvRayQueryIntersectionMax")]
		[NativeName(NativeNameType.Value, "2147483647")]
		Max = unchecked(2147483647),
	}
}
