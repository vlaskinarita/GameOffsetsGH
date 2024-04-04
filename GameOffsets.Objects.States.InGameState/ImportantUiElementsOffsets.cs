using System.Runtime.InteropServices;

namespace GameOffsets.Objects.States.InGameState;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ImportantUiElementsOffsets
{
	[FieldOffset(1168)]
	public nint ChatParentPtr;

	[FieldOffset(1448)]
	public nint PassiveSkillTreePanel;

	[FieldOffset(1592)]
	public nint MapParentPtr;

	[FieldOffset(1952)]
	public nint ControllerModeMapParentPtr;

	[FieldOffset(2272)]
	public nint NecropolisMonsterPanel;
}
