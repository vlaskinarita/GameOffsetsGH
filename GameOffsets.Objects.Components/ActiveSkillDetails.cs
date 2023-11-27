using System;
using System.Runtime.InteropServices;

namespace GameOffsets.Objects.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ActiveSkillDetails
{
	[FieldOffset(8)]
	public int UseStage;

	[FieldOffset(12)]
	public int CastType;

	[FieldOffset(16)]
	public uint UnknownIdAndEquipmentInfo;

	[FieldOffset(24)]
	public IntPtr GrantedEffectsPerLevelDatRow;

	[FieldOffset(32)]
	public IntPtr ActiveSkillsDatPtr;

	[FieldOffset(48)]
	public IntPtr GrantedEffectStatSetsPerLevelDatRow;

	[FieldOffset(128)]
	public bool CanBeUsedWithWeapon;

	[FieldOffset(129)]
	public bool CannotBeUsed;

	[FieldOffset(130)]
	public byte UnknownByte0;

	[FieldOffset(131)]
	public byte UnknownByte1;

	[FieldOffset(132)]
	public int TotalUses;
}
