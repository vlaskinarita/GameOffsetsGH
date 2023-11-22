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

	[FieldOffset(2080)]
	public StdVector Environments;

	[FieldOffset(2128)]
	public IntPtr ServerDataPtr;

	[FieldOffset(2136)]
	public IntPtr LocalPlayerPtr;

	[FieldOffset(2312)]
	public StdMap AwakeEntities;

	[FieldOffset(2328)]
	public StdMap SleepingEntities;

	[FieldOffset(2728)]
	public TerrainStruct TerrainMetadata;
}
