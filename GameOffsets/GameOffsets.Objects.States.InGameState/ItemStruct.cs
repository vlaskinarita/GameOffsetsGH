using System;
using System.Runtime.InteropServices;
using GameOffsets.Natives;

namespace GameOffsets.Objects.States.InGameState;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemStruct
{
	[FieldOffset(0)]
	public IntPtr VTablePtr;

	[FieldOffset(8)]
	public IntPtr EntityDetailsPtr;

	[FieldOffset(16)]
	public StdVector ComponentListPtr;
}
