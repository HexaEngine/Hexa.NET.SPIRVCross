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

namespace Hexa.NET.SPIRVCross
{
	/// <summary>
	/// Maps to C++ API. Deprecated; use spvc_msl_shader_interface_var. <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "spvc_msl_vertex_attribute")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SpvcMslVertexAttribute
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "location")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint Location;

		/// <summary>
		/// Obsolete, do not use. Only lingers on for ABI compatibility. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "msl_buffer")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint MslBuffer;

		/// <summary>
		/// Obsolete, do not use. Only lingers on for ABI compatibility. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "msl_offset")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint MslOffset;

		/// <summary>
		/// Obsolete, do not use. Only lingers on for ABI compatibility. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "msl_stride")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint MslStride;

		/// <summary>
		/// Obsolete, do not use. Only lingers on for ABI compatibility. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "per_instance")]
		[NativeName(NativeNameType.Type, "spvc_bool")]
		public byte PerInstance;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "format")]
		[NativeName(NativeNameType.Type, "spvc_msl_vertex_format")]
		public SpvcMslShaderVariableFormat Format;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "builtin")]
		[NativeName(NativeNameType.Type, "SpvBuiltIn")]
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
