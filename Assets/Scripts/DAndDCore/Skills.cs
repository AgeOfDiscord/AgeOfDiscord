using System.Collections.Generic;
namespace DAndDCore
{
	public class Skills 
	{
		public Dictionary<SkillName, Skill> values;

		public Skills() {
			values.Add (SkillName.Athletics, new Skill(AbilityName.Strength));
			values.Add (SkillName.Acrobatics, new Skill(AbilityName.Dexterity));
			values.Add (SkillName.SleightOfHand, new Skill(AbilityName.Dexterity));
			values.Add (SkillName.Stealth, new Skill(AbilityName.Dexterity));
			values.Add (SkillName.Arcana, new Skill(AbilityName.Intelligence));
			values.Add (SkillName.History, new Skill(AbilityName.Intelligence));
			values.Add (SkillName.Investigation, new Skill(AbilityName.Intelligence));
			values.Add (SkillName.Nature, new Skill(AbilityName.Intelligence));
			values.Add (SkillName.Religion, new Skill(AbilityName.Intelligence));
			values.Add (SkillName.AnimalHandling, new Skill(AbilityName.Wisdom));
			values.Add (SkillName.Insight, new Skill(AbilityName.Wisdom));
			values.Add (SkillName.Medicine, new Skill(AbilityName.Wisdom));
			values.Add (SkillName.Perception, new Skill(AbilityName.Wisdom));
			values.Add (SkillName.Survival, new Skill(AbilityName.Wisdom));
			values.Add (SkillName.Deception, new Skill(AbilityName.Charisma));
			values.Add (SkillName.Intimidation, new Skill(AbilityName.Charisma));
			values.Add (SkillName.Performance, new Skill(AbilityName.Charisma));
			values.Add (SkillName.Persuasion, new Skill(AbilityName.Charisma));
		}
	}
}