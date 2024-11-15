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

namespace Hexa.NET.SPIRVCross
{
	/// <summary>
	/// Maps to C++ API. Deprecated; use spvc_msl_shader_interface_var. <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SpvcMslVertexAttribute
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public uint Location;

		/// <summary>
		/// Obsolete, do not use. Only lingers on for ABI compatibility. <br/>
		/// </summary>
		public uint MslBuffer;

		/// <summary>
		/// Obsolete, do not use. Only lingers on for ABI compatibility. <br/>
		/// </summary>
		public uint MslOffset;

		/// <summary>
		/// Obsolete, do not use. Only lingers on for ABI compatibility. <br/>
		/// </summary>
		public uint MslStride;

		/// <summary>
		/// Obsolete, do not use. Only lingers on for ABI compatibility. <br/>
		/// </summary>
		public byte PerInstance;

		/// <summary>
		/// To be documented.
		/// </summary>
		public SpvcMslShaderVariableFormat Format;

		/// <summary>
		/// To be documented.
		/// </summary>
		public SpvBuiltIn Builtin;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe SpvcMslVertexAttribute(uint location = default, uint mslBuffer = default, uint mslOffset = default, uint mslStride = default, bool perInstance = default, SpvcMslShaderVariableFormat format = default, SpvBuiltIn builtin = default)
		{
			Location = location;
			MslBuffer = mslBuffer;
			MslOffset = mslOffset;
			MslStride = mslStride;
			PerInstance = perInstance ? (byte)1 : (byte)0;
			Format = format;
			Builtin = builtin;
		}


	}

}
