namespace DAndDCore 
{
	public class Gnome : BaseRace
	{
		public Gnome (string subraceName, int age, int height, int weight)
			: base("Gnome", subraceName, age, height, weight, 25, Size.Small)
		{
			abilityBonuses [AbilityName.Intelligence] += 2;
		}
	}
}