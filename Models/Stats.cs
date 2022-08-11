using System;
using System.Collections.Generic;
using DnDCharacterCreator.Options;

namespace DnDCharacterCreator.Models
{
    public class Stats
    {
        

        public int Level { get; set; }
        public int Proficiency
        {
            get { return Tables.LevelProf[Level]; }
            protected set { }
        }
        
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constiution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public bool StrengthSaveProf { get; set; }
        public bool DexteritySaveProf { get; set; }
        public bool ConstitutionSaveProf { get; set; }
        public bool IntelligenceSaveProf { get; set; }
        public bool WisdomSaveProf { get; set; }
        public bool CharismaSaveProf { get; set; }

        public int StrengthMod
        {
            get { return Tables.ScoreMod[Strength]; }
            set { }
        }
        public int DexterityMod
        {
            get { return Tables.ScoreMod[Dexterity]; }
            set { }
        }
        public int ConstitutionMod
        {
            get { return Tables.ScoreMod[Constiution]; }
            set { }
        }
        public int IntelligenceMod
        {
            get { return Tables.ScoreMod[Intelligence]; }
            set { }
        }
        public int WisdomMod
        {
            get { return Tables.ScoreMod[Wisdom]; }
            set { }
        }
        public int CharismaMod
        {
            get { return Tables.ScoreMod[Charisma]; }
            set { }
        }


        public bool AthleticsProf { get; set; }
        public bool AcrobaticsProf { get; set; }
        public bool SleightOfHandProf { get; set; }
        public bool StealthProf { get; set; }
        public bool ArcanaProf { get; set; }
        public bool HistoryProf { get; set; }
        public bool InvestigationProf { get; set; }
        public bool NatureProf { get; set; }
        public bool ReligionProf { get; set; }
        public bool AnimalHandlingProf { get; set; }
        public bool InsightProf { get; set; }
        public bool MedicineProf { get; set; }
        public bool PerceptionProf { get; set; }
        public bool SurvivalProf { get; set; }
        public bool DeceptionProf { get; set; }
        public bool IntimidationProf { get; set; }
        public bool PerformanceProf { get; set; }
        public bool PersuasionProf { get; set; }


        public int Athletics
        {
            get { return ToModifier(Strength,AthleticsProf); }
            set {  }
        }
        public int Acrobatics
        {
            get { return ToModifier(Dexterity, AcrobaticsProf); }
            set { }
        }
        public int SleightOfHand
        {
            get { return ToModifier(Dexterity, SleightOfHandProf); }
            set { }
        }
        public int Stealth
        {
            get { return ToModifier(Dexterity, StealthProf); }
            set { }
        }
        public int Arcana
        {
            get { return ToModifier(Intelligence, ArcanaProf); }
            set { }
        }
        public int History
        {
            get { return ToModifier(Intelligence, HistoryProf); }
            set { }
        }
        public int Investigation
        {
            get { return ToModifier(Intelligence, InvestigationProf); }
            set { }
        }
        public int Nature
        {
            get { return ToModifier(Intelligence, NatureProf); }
            set { }
        }
        public int Religion
        {
            get { return ToModifier(Intelligence, ReligionProf); }
            set { }
        }
        public int AnimalHandling
        {
            get { return ToModifier(Wisdom, AnimalHandlingProf); }
            set { }
        }
        public int Insight
        {
            get { return ToModifier(Wisdom, InsightProf); }
            set { }
        }
        public int Medicine
        {
            get { return ToModifier(Wisdom, MedicineProf); }
            set { }
        }
        public int Perception
        {
            get { return ToModifier(Wisdom, PerceptionProf); }
            set { }
        }
        public int Survival
        {
            get { return ToModifier(Wisdom, SurvivalProf); }
            set { }
        }
        public int Deception
        {
            get { return ToModifier(Charisma, DeceptionProf); }
            set { }
        }
        public int Intimidation
        {
            get { return ToModifier(Charisma, IntimidationProf); }
            set { }
        }
        public int Performance
        {
            get { return ToModifier(Charisma, PerformanceProf); }
            set { }
        }
        public int Persuasion
        {
            get { return ToModifier(Charisma, PersuasionProf); }
            set { }
        }



        public int ToModifier(int rawScore, bool prof) => prof ? Tables.ScoreMod[rawScore] + Proficiency : Tables.ScoreMod[rawScore];
    }
}
