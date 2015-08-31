using System.Collections.Generic;
namespace DAndDCore
{
	public class Ability {
		public Dictionary<AbilityName, int> values;
		
		public Ability(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma) {
			values.Add (AbilityName.Strength, strength);
			values.Add (AbilityName.Dexterity, dexterity);
			values.Add (AbilityName.Constitution, constitution);
			values.Add (AbilityName.Intelligence, intelligence);
			values.Add (AbilityName.Wisdom, wisdom);
			values.Add (AbilityName.Charisma, charisma);
		}
		
		public static int GetModifier(int ability) {
			return (ability - 10) / 2;
		}
	}
}