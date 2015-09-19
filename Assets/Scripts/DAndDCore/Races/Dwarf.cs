namespace DAndDCore 
{
	public class Dwarf : BaseRace
	{
		public Dwarf (string subraceName, int age, float height, int weight, Gender gender)
			: base("Dwarf", subraceName, age, height, weight, 20, Size.Medium, RaceType.Humanoid, gender)
		{
			abilityBonuses [AbilityName.Constitution] += 2;
			abilityBonuses [AbilityName.Wisdom] += 2;
			abilityBonuses [AbilityName.Charisma] -= 2;

			languages.Add (Language.Dwarven);

			traits.Add (TraitName.DwarfSpeed);
			traits.Add (TraitName.DwarfWeaponFamiliarity);
		}
	}
}