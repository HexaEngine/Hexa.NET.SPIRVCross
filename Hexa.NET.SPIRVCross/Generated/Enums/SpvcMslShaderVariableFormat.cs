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
	/// Maps to C++ API. <br/>
	/// </summary>
	[Flags]
	public enum SpvcMslShaderVariableFormat : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		Other = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		Uint8 = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		Uint16 = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		Any16 = unchecked(3),

		/// <summary>
		/// To be documented.
		/// </summary>
		Any32 = unchecked(4),

		/// <summary>
		/// Deprecated names. <br/>
		/// </summary>
		VertexFormatOther = Other,

		/// <summary>
		/// Deprecated names. <br/>
		/// </summary>
		VertexFormatUint8 = Uint8,

		/// <summary>
		/// Deprecated names. <br/>
		/// </summary>
		VertexFormatUint16 = Uint16,

		/// <summary>
		/// Deprecated names. <br/>
		/// </summary>
		InputFormatOther = Other,

		/// <summary>
		/// Deprecated names. <br/>
		/// </summary>
		InputFormatUint8 = Uint8,

		/// <summary>
		/// Deprecated names. <br/>
		/// </summary>
		InputFormatUint16 = Uint16,

		/// <summary>
		/// Deprecated names. <br/>
		/// </summary>
		InputFormatAny16 = Any16,

		/// <summary>
		/// Deprecated names. <br/>
		/// </summary>
		InputFormatAny32 = Any32,

		/// <summary>
		/// Deprecated names. <br/>
		/// </summary>
		InputFormatIntMax = unchecked(2147483647),
	}
}
