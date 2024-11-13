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
	/// Maps to C++ API.<br/>
	/// Deprecated. Use spvc_msl_resource_binding_2. <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SpvcMslResourceBinding
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public SpvExecutionModel Stage;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint DescSet;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint Binding;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint MslBuffer;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint MslTexture;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint MslSampler;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe SpvcMslResourceBinding(SpvExecutionModel stage = default, uint descSet = default, uint binding = default, uint mslBuffer = default, uint mslTexture = default, uint mslSampler = default)
		{
			Stage = stage;
			DescSet = descSet;
			Binding = binding;
			MslBuffer = mslBuffer;
			MslTexture = mslTexture;
			MslSampler = mslSampler;
		}


	}

}
