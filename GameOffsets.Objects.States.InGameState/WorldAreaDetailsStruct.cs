using System.Runtime.InteropServices;

namespace GameOffsets.Objects.States.InGameState;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct WorldAreaDetailsStruct
{
	[FieldOffset(168)]
	public nint WorldAreaDetailsRowPtr;
}
