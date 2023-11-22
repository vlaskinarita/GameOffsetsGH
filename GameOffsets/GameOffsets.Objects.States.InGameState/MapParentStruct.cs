using System;
using System.Runtime.InteropServices;

namespace GameOffsets.Objects.States.InGameState;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapParentStruct
{
	[FieldOffset(640)]
	public IntPtr LargeMapPtr;

	[FieldOffset(648)]
	public IntPtr MiniMapPtr;
}
