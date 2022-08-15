using DnDCharacterCreator.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Models
{
    public class Character
    {
        public Character()
        {
            Resistances = new bool[Utilities.GetEnumLength<DamageType>()];
            ToolProficiency = new bool[Utilities.GetEnumLength<ArtisanTool>()];
            InstrumentProficiency = new bool[Utilities.GetEnumLength<Instrument>()];
            StandardLanguages = new bool[Utilities.GetEnumLength<StandardLanguage>()];
            ExoticLanguages = new bool[Utilities.GetEnumLength<ExoticLanguage>()];
            WeaponProficiency = new bool[Utilities.GetEnumLength<Weapon>()];
            ArmorProficiency = new bool[Utilities.GetEnumLength<Armor>()];
            Race = RNG.ReturnRandom<Race>();
            Class = RNG.ReturnRandom<Class>();
            Name = Names.Generate(this);
            Backstories bs = new Backstories(this);
            Background = bs.Generate();
            MaxHealth = Tables.classHitDie[Class] + Stats.ConstitutionMod;
        }
        public Race Race { get; private set; }
        public dynamic SubRace { get; internal set; }
        public Class Class { get; private set; }

        

        public string Name { get; private set; }

        

        public string Background { get;  private set; }
        public Stats Stats { get; internal set; }
        internal bool[] Resistances { get; set; }
        internal bool[] ToolProficiency { get; set; }
        internal bool[] ArmorProficiency { get; set; }
        internal bool[] WeaponProficiency { get; set; }
        internal bool[] InstrumentProficiency { get; set; }
        internal bool[] StandardLanguages { get; set; }
        internal bool[] ExoticLanguages { get; set; }
        internal bool[] Abilities { get; set; }
        public int MaxHealth { get; set; }
        public int Speed { get; set; }

        public bool IsResistant(DamageType type) => Resistances[(int)type];
        public bool IsProficient(ArtisanTool tool) => ToolProficiency[(int)tool];
        public bool IsProficient(Instrument instrument) => InstrumentProficiency[(int)instrument];
        public bool IsProficient(StandardLanguage standard) => StandardLanguages[(int)standard];
        public bool IsProficient(ExoticLanguage exotic) => ExoticLanguages[(int)exotic];
        public bool IsProficient(Weapon weapon) => WeaponProficiency[(int)weapon];
        public bool IsProficient(Armor armor) => ArmorProficiency[(int)armor];
        public bool HasAbility(Ability ability) => Abilities[(int)ability];


        public void AddResistance(DamageType type) => Resistances[(int)type] = true;
        public void AddProficiency(ArtisanTool tool) => ToolProficiency[(int)tool] = true;
        public void AddProficiency(Instrument instrument) => InstrumentProficiency[(int)instrument] = true;
        public void AddProficiency(StandardLanguage standard) => StandardLanguages[(int)standard] = true;
        public void AddProficiency(ExoticLanguage exotic) => ExoticLanguages[(int)exotic] = true;
        public void AddProficiency(Weapon weapon) => ToolProficiency[(int)weapon] = true;
        public void AddProficiency(Armor armor) => ArmorProficiency[(int)armor] = true;
        public void AddProficiency(Stat stat)
        {
            switch (stat)
            {
                case Stat.Strength:
                    Stats.StrengthSaveProf = true;
                    break;
                case Stat.Dexterity:
                    Stats.DexteritySaveProf = true;
                    break;
                case Stat.Constitution:
                    Stats.ConstitutionSaveProf = true;
                    break;
                case Stat.Intelligence:
                    Stats.IntelligenceSaveProf = true;
                    break;
                case Stat.Wisdom:
                    Stats.WisdomSaveProf = true;
                    break;
                case Stat.Charisma:
                    Stats.CharismaSaveProf = true;
                    break;
                default:
                    throw new Exception("Failed to add save proficiency");
            }
        }
        public void AddProficiency(Skill skill)
        {
            switch (skill)
            {
                case Skill.Athletics:
                    Stats.AthleticsProf = true;
                    break;
                case Skill.Acrobatics:
                    Stats.AcrobaticsProf = true;
                    break;
                case Skill.SleightOfHand:
                    Stats.SleightOfHandProf = true;
                    break;
                case Skill.Stealth:
                    Stats.StealthProf = true;
                    break;
                case Skill.Arcana:
                    Stats.ArcanaProf = true;
                    break;
                case Skill.History:
                    Stats.HistoryProf = true;
                    break;
                case Skill.Investigation:
                    Stats.InvestigationProf = true;
                    break;
                case Skill.Nature:
                    Stats.NatureProf = true;
                    break;
                case Skill.Religion:
                    Stats.ReligionProf = true;
                    break;
                case Skill.AnimalHandling:
                    Stats.AnimalHandlingProf = true;
                    break;
                case Skill.Insight:
                    Stats.InsightProf = true;
                    break;
                case Skill.Medicine:
                    Stats.MedicineProf = true;
                    break;
                case Skill.Perception:
                    Stats.PerceptionProf = true;
                    break;
                case Skill.Survival:
                    Stats.SurvivalProf = true;
                    break;
                case Skill.Deception:
                    Stats.DeceptionProf = true;
                    break;
                case Skill.Intimidation:
                    Stats.IntimidationProf = true;
                    break;
                case Skill.Performance:
                    Stats.PerformanceProf = true;
                    break;
                case Skill.Persuasion:
                    Stats.PersuasionProf = true;
                    break;
                default:
                    throw new Exception("Failed to make proficient in skill");
            }
        }
        public void AddAbility(Ability ability) => Abilities[(int)ability] = true;

        internal bool AddRandomProf(ArtisanTool tool)
        {
            int tries = 0;
            int index = RNG.Roll(0, Utilities.GetEnumLength<ArtisanTool>());
            while (ToolProficiency[index] && tries++ < 50)
            {
                index = RNG.Roll(0, Utilities.GetEnumLength<ArtisanTool>());
            }
            if (tries >= 50) return false;
            ToolProficiency[index] = true;
            return true;
        }
        internal bool AddRandomProf(Instrument instrument)
        {
            int tries = 0;
            int index = RNG.Roll(0, Utilities.GetEnumLength<Instrument>());
            while (InstrumentProficiency[index] && tries++ < 50)
            {
                index = RNG.Roll(0, Utilities.GetEnumLength<Instrument>());
            }
            if (tries >= 50) return false;
            InstrumentProficiency[index] = true;
            return true;
        }
        internal bool AddRandomProf(StandardLanguage language)
        {
            int tries = 0;
            int index = RNG.Roll(0, Utilities.GetEnumLength<StandardLanguage>());
            while (StandardLanguages[index] && tries++ < 50)
            {
                index = RNG.Roll(0, Utilities.GetEnumLength<StandardLanguage>());
            }
            if (tries >= 50) return false;
            StandardLanguages[index] = true;
            return true;
        }
        internal bool AddRandomProf(ExoticLanguage language)
        {
            int tries = 0;
            int index = RNG.Roll(0, Utilities.GetEnumLength<ExoticLanguage>());
            while (ExoticLanguages[index] && tries++ < 50)
            {
                index = RNG.Roll(0, Utilities.GetEnumLength<ExoticLanguage>());
            }
            if (tries >= 50) return false;
            ExoticLanguages[index] = true;
            return true;
        }
        internal bool AddRandomProf(Weapon weapon)
        {
            int tries = 0;
            int index = RNG.Roll(0, Utilities.GetEnumLength<Weapon>());
            while (WeaponProficiency[index] && tries++ < 50)
            {
                index = RNG.Roll(0, Utilities.GetEnumLength<Weapon>());
            }
            if (tries >= 50) return false;
            WeaponProficiency[index] = true;
            return true;
        }
        internal bool AddRandomProf(Armor armor)
        {
            int tries = 0;
            int index = RNG.Roll(0, Utilities.GetEnumLength<Armor>());
            while (ArmorProficiency[index] && tries++ < 50)
            {
                index = RNG.Roll(0, Utilities.GetEnumLength<Armor>());
            }
            if (tries >= 50) return false;
            ArmorProficiency[index] = true;
            return true;
        }
    }
}
