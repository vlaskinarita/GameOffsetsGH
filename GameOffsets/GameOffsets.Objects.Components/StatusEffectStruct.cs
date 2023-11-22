using System;
using System.Runtime.InteropServices;

namespace GameOffsets.Objects.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct StatusEffectStruct
{
	[FieldOffset(8)]
	public IntPtr BuffDefinationPtr;

	[FieldOffset(24)]
	public float TotalTime;

	[FieldOffset(28)]
	public float TimeLeft;

	[FieldOffset(40)]
	public uint SourceEntityId;

	[FieldOffset(62)]
	public short Charges;

	[FieldOffset(64)]
	public short FlaskSlot;

	[FieldOffset(66)]
	public short Effectiveness;

	[FieldOffset(70)]
	public uint UnknownIdAndEquipmentInfo;

	public override string ToString()
	{
		return $"BuffDefinationPtr: {BuffDefinationPtr.ToInt64():X} Total Time: {TotalTime} Time Left: {TimeLeft} Entity Id: {SourceEntityId} Charges: {Charges} Flask Slot: {FlaskSlot} Effectiveness: {100 + Effectiveness} (raw: {Effectiveness}) UnknownIdAndEquipmentInfo: {UnknownIdAndEquipmentInfo:X}";
	}
}
