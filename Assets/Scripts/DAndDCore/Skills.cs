using System.Collections.Generic;
namespace DAndDCore
{
	public class Skills 
	{
		private Dictionary<SkillName, Skill> values = new Dictionary<SkillName, Skill>();

		public Skills() {
			values.Add (SkillName.Acrobatics, new Skill (AbilityName.Dexterity, true, true));
			values.Add (SkillName.Appraise, new Skill (AbilityName.Intelligence, false, true)); 
			values.Add (SkillName.Bluff, new Skill(AbilityName.Charisma, false, true));
			values.Add (SkillName.Climb, new Skill (AbilityName.Strength, true, true));
			values.Add (SkillName.CraftAlchemy, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.CraftFletching, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.CraftLeatherworking, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.CraftMachinist, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.CraftMasonry, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.CraftSewing, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.CraftSmithing, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.CraftTraps, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.CraftWoodworking, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.Diplomacy, new Skill(AbilityName.Charisma, false, true));
			values.Add (SkillName.DisableDevice, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.Disguise, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.EscapeArtist, new Skill (AbilityName.Dexterity, true, true));
			values.Add (SkillName.Fly, new Skill (AbilityName.Dexterity, true, false));
			values.Add (SkillName.HandleAnimal, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.Heal, new Skill (AbilityName.Wisdom, false, true));
			values.Add (SkillName.Intimidate, new Skill(AbilityName.Charisma, false, true));
			values.Add (SkillName.KnowledgeAncient, new Skill (AbilityName.Intelligence, false, false, true));
			values.Add (SkillName.KnowledgeAstral, new Skill (AbilityName.Intelligence, false, false));
			values.Add (SkillName.KnowledgeDungeoneering, new Skill (AbilityName.Intelligence, false, false));
			values.Add (SkillName.KnowledgeEldritch, new Skill (AbilityName.Intelligence, false, false, true));
			values.Add (SkillName.KnowledgeEngineering, new Skill (AbilityName.Intelligence, false, false));
			values.Add (SkillName.KnowledgeGeography, new Skill (AbilityName.Intelligence, false, false));
			values.Add (SkillName.KnowledgeHistory, new Skill (AbilityName.Intelligence, false, false));
			values.Add (SkillName.KnowledgeMagic, new Skill (AbilityName.Intelligence, false, false));
			values.Add (SkillName.KnowledgeMartial, new Skill (AbilityName.Intelligence, false, false));
			values.Add (SkillName.KnowledgeNature, new Skill (AbilityName.Intelligence, false, false));
			values.Add (SkillName.KnowledgeNobility, new Skill (AbilityName.Intelligence, false, false));
			values.Add (SkillName.KnowledgePlanes, new Skill (AbilityName.Intelligence, false, false));
			values.Add (SkillName.KnowledgeReligion, new Skill (AbilityName.Intelligence, false, false));
			values.Add (SkillName.Linguistics, new Skill (AbilityName.Intelligence, false, false));
			values.Add (SkillName.Perception, new Skill(AbilityName.Wisdom, false, true));
			values.Add (SkillName.PerformAct, new Skill(AbilityName.Charisma, false, true));
			values.Add (SkillName.PerformComedy, new Skill(AbilityName.Charisma, false, true));
			values.Add (SkillName.PerformDance, new Skill(AbilityName.Dexterity, false, true));
			values.Add (SkillName.PerformKeybordInstruments, new Skill(AbilityName.Dexterity, false, true));
			values.Add (SkillName.PerformOratory, new Skill(AbilityName.Charisma, false, true));
			values.Add (SkillName.PerformPercussionInstruments, new Skill(AbilityName.Dexterity, false, true));
			values.Add (SkillName.PerformSing, new Skill(AbilityName.Charisma, false, true));
			values.Add (SkillName.PerformStringInstruments, new Skill(AbilityName.Dexterity, false, true));
			values.Add (SkillName.PerformWindInstruments, new Skill(AbilityName.Dexterity, false, true));
			values.Add (SkillName.ProfessionAirlor, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionArchitect, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionBaker, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionBarrister, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionBrewer, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionButcher, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionClerk, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionCook, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionCourtesan, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionDriver, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionEngineer, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionFarmer, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionFisherman, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionGambler, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionGardener, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionHerbalist, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionInnkeeper, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionLibrarian, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionMerchant, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionMidwife, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionMiller, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionMiner, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionPorter, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionSailor, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionScribe, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionShepherd, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionSoldier, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionStableMaster, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionTanner, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionTrapper, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.ProfessionWoodcutter, new Skill(AbilityName.Intelligence, false, true));
			values.Add (SkillName.Ride, new Skill(AbilityName.Dexterity, true, true));
			values.Add (SkillName.SenseMotive, new Skill (AbilityName.Wisdom, false, true));
			values.Add (SkillName.SleightOfHand, new Skill (AbilityName.Dexterity, true, true));
			values.Add (SkillName.Spellcraft, new Skill(AbilityName.Intelligence, false, false));
			values.Add (SkillName.Stealth, new Skill (AbilityName.Dexterity, true, true));
			values.Add (SkillName.SurvivalDesert, new Skill (AbilityName.Wisdom, false, true));
			values.Add (SkillName.SurvivalForest, new Skill (AbilityName.Wisdom, false, true));
			values.Add (SkillName.SurvivalJungle, new Skill (AbilityName.Wisdom, false, true));
			values.Add (SkillName.SurvivalMountains, new Skill (AbilityName.Wisdom, false, true));
			values.Add (SkillName.SurvivalRural, new Skill (AbilityName.Wisdom, false, true));
			values.Add (SkillName.SurvivalSwamp, new Skill (AbilityName.Wisdom, false, true));
			values.Add (SkillName.SurvivalTundra, new Skill (AbilityName.Wisdom, false, true));
			values.Add (SkillName.SurvivalWater, new Skill (AbilityName.Wisdom, false, true));
			values.Add (SkillName.Swim, new Skill (AbilityName.Strength, true, true));
			values.Add (SkillName.UseMagicDevice, new Skill (AbilityName.Intelligence, false, false));
		}

		public Skill this[SkillName skillName] 
		{
			get { return values[skillName]; }
			set { values [skillName] = value; }
		}
	}
}