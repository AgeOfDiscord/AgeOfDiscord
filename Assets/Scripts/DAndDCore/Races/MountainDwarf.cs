namespace DAndDCore
{
	public class MountainDwarf : Dwarf
	{
		public MountainDwarf (Gender gender, int age, float height, int weight)
			: base("Mountain", age, height, weight, gender)
		{
			traits.Add (TraitName.Xenophobic);

			traits.Add (TraitName.DefensiveTraining);
			traits.Add (TraitName.Hardy);
			traits.Add (TraitName.Mountaineer);

			traits.Add (TraitName.Greed);
			traits.Add (TraitName.RockStepper);

			traits.Add (TraitName.SurfaceSurvivalist);

			traits.Add (TraitName.AncientEnmity);
		}
	}
}