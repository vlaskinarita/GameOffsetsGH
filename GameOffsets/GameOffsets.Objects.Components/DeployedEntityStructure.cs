using System.Runtime.InteropServices;

namespace GameOffsets.Objects.Components;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct DeployedEntityStructure
{
	public ushort DeployedObjectType;

	public ushort ActiveSkillsDatId;

	public ushort EntityId;

	public ushort Pad_0x06;

	public override string ToString()
	{
		return $"{DeployedObjectType} - {ActiveSkillsDatId} - {EntityId} - {Pad_0x06}";
	}
}
