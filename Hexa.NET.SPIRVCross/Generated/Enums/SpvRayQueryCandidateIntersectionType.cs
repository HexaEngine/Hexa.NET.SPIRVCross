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
	[NativeName(NativeNameType.Enum, "SpvRayQueryCandidateIntersectionType_")]
	[Flags]
	public enum SpvRayQueryCandidateIntersectionType : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvRayQueryCandidateIntersectionTypeRayQueryCandidateIntersectionTriangleKHR")]
		[NativeName(NativeNameType.Value, "0")]
		TriangleKhr = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvRayQueryCandidateIntersectionTypeRayQueryCandidateIntersectionAABBKHR")]
		[NativeName(NativeNameType.Value, "1")]
		Aabbkhr = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvRayQueryCandidateIntersectionTypeMax")]
		[NativeName(NativeNameType.Value, "2147483647")]
		Max = unchecked(2147483647),
	}
}
