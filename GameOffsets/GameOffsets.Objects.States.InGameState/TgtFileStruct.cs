using System;
using System.Runtime.InteropServices;
using GameOffsets.Natives;

namespace GameOffsets.Objects.States.InGameState;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct TgtFileStruct
{
	public IntPtr Vtable;

	public StdWString TgtPath;
}
