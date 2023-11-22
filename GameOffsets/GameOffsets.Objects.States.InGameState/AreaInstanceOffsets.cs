using System.Runtime.InteropServices;
using GameOffsets.Natives;

namespace GameOffsets.Objects.States.InGameState;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AreaInstanceOffsets
{
	[FieldOffset(172)]
	public byte CurrentAreaLevel;

	[FieldOffset(236)]
	public uint CurrentAreaHash;

	[FieldOffset(2072)]
	public StdVector Environments;

	[FieldOffset(2120)]
	public LocalPlayerStruct PlayerInfo;

	[FieldOffset(2304)]
	public EntityListStruct Entities;

	[FieldOffset(2720)]
	public TerrainStruct TerrainMetadata;
}
