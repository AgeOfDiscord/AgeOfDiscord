namespace DAndDCore 
{
	public class Elf : BaseRace
	{
		public Elf (string subraceName, int age, int height, int weight)
			: base("Elf", subraceName, age, height, weight, 30, Size.Medium)
		{
			abilityBonuses [AbilityName.Dexterity] += 2;
		}
	}
}