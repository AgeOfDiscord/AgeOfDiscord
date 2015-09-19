namespace DAndDCore 
{
	public static class Extensions
	{
		public static int GetModifier(this int ability) {
			return (ability - 10) / 2;
		}

		public static int GetSkillBonus(this Skill skill, Abilities abilities, int otherBonuses)
		{
			return skill.Rank + abilities[skill.Ability].GetModifier() + otherBonuses;
		}
	}
}