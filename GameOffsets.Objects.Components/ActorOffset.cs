using System.Runtime.InteropServices;
using GameOffsets.Natives;

namespace GameOffsets.Objects.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ActorOffset
{
	[FieldOffset(0)]
	public ComponentHeader Header;

	[FieldOffset(584)]
	public int AnimationId;

	[FieldOffset(1776)]
	public StdVector ActiveSkillsPtr;

	[FieldOffset(1800)]
	public StdVector CooldownsPtr;

	[FieldOffset(1824)]
	public StdVector VaalSoulsPtr;

	[FieldOffset(1848)]
	public StdVector DeployedEntityArray;
}
