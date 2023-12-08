using System.Runtime.InteropServices;

namespace GameOffsets.Objects.States.InGameState;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ImportantUiElementsOffsets
{
	[FieldOffset(1128)]
	public nint ChatParentPtr;

	[FieldOffset(1400)]
	public nint PassiveSkillTreePanel;

	[FieldOffset(1544)]
	public nint MapParentPtr;

	[FieldOffset(1904)]
	public nint ControllerModeMapParentPtr;
}
