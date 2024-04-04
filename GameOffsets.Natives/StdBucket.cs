using System.Runtime.InteropServices;

namespace GameOffsets.Natives;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct StdBucket
{
	public StdVector Data;

	public nint UnknownPtr;

	public int Capacity;

	public int PAD_0x24;

	public int Unknown1;

	public int PAD_0x2C;

	public int Unknown2;

	public int Unknown3;
}
