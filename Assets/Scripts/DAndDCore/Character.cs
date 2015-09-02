namespace DAndDCore 
{
	public class Character
	{
		public Ability abilities { get; private set; }
		public Skills skills { get; private set; }
		public Alignment alignment { get; private set; }
		public int level { get; private set; }
		public int experience { get; private set; }
		public BaseRace race { get; private set; }
		
		public int GetProficiencyBonus() 
		{
			int result = 2;
			int t = level / 4;
			if (t > 1) {
				result += t - 1;
			}
			if (t >= 1 && level % 4 != 0) {
				result++;
			}
			return result;
		}
		
		public Character (int level)
		{
			this.level = level;
		}
	}
}