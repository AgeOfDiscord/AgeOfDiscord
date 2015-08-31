namespace DAndDCore 
{
	public class Dwarf : BaseRace
	{
		public Dwarf (string subraceName, int age, int height, int weight)
			: base("Dwarf", subraceName, age, height, weight, 25, Size.Medium)
		{
			abilityBonuses [AbilityName.Constitution] += 2;
		}
	}
}