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
	/// Maps to the sampler Y'CbCr conversion-related portions of MSLConstexprSampler. See C++ API for defaults and details. <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "spvc_msl_sampler_ycbcr_conversion")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SpvcMslSamplerYcbcrConversion
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "planes")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint Planes;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "resolution")]
		[NativeName(NativeNameType.Type, "spvc_msl_format_resolution")]
		public SpvcMslFormatResolution Resolution;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "chroma_filter")]
		[NativeName(NativeNameType.Type, "spvc_msl_sampler_filter")]
		public SpvcMslSamplerFilter ChromaFilter;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "x_chroma_offset")]
		[NativeName(NativeNameType.Type, "spvc_msl_chroma_location")]
		public SpvcMslChromaLocation XChromaOffset;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "y_chroma_offset")]
		[NativeName(NativeNameType.Type, "spvc_msl_chroma_location")]
		public SpvcMslChromaLocation YChromaOffset;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "swizzle")]
		[NativeName(NativeNameType.Type, "spvc_msl_component_swizzle[4]")]
		public SpvcMslComponentSwizzle Swizzle_0;
		public SpvcMslComponentSwizzle Swizzle_1;
		public SpvcMslComponentSwizzle Swizzle_2;
		public SpvcMslComponentSwizzle Swizzle_3;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "ycbcr_model")]
		[NativeName(NativeNameType.Type, "spvc_msl_sampler_ycbcr_model_conversion")]
		public SpvcMslSamplerYcbcrModelConversion YcbcrModel;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "ycbcr_range")]
		[NativeName(NativeNameType.Type, "spvc_msl_sampler_ycbcr_range")]
		public SpvcMslSamplerYcbcrRange YcbcrRange;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "bpc")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint Bpc;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe SpvcMslSamplerYcbcrConversion(uint planes = default, SpvcMslFormatResolution resolution = default, SpvcMslSamplerFilter chromaFilter = default, SpvcMslChromaLocation xChromaOffset = default, SpvcMslChromaLocation yChromaOffset = default, SpvcMslComponentSwizzle* swizzle = default, SpvcMslSamplerYcbcrModelConversion ycbcrModel = default, SpvcMslSamplerYcbcrRange ycbcrRange = default, uint bpc = default)
		{
			Planes = planes;
			Resolution = resolution;
			ChromaFilter = chromaFilter;
			XChromaOffset = xChromaOffset;
			YChromaOffset = yChromaOffset;
			if (swizzle != default(SpvcMslComponentSwizzle*))
			{
				Swizzle_0 = swizzle[0];
				Swizzle_1 = swizzle[1];
				Swizzle_2 = swizzle[2];
				Swizzle_3 = swizzle[3];
			}
			YcbcrModel = ycbcrModel;
			YcbcrRange = ycbcrRange;
			Bpc = bpc;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe SpvcMslSamplerYcbcrConversion(uint planes = default, SpvcMslFormatResolution resolution = default, SpvcMslSamplerFilter chromaFilter = default, SpvcMslChromaLocation xChromaOffset = default, SpvcMslChromaLocation yChromaOffset = default, Span<SpvcMslComponentSwizzle> swizzle = default, SpvcMslSamplerYcbcrModelConversion ycbcrModel = default, SpvcMslSamplerYcbcrRange ycbcrRange = default, uint bpc = default)
		{
			Planes = planes;
			Resolution = resolution;
			ChromaFilter = chromaFilter;
			XChromaOffset = xChromaOffset;
			YChromaOffset = yChromaOffset;
			if (swizzle != default(Span<SpvcMslComponentSwizzle>))
			{
				Swizzle_0 = swizzle[0];
				Swizzle_1 = swizzle[1];
				Swizzle_2 = swizzle[2];
				Swizzle_3 = swizzle[3];
			}
			YcbcrModel = ycbcrModel;
			YcbcrRange = ycbcrRange;
			Bpc = bpc;
		}


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe Span<SpvcMslComponentSwizzle> Swizzle
		
		{
			get
			{
				fixed (SpvcMslComponentSwizzle* p = &this.Swizzle_0)
				{
					return new Span<SpvcMslComponentSwizzle>(p, 4);
				}
			}
		}
	}

}
