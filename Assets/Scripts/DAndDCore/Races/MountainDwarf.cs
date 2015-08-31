namespace DAndDCore
{
	public class MountainDwarf : Dwarf
	{
		public MountainDwarf (int age, int height, int weight)
			: base("Mountain", age, height, weight)
		{
			abilityBonuses [AbilityName.Strength] += 2;
		}
	}
}