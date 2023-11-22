using System;
using System.Runtime.InteropServices;

namespace GameOffsets.Natives;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct StdWString
{
	public IntPtr Buffer;

	public IntPtr ReservedBytes;

	public int Length;

	public int PAD_14;

	public int Capacity;

	public int PAD_1C;

	public override string ToString()
	{
		return $"Buffer: {Buffer.ToInt64():X}, ReservedBytes: {ReservedBytes.ToInt64():X}, Length: {Length}, Capacity: {Capacity}";
	}
}
