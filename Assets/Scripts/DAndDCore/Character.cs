namespace DAndDCore 
{
	public class Character
	{
		public Abilities abilities { get; private set; }
		public Skills skills { get; private set; }
		public Alignment alignment { get; private set; }
		public int level { get; private set; }
		public int experience { get; private set; }
		public BaseRace race { get; private set; }
		
		public Character (int level)
		{
			this.level = level;
		}
	}
}