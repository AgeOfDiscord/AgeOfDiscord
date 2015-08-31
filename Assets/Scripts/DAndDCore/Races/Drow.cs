namespace DAndDCore
{
	public class Drow : Elf
	{
		public Drow (int age, int height, int weight)
			: base("Drow", age, height, weight)
		{
			abilityBonuses [AbilityName.Charisma] += 1;
		}
	}
}