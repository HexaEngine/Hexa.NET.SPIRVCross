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
	/// To be documented.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SpvcReflectedBuiltinResource
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public SpvBuiltIn Builtin;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint ValueTypeId;

		/// <summary>
		/// To be documented.
		/// </summary>
		public SpvcReflectedResource Resource;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe SpvcReflectedBuiltinResource(SpvBuiltIn builtin = default, uint valueTypeId = default, SpvcReflectedResource resource = default)
		{
			Builtin = builtin;
			ValueTypeId = valueTypeId;
			Resource = resource;
		}


	}

}
