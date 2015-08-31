namespace DAndDCore
{
	public class HillDwarf : Dwarf
	{
		public HillDwarf (int age, int height, int weight)
			: base("Hill", age, height, weight)
		{
			abilityBonuses [AbilityName.Wisdom] += 1;
		}
	}
}