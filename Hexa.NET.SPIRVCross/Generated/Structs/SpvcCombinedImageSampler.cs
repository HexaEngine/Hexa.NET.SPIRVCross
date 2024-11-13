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
	/// See C++ API. <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "spvc_combined_image_sampler")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SpvcCombinedImageSampler
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "combined_id")]
		[NativeName(NativeNameType.Type, "spvc_variable_id")]
		public uint CombinedId;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "image_id")]
		[NativeName(NativeNameType.Type, "spvc_variable_id")]
		public uint ImageId;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "sampler_id")]
		[NativeName(NativeNameType.Type, "spvc_variable_id")]
		public uint SamplerId;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe SpvcCombinedImageSampler(uint combinedId = default, uint imageId = default, uint samplerId = default)
		{
			CombinedId = combinedId;
			ImageId = imageId;
			SamplerId = samplerId;
		}


	}

}