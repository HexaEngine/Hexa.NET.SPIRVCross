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

namespace Hexa.NET.SPIRV.Core
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[Flags]
	public enum SpvMemorySemanticsMask : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		None = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		AcquireMask = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		ReleaseMask = unchecked(4),

		/// <summary>
		/// To be documented.
		/// </summary>
		AcquireReleaseMask = unchecked(8),

		/// <summary>
		/// To be documented.
		/// </summary>
		SequentiallyConsistentMask = unchecked(16),

		/// <summary>
		/// To be documented.
		/// </summary>
		UniformMemoryMask = unchecked(64),

		/// <summary>
		/// To be documented.
		/// </summary>
		SubgroupMemoryMask = unchecked(128),

		/// <summary>
		/// To be documented.
		/// </summary>
		WorkgroupMemoryMask = unchecked(256),

		/// <summary>
		/// To be documented.
		/// </summary>
		CrossWorkgroupMemoryMask = unchecked(512),

		/// <summary>
		/// To be documented.
		/// </summary>
		AtomicCounterMemoryMask = unchecked(1024),

		/// <summary>
		/// To be documented.
		/// </summary>
		ImageMemoryMask = unchecked(2048),

		/// <summary>
		/// To be documented.
		/// </summary>
		OutputMemoryMask = unchecked(4096),

		/// <summary>
		/// To be documented.
		/// </summary>
		OutputMemoryKhrMask = unchecked(4096),

		/// <summary>
		/// To be documented.
		/// </summary>
		MakeAvailableMask = unchecked(8192),

		/// <summary>
		/// To be documented.
		/// </summary>
		MakeAvailableKhrMask = unchecked(8192),

		/// <summary>
		/// To be documented.
		/// </summary>
		MakeVisibleMask = unchecked(16384),

		/// <summary>
		/// To be documented.
		/// </summary>
		MakeVisibleKhrMask = unchecked(16384),

		/// <summary>
		/// To be documented.
		/// </summary>
		VolatileMask = unchecked(32768),
	}
}
