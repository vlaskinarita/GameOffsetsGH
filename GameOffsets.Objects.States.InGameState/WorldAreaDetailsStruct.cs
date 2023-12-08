using System.Runtime.InteropServices;

namespace GameOffsets.Objects.States.InGameState;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct WorldAreaDetailsStruct
{
	[FieldOffset(136)]
	public nint WorldAreaDetailsRowPtr;
}
