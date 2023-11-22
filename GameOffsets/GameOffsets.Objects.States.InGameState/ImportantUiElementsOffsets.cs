using System;
using System.Runtime.InteropServices;

namespace GameOffsets.Objects.States.InGameState;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ImportantUiElementsOffsets
{
	[FieldOffset(1160)]
	public IntPtr ChatParentPtr;

	[FieldOffset(1568)]
	public IntPtr MapParentPtr;
}
