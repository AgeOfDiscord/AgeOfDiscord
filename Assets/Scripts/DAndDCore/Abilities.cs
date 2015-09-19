using System.Collections.Generic;
namespace DAndDCore
{
	public class Abilities 
	{
		private Dictionary<AbilityName, int> values = new Dictionary<AbilityName, int>();
		
		public Abilities(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma) 
		{
			values.Add (AbilityName.Strength, strength);
			values.Add (AbilityName.Dexterity, dexterity);
			values.Add (AbilityName.Constitution, constitution);
			values.Add (AbilityName.Intelligence, intelligence);
			values.Add (AbilityName.Wisdom, wisdom);
			values.Add (AbilityName.Charisma, charisma);
		}

		public int this[AbilityName abilityName] 
		{
			get { return values[abilityName]; }
			set { values [abilityName] = value; }
		}
	}
}