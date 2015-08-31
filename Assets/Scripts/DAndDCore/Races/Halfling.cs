namespace DAndDCore 
{
	public class Halfling : BaseRace
	{
		public Halfling (string subraceName, int age, int height, int weight)
			: base("Halfling", subraceName, age, height, weight, 25, Size.Small)
		{
			abilityBonuses [AbilityName.Dexterity] += 2;
		}
	}
}