using System;
using System.Runtime.InteropServices;

namespace GameOffsets.Objects;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct FilesPointerStructure
{
	public IntPtr Useless0;

	public IntPtr FilesPointer;

	public IntPtr Useless1;
}
