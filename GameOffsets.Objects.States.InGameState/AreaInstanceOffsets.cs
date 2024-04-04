using System.Runtime.InteropServices;
using GameOffsets.Natives;

namespace GameOffsets.Objects.States.InGameState;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AreaInstanceOffsets
{
	[FieldOffset(204)]
	public byte CurrentAreaLevel;

	[FieldOffset(268)]
	public uint CurrentAreaHash;

	[FieldOffset(2232)]
	public StdVector Environments;

	[FieldOffset(2280)]
	public LocalPlayerStruct PlayerInfo;

	[FieldOffset(2464)]
	public EntityListStruct Entities;

	[FieldOffset(2896)]
	public TerrainStruct TerrainMetadata;
}
