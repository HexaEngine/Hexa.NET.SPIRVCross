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
	/// Maps to C++ API. <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "spvc_msl_format_resolution")]
	[Flags]
	public enum SpvcMslFormatResolution : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPVC_MSL_FORMAT_RESOLUTION_444")]
		[NativeName(NativeNameType.Value, "0")]
		Resolution444 = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPVC_MSL_FORMAT_RESOLUTION_422")]
		[NativeName(NativeNameType.Value, "1")]
		Resolution422 = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPVC_MSL_FORMAT_RESOLUTION_420")]
		[NativeName(NativeNameType.Value, "2")]
		Resolution420 = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPVC_MSL_FORMAT_RESOLUTION_INT_MAX")]
		[NativeName(NativeNameType.Value, "2147483647")]
		IntMax = unchecked(2147483647),
	}
}
