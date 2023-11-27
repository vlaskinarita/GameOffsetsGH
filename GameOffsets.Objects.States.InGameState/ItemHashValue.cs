using System;
using System.Runtime.InteropServices;

namespace GameOffsets.Objects.States.InGameState;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct ItemHashValue
{
	public IntPtr InventoryItemStructPtr;

	public IntPtr UselessItemPtr;
}
