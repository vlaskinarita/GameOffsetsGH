using System;
using System.Runtime.InteropServices;

namespace GameOffsets.Objects.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ComponentHeader
{
	[FieldOffset(0)]
	public IntPtr StaticPtr;

	[FieldOffset(8)]
	public IntPtr EntityPtr;
}
