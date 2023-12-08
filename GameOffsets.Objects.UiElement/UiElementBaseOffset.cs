using System.Runtime.InteropServices;
using GameOffsets.Natives;

namespace GameOffsets.Objects.UiElement;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UiElementBaseOffset
{
	[FieldOffset(0)]
	public nint Vtable;

	[FieldOffset(40)]
	public nint Self;

	[FieldOffset(48)]
	public StdVector ChildrensPtr;

	[FieldOffset(168)]
	public StdTuple2D<float> PositionModifier;

	[FieldOffset(176)]
	public StdWString Id;

	[FieldOffset(210)]
	public byte ScaleIndex;

	[FieldOffset(224)]
	public nint ParentPtr;

	[FieldOffset(232)]
	public StdTuple2D<float> RelativePosition;

	[FieldOffset(256)]
	public float LocalScaleMultiplier;

	[FieldOffset(352)]
	public uint Flags;

	[FieldOffset(384)]
	public StdTuple2D<float> UnscaledSize;

	[FieldOffset(444)]
	public uint BackgroundColor;
}