using System.Runtime.InteropServices;
using GameOffsets.Natives;

namespace GameOffsets.Objects.States.InGameState;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ServerDataStructure
{
	public const int SKIP = 39168;

	[FieldOffset(1224)]
	public StdVector PlayerInventories;
}
