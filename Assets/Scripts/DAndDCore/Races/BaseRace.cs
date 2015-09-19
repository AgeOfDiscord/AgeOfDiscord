using System.Collections.Generic;
namespace DAndDCore 
{
	public abstract class BaseRace
	{
		public string name { get; private set; }
		public string subraceName { get; private set; }
		public int baseSpeed { get; private set; }
		public Size size { get; private set; }
		public RaceType type { get; private set; }
		public Gender gender { get; private set; }
		public int age { get; protected set; }
		public float height { get; protected set; }
		public int weight { get; protected set; }
		public Dictionary<AbilityName, int> abilityBonuses { get; protected set; }
		public List<Language> languages { get; protected set; }
		public List<Language> bonusLanguages { get; protected set; }
		public List<TraitName> traits { get; protected set; }
		
		public BaseRace (string name, string subraceName, int age, float height, int weight, int speed, 
		                 Size size, RaceType type, Gender gender)
		{
			abilityBonuses = new Dictionary<AbilityName, int> ();
			languages = new List<Language> ();
			bonusLanguages = new List<Language> ();
			traits = new List<TraitName> ();

			this.name = name;
			this.subraceName = subraceName;
			this.age = age;
			this.height = height;
			this.weight = weight;
			this.baseSpeed = speed;
			this.size = size;
			this.type = type;
			this.gender = gender;
			abilityBonuses.Add (AbilityName.Strength, 0);
			abilityBonuses.Add (AbilityName.Dexterity, 0);
			abilityBonuses.Add (AbilityName.Constitution, 0);
			abilityBonuses.Add (AbilityName.Intelligence, 0);
			abilityBonuses.Add (AbilityName.Wisdom, 0);
			abilityBonuses.Add (AbilityName.Charisma, 0);
		}
	}
}