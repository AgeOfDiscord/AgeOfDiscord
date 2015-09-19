namespace DAndDCore
{
	public class ArcticDwarf : Dwarf
	{
		public ArcticDwarf (Gender gender, int age, float height, int weight)
			: base("Arctic", age, height, weight, gender)
		{
			traits.Add (TraitName.Xenophobic);
			
			traits.Add (TraitName.DefensiveTraining);
			traits.Add (TraitName.Stubborn);
			traits.Add (TraitName.Stability);
			
			traits.Add (TraitName.Greed);
			traits.Add (TraitName.Stonecunning);
			
			traits.Add (TraitName.SurfaceSurvivalist);
			
			traits.Add (TraitName.AncientEnmity);
		}
	}
}