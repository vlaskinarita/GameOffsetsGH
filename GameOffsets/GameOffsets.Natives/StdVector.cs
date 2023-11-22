using System;
using System.Runtime.InteropServices;

namespace GameOffsets.Natives;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct StdVector
{
	public IntPtr First;

	public IntPtr Last;

	public IntPtr End;

	public long TotalElements(int elementSize)
	{
		return (Last.ToInt64() - First.ToInt64()) / elementSize;
	}

	public override string ToString()
	{
		return $"First: {First.ToInt64():X} - Last: {Last.ToInt64():X} - Size (bytes): {TotalElements(1)}";
	}
}
