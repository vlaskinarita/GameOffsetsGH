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

	[FieldOffset(1952)]
	public StdVector Environments;

	[FieldOffset(2000)]
	public IntPtr ServerDataPtr;

	[FieldOffset(2008)]
	public IntPtr LocalPlayerPtr;

	[FieldOffset(2184)]
	public StdMap AwakeEntities;

	[FieldOffset(2200)]
	public StdMap SleepingEntities;

	[FieldOffset(2600)]
	public TerrainStruct TerrainMetadata;
}
