namespace DAndDCore 
{
	public class HalfOrc : BaseRace
	{
		public HalfOrc (int age, int height, int weight)
			: base("HalfOrc", null, age, height, weight, 30, Size.Medium)
		{
			abilityBonuses [AbilityName.Strength] += 2;
			abilityBonuses [AbilityName.Constitution] += 1;
		}
	}
}