namespace DAndDCore
{
	public class ForestGnome : Gnome
	{
		public ForestGnome (int age, int height, int weight)
			: base("Forest", age, height, weight)
		{
			abilityBonuses [AbilityName.Dexterity] += 1;
		}
	}
}