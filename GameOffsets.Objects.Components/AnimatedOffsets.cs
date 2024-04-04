using System.Runtime.InteropServices;

namespace GameOffsets.Objects.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AnimatedOffsets
{
	[FieldOffset(0)]
	public ComponentHeader Header;

	[FieldOffset(592)]
	public nint AnimatedEntityPtr;
}
