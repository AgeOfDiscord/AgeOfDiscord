namespace DAndDCore
{
	public class WoodElf : Elf
	{
		public WoodElf (int age, int height, int weight)
			: base("Wood", age, height, weight)
		{
			abilityBonuses [AbilityName.Wisdom] += 1;
		}
	}
}