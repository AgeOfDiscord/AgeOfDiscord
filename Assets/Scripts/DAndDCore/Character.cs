namespace DAndDCore 
{
	public class Character
	{
		private Ability abilities;
		private Skills skills;
		private Alignment alignment;
		private int level;
		private int experience;
		private BaseRace race;
		
		private int GetProficiencyBonus() 
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
		
		public Character ()
		{
		}
	}
}