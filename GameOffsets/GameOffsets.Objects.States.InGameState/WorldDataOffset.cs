using System;
using System.Runtime.InteropServices;

namespace GameOffsets.Objects.States.InGameState;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct WorldDataOffset
{
	[FieldOffset(160)]
	public IntPtr WorldAreaDetailsPtr;

	[FieldOffset(168)]
	public CameraStructure CameraStructurePtr;
}
