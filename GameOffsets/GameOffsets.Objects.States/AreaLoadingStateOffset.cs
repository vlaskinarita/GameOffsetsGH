using System.Runtime.InteropServices;
using GameOffsets.Natives;

namespace GameOffsets.Objects.States;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AreaLoadingStateOffset
{
	[FieldOffset(200)]
	public int IsLoading;

	[FieldOffset(896)]
	public uint TotalLoadingScreenTimeMs;

	[FieldOffset(960)]
	public StdWString CurrentAreaName;
}
