using System;
using System.Runtime.InteropServices;

namespace GameOffsets.Natives;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct StdBucket
{
	public long PAD_00;

	public IntPtr Data;

	public long Capacity;

	public int Unknown3;

	public float Unknown4;

	public int PAD_20;

	public int PAD_24;
}
