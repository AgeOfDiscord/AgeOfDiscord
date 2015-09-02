using NUnit.Framework;
using System;

namespace DAndDCore
{
	[TestFixture()]
	public class CharacterTest
	{
		[Test()]
		public void FirstLevelProfBonusIsCorrect ()
		{
			Character character = new Character (1);
			Assert.AreEqual (2, character.GetProficiencyBonus ());
		}

		[Test()]
		public void FourthLevelProfBonusIsCorrect ()
		{
			Character character = new Character (4);
			Assert.AreEqual (2, character.GetProficiencyBonus ());
		}

		[Test()]
		public void FifthLevelProfBonusIsCorrect ()
		{
			Character character = new Character (5);
			Assert.AreEqual (3, character.GetProficiencyBonus ());
		}

		[Test()]
		public void NinthLevelProfBonusIsCorrect ()
		{
			Character character = new Character (9);
			Assert.AreEqual (4, character.GetProficiencyBonus ());
		}

		[Test()]
		public void TwentiethLevelProfBonusIsCorrect ()
		{
			Character character = new Character (20);
			Assert.AreEqual (6, character.GetProficiencyBonus ());
		}
	}
}

