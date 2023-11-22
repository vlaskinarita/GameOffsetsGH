using System.Runtime.InteropServices;
using GameOffsets.Natives;

namespace GameOffsets.Objects.UiElement;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapUiElementOffset
{
	[FieldOffset(0)]
	public UiElementBaseOffset UiElementBase;

	[FieldOffset(616)]
	public StdTuple2D<float> Shift;

	[FieldOffset(624)]
	public StdTuple2D<float> DefaultShift;

	[FieldOffset(684)]
	public float Zoom;
}
