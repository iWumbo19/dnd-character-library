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
            Stats = new int[6];
            StatSaveProf = new bool[6];
            SkillProficincy = new bool[Utilities.GetEnumLength<Skill>()];
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
            CharacterEditor ce = new CharacterEditor(this);
            ce.Race.Build(this);
            ce.Class.LevelOne(this);
        }
        public Race Race { get; private set; }
        public dynamic SubRace { get; internal set; }
        public Class Class { get; private set; }
        public dynamic SubClass { get; internal set; }
        public string Name { get; private set; }
        public int HitDie { get; set; }
        public int Level { get; set; }
        public int Proficiency
        {
            get { return Tables.LevelProf[Level]; }
            protected set { }
        }


        public string Background { get;  private set; }
        public int[] Stats { get; internal set; }
        internal bool[] StatSaveProf { get; set; }
        internal bool[] SkillProficincy { get; set; }
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

        public int StrengthMod
        {
            get { return Tables.ScoreMod[Stats[(int)Stat.Strength]]; }
            private set { }
        }
        public int DexterityMod
        {
            get { return Tables.ScoreMod[Stats[(int)Stat.Dexterity]]; }
            private set { }
        }
        public int ConstitutionMod
        {
            get { return Tables.ScoreMod[Stats[(int)Stat.Constitution]]; }
            private set { }
        }
        public int IntelligenceMod
        {
            get { return Tables.ScoreMod[Stats[(int)Stat.Intelligence]]; }
            private set { }
        }
        public int WisdomMod
        {
            get { return Tables.ScoreMod[Stats[(int)Stat.Wisdom]]; }
            private set { }
        }
        public int CharismaMod
        {
            get { return Tables.ScoreMod[Stats[(int)Stat.Charisma]]; }
            private set { }
        }

        public int Athletics
        {
            get { return ToModifier(Stats[(int)Stat.Strength], SkillProficincy[(int)Skill.Athletics]); }
            set { }
        }
        public int Acrobatics
        {
            get { return ToModifier(Stats[(int)Stat.Dexterity], SkillProficincy[(int)Skill.Acrobatics]); }
            set { }
        }
        public int SleightOfHand
        {
            get { return ToModifier(Stats[(int)Stat.Dexterity], SkillProficincy[(int)Skill.SleightOfHand]); }
            set { }
        }
        public int Stealth
        {
            get { return ToModifier(Stats[(int)Stat.Dexterity], SkillProficincy[(int)Skill.Stealth]); }
            set { }
        }
        public int Arcana
        {
            get { return ToModifier(Stats[(int)Stat.Intelligence], SkillProficincy[(int)Skill.Arcana]); }
            set { }
        }
        public int History
        {
            get { return ToModifier(Stats[(int)Stat.Intelligence], SkillProficincy[(int)Skill.History]); }
            set { }
        }
        public int Investigation
        {
            get { return ToModifier(Stats[(int)Stat.Intelligence], SkillProficincy[(int)Skill.Investigation]); }
            set { }
        }
        public int Nature
        {
            get { return ToModifier(Stats[(int)Stat.Intelligence], SkillProficincy[(int)Skill.Nature]); }
            set { }
        }
        public int Religion
        {
            get { return ToModifier(Stats[(int)Stat.Intelligence], SkillProficincy[(int)Skill.Religion]); }
            set { }
        }
        public int AnimalHandling
        {
            get { return ToModifier(Stats[(int)Stat.Wisdom], SkillProficincy[(int)Skill.AnimalHandling]); }
            set { }
        }
        public int Insight
        {
            get { return ToModifier(Stats[(int)Stat.Wisdom], SkillProficincy[(int)Skill.Insight]); }
            set { }
        }
        public int Medicine
        {
            get { return ToModifier(Stats[(int)Stat.Wisdom], SkillProficincy[(int)Skill.Medicine]); }
            set { }
        }
        public int Perception
        {
            get { return ToModifier(Stats[(int)Stat.Wisdom], SkillProficincy[(int)Skill.Perception]); }
            set { }
        }
        public int Survival
        {
            get { return ToModifier(Stats[(int)Stat.Wisdom], SkillProficincy[(int)Skill.Survival]); }
            set { }
        }
        public int Deception
        {
            get { return ToModifier(Stats[(int)Stat.Charisma], SkillProficincy[(int)Skill.Deception]); }
            set { }
        }
        public int Intimidation
        {
            get { return ToModifier(Stats[(int)Stat.Charisma], SkillProficincy[(int)Skill.Intimidation]); }
            set { }
        }
        public int Performance
        {
            get { return ToModifier(Stats[(int)Stat.Charisma], SkillProficincy[(int)Skill.Performance]); }
            set { }
        }
        public int Persuasion
        {
            get { return ToModifier(Stats[(int)Stat.Charisma], SkillProficincy[(int)Skill.Persuasion]); }
            set { }
        }

        private int ToModifier(int rawScore, bool prof) => prof ? Tables.ScoreMod[rawScore] + Proficiency : Tables.ScoreMod[rawScore];

        public bool IsResistant(DamageType type) => Resistances[(int)type];
        public bool IsProficient(ArtisanTool tool) => ToolProficiency[(int)tool];
        public bool IsProficient(Instrument instrument) => InstrumentProficiency[(int)instrument];
        public bool IsProficient(StandardLanguage standard) => StandardLanguages[(int)standard];
        public bool IsProficient(ExoticLanguage exotic) => ExoticLanguages[(int)exotic];
        public bool IsProficient(Weapon weapon) => WeaponProficiency[(int)weapon];
        public bool IsProficient(Armor armor) => ArmorProficiency[(int)armor];
        public bool IsProficient(Skill skill) => SkillProficincy[(int)skill];
        public bool IsProficient(Stat stat) => StatSaveProf[(int)stat];
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
        public bool AddProficiency(Stat stat) => StatSaveProf[(int)stat] = true;
        public bool AddProficiency(Skill skill)
        {
            if (!IsProficient(skill))
            {
                SkillProficincy[(int)skill] = true;
                return true;
            }
            return false;
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
        public void IncreaseStat(Stat stat, int amount) => Stats[(int)stat] += amount;
        

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
        internal bool AddRandomProf(Skill skill)
        {
            int tries = 0;
            int index = RNG.Roll(0, Utilities.GetEnumLength<Skill>());
            while (SkillProficincy[index] && tries++ < 50)
            {
                index = RNG.Roll(0, Utilities.GetEnumLength<Skill>());
            }
            if (tries >= 50) return false;
            SkillProficincy[index] = true;
            return true;
        }
        internal bool AddRandomProf(List<Skill> list)
        {
            int tries = 0;
            Skill skill = RNG.ReturnRandom(list);
            while (!IsProficient(skill) && tries++ < 50)
            {
                skill = RNG.ReturnRandom(list);
            }
            if (tries > 50) return false;
            AddProficiency(skill);
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
