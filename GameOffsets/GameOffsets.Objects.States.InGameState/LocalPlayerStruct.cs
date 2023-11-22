using System;
using System.Runtime.InteropServices;

namespace GameOffsets.Objects.States.InGameState;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct LocalPlayerStruct
{
	public IntPtr ServerDataPtr;

	public IntPtr LocalPlayerPtr;
}
