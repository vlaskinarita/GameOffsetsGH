using System.Runtime.InteropServices;
using GameOffsets.Natives;

namespace GameOffsets.Objects.States.InGameState;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ServerDataStructure
{
	public const int SKIP = 44288;

	[FieldOffset(64)]
	public StdVector PlayerInventories;
}
