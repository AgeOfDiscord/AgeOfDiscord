namespace DAndDCore
{
	public class HighElf : Elf
	{
		public HighElf (int age, int height, int weight)
			: base("High", age, height, weight)
		{
			abilityBonuses [AbilityName.Intelligence] += 1;
		}
	}
}