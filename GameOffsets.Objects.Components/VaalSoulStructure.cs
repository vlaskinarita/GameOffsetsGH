using System;
using System.Runtime.InteropServices;

namespace GameOffsets.Objects.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct VaalSoulStructure
{
	[FieldOffset(0)]
	public IntPtr ActiveSkillsDatPtr;

	[FieldOffset(8)]
	public IntPtr UselessPtr;

	[FieldOffset(16)]
	public int RequiredSouls;

	[FieldOffset(20)]
	public int CurrentSouls;

	[FieldOffset(24)]
	public long PAD_0x18;

	public bool CannotBeUsed()
	{
		return CurrentSouls < RequiredSouls;
	}
}
