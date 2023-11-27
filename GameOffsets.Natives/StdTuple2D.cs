using System.Runtime.InteropServices;

namespace GameOffsets.Natives;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct StdTuple2D<T>
{
	public T X;

	public T Y;

	public StdTuple2D(T x, T y)
	{
		X = x;
		Y = y;
	}

	public override string ToString()
	{
		return $"X: {X}, Y: {Y}";
	}
}
