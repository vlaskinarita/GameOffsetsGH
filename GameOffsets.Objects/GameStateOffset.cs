using System;
using System.Runtime.InteropServices;
using GameOffsets.Natives;

namespace GameOffsets.Objects;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GameStateOffset
{
	[FieldOffset(8)]
	public StdVector CurrentStatePtr;

	[FieldOffset(72)]
	public IntPtr State0;

	[FieldOffset(88)]
	public IntPtr State1;

	[FieldOffset(104)]
	public IntPtr State2;

	[FieldOffset(120)]
	public IntPtr State3;

	[FieldOffset(136)]
	public IntPtr State4;

	[FieldOffset(152)]
	public IntPtr State5;

	[FieldOffset(168)]
	public IntPtr State6;

	[FieldOffset(184)]
	public IntPtr State7;

	[FieldOffset(200)]
	public IntPtr State8;

	[FieldOffset(216)]
	public IntPtr State9;

	[FieldOffset(232)]
	public IntPtr State10;

	[FieldOffset(248)]
	public IntPtr State11;
}
