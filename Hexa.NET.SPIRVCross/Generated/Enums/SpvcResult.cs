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

namespace Hexa.NET.SPIRVCross
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[Flags]
	public enum SpvcResult : int
	{
		/// <summary>
		/// Success. <br/>
		/// </summary>
		Success = unchecked(0),

		/// <summary>
		/// The SPIR-V is invalid. Should have been caught by validation ideally. <br/>
		/// </summary>
		ErrorInvalidSpirv = unchecked(-1),

		/// <summary>
		/// The SPIR-V might be valid or invalid, but SPIRV-Cross currently cannot correctly translate this to your target language. <br/>
		/// </summary>
		ErrorUnsupportedSpirv = unchecked(-2),

		/// <summary>
		/// If for some reason we hit this, new or malloc failed. <br/>
		/// </summary>
		ErrorOutOfMemory = unchecked(-3),

		/// <summary>
		/// Invalid API argument. <br/>
		/// </summary>
		ErrorInvalidArgument = unchecked(-4),

		/// <summary>
		/// Invalid API argument. <br/>
		/// </summary>
		ErrorIntMax = unchecked(2147483647),
	}
}
