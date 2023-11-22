using System;
using System.Runtime.InteropServices;

namespace GameOffsets.Objects.Components;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct ActiveSkillStructure
{
	public IntPtr UselessPtr0;

	public IntPtr ActiveSkillPtr;
}
