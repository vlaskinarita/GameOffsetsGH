using System;
using System.Runtime.InteropServices;

namespace GameOffsets.Objects.FilesStructures;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct WorldAreaDatOffsets
{
	[FieldOffset(0)]
	public IntPtr IdPtr;

	[FieldOffset(8)]
	public IntPtr NamePtr;

	[FieldOffset(16)]
	public int Act;

	[FieldOffset(20)]
	public bool IsTown;

	[FieldOffset(21)]
	public bool HasWaypoint;
}
