namespace DAndDCore
{
	public class DeepDwarf : Dwarf
	{
		public DeepDwarf (Gender gender, int age, float height, int weight)
			: base("Deep", age, height, weight, gender)
		{
			traits.Add (TraitName.Xenophobic);
			
			traits.Add (TraitName.DeepWarrior);
			traits.Add (TraitName.MagicResistant);
			traits.Add (TraitName.Stability);
			
			traits.Add (TraitName.Craftsman);
			traits.Add (TraitName.Stonecunning);
			
			traits.Add (TraitName.Darkvision60);
			
			traits.Add (TraitName.AncientEnmity);
		}
	}
}