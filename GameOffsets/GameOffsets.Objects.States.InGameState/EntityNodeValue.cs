using System;
using System.Runtime.InteropServices;

namespace GameOffsets.Objects.States.InGameState;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct EntityNodeValue
{
	public IntPtr EntityPtr;

	public override string ToString()
	{
		return $"EntityPtr: {EntityPtr.ToInt64():X}";
	}
}
