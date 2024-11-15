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
	/// Maps to C++ API. <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SpvcMslShaderInterfaceVar2
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public uint Location;

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
		public uint Vecsize;

		/// <summary>
		/// To be documented.
		/// </summary>
		public SpvcMslShaderVariableRate Rate;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe SpvcMslShaderInterfaceVar2(uint location = default, SpvcMslShaderVariableFormat format = default, SpvBuiltIn builtin = default, uint vecsize = default, SpvcMslShaderVariableRate rate = default)
		{
			Location = location;
			Format = format;
			Builtin = builtin;
			Vecsize = vecsize;
			Rate = rate;
		}


	}

}
