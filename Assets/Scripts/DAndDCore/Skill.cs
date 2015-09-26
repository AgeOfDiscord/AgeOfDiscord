namespace DAndDCore 
{
	public class Skill
	{
		private AbilityName ability;
		private int rank;
		private bool isClass;
		private bool armorPenalty;
		private bool untrained;
		private bool hidden;
		
		public Skill (AbilityName ability, bool armorPenalty, bool untrained, bool hidden = false, bool isClass = false, int rank = 0)
		{
			this.ability = ability;
			this.armorPenalty = armorPenalty;
			this.untrained = untrained;
			this.hidden = hidden;
			this.rank = rank;
			this.isClass = isClass;
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

		public bool CanBeUsedUntrained
		{
			get { return untrained; }
			set { untrained = value; }
		}

		public bool IsHidden 
		{
			get { return hidden; }
			set { hidden = value; }
		}
	}
}