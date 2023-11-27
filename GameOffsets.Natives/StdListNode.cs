using System;
using System.Runtime.InteropServices;

namespace GameOffsets.Natives;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct StdListNode<TValue> where TValue : struct
{
	public IntPtr Next;

	public IntPtr Previous;

	public TValue Data;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct StdListNode
{
	public IntPtr Next;

	public IntPtr Previous;
}
