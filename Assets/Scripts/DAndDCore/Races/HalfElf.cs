namespace DAndDCore 
{
	public class HalfElf : BaseRace
	{
		public HalfElf (int age, int height, int weight)
			: base("HalfElf", null, age, height, weight, 30, Size.Medium)
		{
			abilityBonuses [AbilityName.Charisma] += 2;
			// TODO: two other ability scores of your choice increase by 1
		}
	}
}