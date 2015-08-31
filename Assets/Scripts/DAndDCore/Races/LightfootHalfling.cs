namespace DAndDCore
{
	public class LightfootHalfling : Halfling
	{
		public LightfootHalfling (int age, int height, int weight)
			: base("Lightfoot", age, height, weight)
		{
			abilityBonuses [AbilityName.Charisma] += 1;
		}
	}
}