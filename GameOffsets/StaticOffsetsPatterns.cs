using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Sequential, Size = 1)]
public struct StaticOffsetsPatterns
{
	public static readonly Pattern[] Patterns = new Pattern[6]
	{
		new Pattern("Game States", "48 83 EC ?? 48 8B F1 33 ED 48 39 2D ^ ?? ?? ?? ??"),
		new Pattern("File Root", "?? 8D ?? ^ ?? ?? ?? ?? ?? 89 ?? ?? ?? ?? 8D ?? ?? ?? ?? ?? ?? 89 ?? ?? ?? ?? 8D ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 8D ?? ?? ?? 8B ?? E8 ?? ?? ?? ?? 90"),
		new Pattern("AreaChangeCounter", "FF ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? FF ?? ^ ?? ?? ?? ?? ?? 8D ?? ?? ?? ?? 8B"),
		new Pattern("Terrain Rotator Helper", "48 ?? ?? ^ ?? ?? ?? ?? 4f ?? ?? ?? 4c ?? ?? 8b ?? 2b ??"),
		new Pattern("Terrain Rotation Selector", "48 ?? ?? ^ ?? ?? ?? ?? 44 ?? ?? ?? ?? b8 ?? ?? ?? ?? 8b ?? ?? ?? ?? 89 ?? ?? ?? BA ??"),
		new Pattern("GameCullSize", "2B ?? ^ ?? ?? ?? ?? 45 ?? ?? ?? 48 ?? ?? ?? ?? ?? ?? F3 ?? ?? ?? ?? ?? ?? ?? ?? D1")
	};
}
