namespace DAndDCore 
{
	public class Skill
	{
		public AbilityName abilityName;
		
		public Skill (AbilityName ability)
		{
			abilityName = ability;
		}
		
		public int GetTotalBonus(int proficienceBonus, int abilityBonus, int toolBonus, int otherBonus) 
		{
			return proficienceBonus + abilityBonus + toolBonus + otherBonus;
		}
	}
}