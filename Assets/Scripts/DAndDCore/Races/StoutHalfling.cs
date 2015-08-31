namespace DAndDCore
{
	public class StoutHalfling : Halfling
	{
		public StoutHalfling (int age, int height, int weight)
			: base("Stout", age, height, weight)
		{
			abilityBonuses [AbilityName.Constitution] += 1;
		}
	}
}