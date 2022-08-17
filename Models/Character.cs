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
        public int HitDie { get; set; }

        

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


        public bool AddResistance(DamageType type)
        {
            if (!IsResistant(type))
            {
                Resistances[(int)type] = true;
                return true;
            }
            return false;
        }
        public bool AddProficiency(ArtisanTool tool)
        {
            if (!IsProficient(tool))
            {
                ToolProficiency[(int)tool] = true;
                return true;
            }
            return false;
        }
        public bool AddProficiency(Instrument instrument)
        {
            if (!IsProficient(instrument))
            {
                InstrumentProficiency[(int)instrument] = true;
                return true;
            }
            return false;
        }
        public bool AddProficiency(StandardLanguage standard)
        {
            if (!IsProficient(standard))
            {
                StandardLanguages[(int)standard] = true;
                return true;
            }
            return false;
        }
        public bool AddProficiency(ExoticLanguage exotic)
        {
            if (!IsProficient(exotic))
            {
                ExoticLanguages[(int)exotic] = true;
                return true;
            }
            return false;
        }
        public bool AddProficiency(Weapon weapon)
        {
            if (!IsProficient(weapon))
            {
                ToolProficiency[(int)weapon] = true;
                return true;
            }
            return false;
        }
        public bool AddProficiency(List<Weapon> weapons)
        {
            foreach (Weapon weapon in weapons)
            {
                AddProficiency(weapon);
            }
            return true;
        }
        public bool AddProficiency(Armor armor)
        {
            if (!IsProficient(armor))
            {
                ArmorProficiency[(int)armor] = true;
                return true;
            }
            return false;
        }
        public bool AddProficiency(Stat stat)
        {
            switch (stat)
            {
                case Stat.Strength:
                    if (!Stats.StrengthSaveProf)
                    {
                        Stats.StrengthSaveProf = true;
                        return true;
                    }
                    return false;
                case Stat.Dexterity:
                    if (!Stats.DexteritySaveProf)
                    {
                        Stats.DexteritySaveProf = true;
                        return true;
                    }
                    return false;
                case Stat.Constitution:
                    if (!Stats.ConstitutionSaveProf)
                    {
                        Stats.ConstitutionSaveProf = true;
                        return true;
                    }
                    return false;
                case Stat.Intelligence:
                    if (!Stats.IntelligenceSaveProf)
                    {
                        Stats.IntelligenceSaveProf = true;
                        return true;
                    }
                    return false;
                case Stat.Wisdom:
                    if (!Stats.WisdomSaveProf)
                    {
                        Stats.WisdomSaveProf = true;
                        return true;
                    }
                    return false;
                case Stat.Charisma:
                    if (!Stats.CharismaSaveProf)
                    {
                        Stats.CharismaSaveProf = true;
                        return true;
                    }
                    return false;
                default:
                    throw new Exception("Failed to add save proficiency");
            }
        }
        public bool AddProficiency(Skill skill)
        {
            switch (skill)
            {
                case Skill.Athletics:
                    if (!Stats.AthleticsProf)
                    {
                        Stats.AthleticsProf = true;
                        return true;
                    }
                    return false;
                case Skill.Acrobatics:
                    if (!Stats.AcrobaticsProf)
                    {
                        Stats.AcrobaticsProf = true;
                        return true;
                    }
                    return false;
                case Skill.SleightOfHand:
                    if (!Stats.SleightOfHandProf)
                    {
                        Stats.SleightOfHandProf = true;
                        return true;
                    }
                    return false;
                case Skill.Stealth:
                    if (!Stats.StealthProf)
                    {
                        Stats.StealthProf = true;
                        return true;
                    }
                    return false;
                case Skill.Arcana:
                    if (!Stats.ArcanaProf)
                    {
                        Stats.ArcanaProf = true;
                        return true;
                    }
                    return false;
                case Skill.History:
                    if (!Stats.HistoryProf)
                    {
                        Stats.HistoryProf = true;
                        return true;
                    }
                    return false;
                case Skill.Investigation:
                    if (!Stats.InvestigationProf)
                    {
                        Stats.InvestigationProf = true;
                        return true;
                    }
                    return false;
                case Skill.Nature:
                    if (!Stats.NatureProf)
                    {
                        Stats.NatureProf = true;
                        return true;
                    }
                    return false;
                case Skill.Religion:
                    if (!Stats.ReligionProf)
                    {
                        Stats.ReligionProf = true;
                        return true;
                    }
                    return false;
                case Skill.AnimalHandling:
                    if (!Stats.AnimalHandlingProf)
                    {
                        Stats.AnimalHandlingProf = true;
                        return true;
                    }
                    return false;
                case Skill.Insight:
                    if (!Stats.InsightProf)
                    {
                        Stats.InsightProf = true;
                        return true;
                    }
                    return false;
                case Skill.Medicine:
                    if (!Stats.MedicineProf)
                    {
                        Stats.MedicineProf = true;
                        return true;
                    }
                    return false;
                case Skill.Perception:
                    if (!Stats.PerceptionProf)
                    {
                        Stats.PerceptionProf = true;
                        return true;
                    }
                    return false;
                case Skill.Survival:
                    if (!Stats.SurvivalProf)
                    {
                        Stats.SurvivalProf = true;
                        return true;
                    }
                    return false;
                case Skill.Deception:
                    if (!Stats.DeceptionProf)
                    {
                        Stats.DeceptionProf = true;
                        return true;
                    }
                    return false;
                case Skill.Intimidation:
                    if (!Stats.IntimidationProf)
                    {
                        Stats.IntimidationProf = true;
                        return true;
                    }
                    return false;
                case Skill.Performance:
                    if (!Stats.PerformanceProf)
                    {
                        Stats.PerformanceProf = true;
                        return true;
                    }
                    return false;
                case Skill.Persuasion:
                    if (!Stats.PersuasionProf)
                    {
                        Stats.PersuasionProf = true;
                        return true;
                    }
                    return false;
                default:
                    throw new Exception("Failed to make proficient in skill");
            }
        }
        public bool AddAbility(Ability ability)
        {
            if (!HasAbility(ability))
            {
                Abilities[(int)ability] = true;
                return true;
            }
            return false;
        }
        

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
