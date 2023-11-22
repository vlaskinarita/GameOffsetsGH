using System;
using System.Runtime.InteropServices;

namespace GameOffsets.Objects.States;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct InGameStateOffset
{
	[FieldOffset(24)]
	public IntPtr AreaInstanceData;

	[FieldOffset(120)]
	public IntPtr WorldData;

	[FieldOffset(424)]
	public IntPtr UiRootPtr;

	[FieldOffset(1112)]
	public IntPtr IngameUi;
}
