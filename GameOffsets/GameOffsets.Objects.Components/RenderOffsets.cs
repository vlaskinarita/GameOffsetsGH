using System.Runtime.InteropServices;
using GameOffsets.Natives;

namespace GameOffsets.Objects.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct RenderOffsets
{
	[FieldOffset(0)]
	public ComponentHeader Header;

	[FieldOffset(160)]
	public StdTuple3D<float> CurrentWorldPosition;

	[FieldOffset(172)]
	public StdTuple3D<float> CharactorModelBounds;

	[FieldOffset(260)]
	public float TerrainHeight;
}
