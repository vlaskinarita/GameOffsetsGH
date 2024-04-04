using System.Runtime.InteropServices;
using GameOffsets.Natives;

namespace GameOffsets.Objects.States;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AreaLoadingStateOffset
{
	[FieldOffset(840)]
	public int IsLoading;

	[FieldOffset(1536)]
	public uint TotalLoadingScreenTimeMs;

	[FieldOffset(1600)]
	public StdWString CurrentAreaName;
}
