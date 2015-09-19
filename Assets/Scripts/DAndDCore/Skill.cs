namespace DAndDCore 
{
	public class Skill
	{
		private AbilityName ability;
		private int rank;
		private bool isClass;
		private bool armorPenalty;
		private bool untrained;
		
		public Skill (AbilityName ability, int rank, bool isClass, bool armorPenalty, bool untrained)
		{
			this.ability = ability;
			this.rank = rank;
			this.isClass = isClass;
			this.armorPenalty = armorPenalty;
			this.untrained = untrained;
		}

		public AbilityName Ability 
		{
			get { return ability; }
			set { ability = value; }
		}

		public int Rank 
		{
			get { return rank; }
			set { rank = value; }
		}

		public bool IsClass 
		{
			get { return isClass; }
			set { isClass = value; }
		}

		public bool ApplyArmorPenalty
		{
			get { return armorPenalty; }
			set { armorPenalty = value;}
		}

		public bool CanUsedUntrained
		{
			get { return untrained; }
			set { untrained = value; }
		}
	}
}