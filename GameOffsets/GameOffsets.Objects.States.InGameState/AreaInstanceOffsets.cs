using System;
using System.Runtime.InteropServices;
using GameOffsets.Natives;

namespace GameOffsets.Objects.States.InGameState;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AreaInstanceOffsets
{
	[FieldOffset(168)]
	public byte MonsterLevel;

	[FieldOffset(236)]
	public uint CurrentAreaHash;

	[FieldOffset(1832)]
	public StdVector Environments;

	[FieldOffset(1880)]
	public IntPtr ServerDataPtr;

	[FieldOffset(1888)]
	public IntPtr LocalPlayerPtr;

	[FieldOffset(2064)]
	public StdMap AwakeEntities;

	[FieldOffset(2080)]
	public StdMap SleepingEntities;

	[FieldOffset(2464)]
	public TerrainStruct TerrainMetadata;
}
