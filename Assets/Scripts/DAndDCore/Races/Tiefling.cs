namespace DAndDCore 
{
	public class Tiefling : BaseRace
	{
		public Tiefling (int age, int height, int weight)
			: base("Tiefling", null, age, height, weight, 30, Size.Medium)
		{
			abilityBonuses [AbilityName.Intelligence] += 1;
			abilityBonuses [AbilityName.Charisma] += 2;
		}

	}
}