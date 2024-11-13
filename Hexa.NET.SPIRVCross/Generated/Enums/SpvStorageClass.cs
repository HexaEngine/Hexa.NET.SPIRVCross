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

namespace Hexa.NET.SPIRVCross
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.Enum, "SpvStorageClass_")]
	[Flags]
	public enum SpvStorageClass : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassUniformConstant")]
		[NativeName(NativeNameType.Value, "0")]
		UniformConstant = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassInput")]
		[NativeName(NativeNameType.Value, "1")]
		Input = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassUniform")]
		[NativeName(NativeNameType.Value, "2")]
		Uniform = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassOutput")]
		[NativeName(NativeNameType.Value, "3")]
		Output = unchecked(3),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassWorkgroup")]
		[NativeName(NativeNameType.Value, "4")]
		Workgroup = unchecked(4),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassCrossWorkgroup")]
		[NativeName(NativeNameType.Value, "5")]
		CrossWorkgroup = unchecked(5),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassPrivate")]
		[NativeName(NativeNameType.Value, "6")]
		Private = unchecked(6),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassFunction")]
		[NativeName(NativeNameType.Value, "7")]
		Function = unchecked(7),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassGeneric")]
		[NativeName(NativeNameType.Value, "8")]
		Generic = unchecked(8),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassPushConstant")]
		[NativeName(NativeNameType.Value, "9")]
		PushConstant = unchecked(9),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassAtomicCounter")]
		[NativeName(NativeNameType.Value, "10")]
		AtomicCounter = unchecked(10),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassImage")]
		[NativeName(NativeNameType.Value, "11")]
		Image = unchecked(11),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassStorageBuffer")]
		[NativeName(NativeNameType.Value, "12")]
		Buffer = unchecked(12),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassCallableDataKHR")]
		[NativeName(NativeNameType.Value, "5328")]
		CallableDataKhr = unchecked(5328),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassCallableDataNV")]
		[NativeName(NativeNameType.Value, "5328")]
		CallableDataNv = unchecked(5328),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassIncomingCallableDataKHR")]
		[NativeName(NativeNameType.Value, "5329")]
		IncomingCallableDataKhr = unchecked(5329),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassIncomingCallableDataNV")]
		[NativeName(NativeNameType.Value, "5329")]
		IncomingCallableDataNv = unchecked(5329),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassRayPayloadKHR")]
		[NativeName(NativeNameType.Value, "5338")]
		RayPayloadKhr = unchecked(5338),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassRayPayloadNV")]
		[NativeName(NativeNameType.Value, "5338")]
		RayPayloadNv = unchecked(5338),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassHitAttributeKHR")]
		[NativeName(NativeNameType.Value, "5339")]
		HitAttributeKhr = unchecked(5339),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassHitAttributeNV")]
		[NativeName(NativeNameType.Value, "5339")]
		HitAttributeNv = unchecked(5339),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassIncomingRayPayloadKHR")]
		[NativeName(NativeNameType.Value, "5342")]
		IncomingRayPayloadKhr = unchecked(5342),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassIncomingRayPayloadNV")]
		[NativeName(NativeNameType.Value, "5342")]
		IncomingRayPayloadNv = unchecked(5342),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassShaderRecordBufferKHR")]
		[NativeName(NativeNameType.Value, "5343")]
		ShaderRecordBufferKhr = unchecked(5343),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassShaderRecordBufferNV")]
		[NativeName(NativeNameType.Value, "5343")]
		ShaderRecordBufferNv = unchecked(5343),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassPhysicalStorageBuffer")]
		[NativeName(NativeNameType.Value, "5349")]
		PhysicalStorageBuffer = unchecked(5349),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassPhysicalStorageBufferEXT")]
		[NativeName(NativeNameType.Value, "5349")]
		PhysicalStorageBufferExt = unchecked(5349),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassTaskPayloadWorkgroupEXT")]
		[NativeName(NativeNameType.Value, "5402")]
		TaskPayloadWorkgroupExt = unchecked(5402),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassCodeSectionINTEL")]
		[NativeName(NativeNameType.Value, "5605")]
		CodeSectionIntel = unchecked(5605),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassDeviceOnlyINTEL")]
		[NativeName(NativeNameType.Value, "5936")]
		DeviceOnlyIntel = unchecked(5936),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassHostOnlyINTEL")]
		[NativeName(NativeNameType.Value, "5937")]
		HostOnlyIntel = unchecked(5937),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvStorageClassMax")]
		[NativeName(NativeNameType.Value, "2147483647")]
		Max = unchecked(2147483647),
	}
}
