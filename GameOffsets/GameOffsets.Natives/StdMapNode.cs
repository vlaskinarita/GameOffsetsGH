using System;
using System.Runtime.InteropServices;

namespace GameOffsets.Natives;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct StdMapNode<TKey, TValue> where TKey : struct where TValue : struct
{
	public IntPtr Left;

	public IntPtr Parent;

	public IntPtr Right;

	public byte Color;

	public bool IsNil;

	public byte pad_1A;

	public byte pad_1B;

	public uint pad_1C;

	public StdMapNodeData<TKey, TValue> Data;
}
