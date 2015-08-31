namespace DAndDCore 
{
	public class Dragonborn : BaseRace
	{
		public Dragonborn (int age, int height, int weight)
			: base("Dragonborn", null, age, height, weight, 30, Size.Medium)
		{
			abilityBonuses [AbilityName.Strength] += 2;
			abilityBonuses [AbilityName.Charisma] += 1;
		}
	}
}