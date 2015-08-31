using System.Collections.Generic;
namespace DAndDCore 
{
	public class BaseRace
	{
		public string name { get; private set; }
		public string subraceName { get; private set; }
		public int speed { get; private set; }
		public Size size { get; private set; }
		public int age { get; protected set; }
		public int height { get; protected set; }
		public int weight { get; protected set; }
		public Dictionary<AbilityName, int> abilityBonuses { get; protected set; }
		
		public BaseRace (string name, string subraceName, int age, int height, int weight, int speed, Size size)
		{
			this.name = name;
			this.subraceName = subraceName;
			this.age = age;
			this.height = height;
			this.weight = weight;
			this.speed = speed;
			this.size = size;
			abilityBonuses.Add(AbilityName.Strength, 0);
			abilityBonuses.Add (AbilityName.Dexterity, 0);
			abilityBonuses.Add (AbilityName.Constitution, 0);
			abilityBonuses.Add (AbilityName.Intelligence, 0);
			abilityBonuses.Add (AbilityName.Wisdom, 0);
			abilityBonuses.Add (AbilityName.Charisma, 0);
		}
	}
}