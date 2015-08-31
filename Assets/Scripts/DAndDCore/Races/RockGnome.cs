namespace DAndDCore
{
	public class RockGnome : Gnome
	{
		public RockGnome (int age, int height, int weight)
			: base("Rock", age, height, weight)
		{
			abilityBonuses [AbilityName.Constitution] += 1;
		}
	}
}