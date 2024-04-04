using System.Runtime.InteropServices;

namespace GameOffsets.Objects.States;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct InGameStateOffset
{
	[FieldOffset(536)]
	public nint AreaInstanceData;

	[FieldOffset(632)]
	public nint WorldData;

	[FieldOffset(1312)]
	public nint UiRootPtr;

	[FieldOffset(2024)]
	public nint IngameUi;
}
