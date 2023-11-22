using System.Runtime.InteropServices;

namespace GameOffsets.Natives;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct StdTuple3D<T>
{
	public T X;

	public T Y;

	public T Z;

	public override string ToString()
	{
		return $"X: {X}, Y: {Y}, Z: {Z}";
	}
}
