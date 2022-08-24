using DnDCharacterCreator.Classes;
using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Options;
using DnDCharacterCreator.Races;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Models
{
    public class Character
    {
        public Character()
        {
            Level = 1;
            Stats = new int[6];
            StatSaveProf = new bool[6];
            SkillProficincy = new bool[Utilities.GetEnumLength<Skill>()];
            Resistances = new bool[Utilities.GetEnumLength<DamageType>()];
            ToolProficiency = new bool[Utilities.GetEnumLength<ArtisanTool>()];
            ArmorProficiency = new bool[Utilities.GetEnumLength<Armor>()];
            WeaponProficiency = new bool[Utilities.GetEnumLength<WeaponModel>()];
            InstrumentProficiency = new bool[Utilities.GetEnumLength<Instrument>()];
            StandardLanguages = new bool[Utilities.GetEnumLength<StandardLanguage>()];
            ExoticLanguages = new bool[Utilities.GetEnumLength<ExoticLanguage>()];
            Abilities = new bool[Utilities.GetEnumLength<Ability>()];
            Race = GetRandomRace();
            Class = GetRandomClass();
            Name = Names.Generate(this.Race);
            Backstories bs = new Backstories(this);
            Backstory = bs.Generate();
            Race.Build(this);
            Class.LevelOne(this);
        }
        public Character(IClass _class, IRace race)
        {
            Level = 1;
            Stats = new int[6];
            StatSaveProf = new bool[6];
            SkillProficincy = new bool[Utilities.GetEnumLength<Skill>()];
            Resistances = new bool[Utilities.GetEnumLength<DamageType>()];
            ToolProficiency = new bool[Utilities.GetEnumLength<ArtisanTool>()];
            ArmorProficiency = new bool[Utilities.GetEnumLength<Armor>()];
            WeaponProficiency = new bool[Utilities.GetEnumLength<WeaponModel>()];
            InstrumentProficiency = new bool[Utilities.GetEnumLength<Instrument>()];
            StandardLanguages = new bool[Utilities.GetEnumLength<StandardLanguage>()];
            ExoticLanguages = new bool[Utilities.GetEnumLength<ExoticLanguage>()];
            Abilities = new bool[Utilities.GetEnumLength<Ability>()];
            Race = race;
            Class = _class;
            Personality = new Personality();
            Name = Names.Generate(this.Race);
            Backstories bs = new Backstories(this);
            Backstory = bs.Generate();
            Race.Build(this);
            Class.LevelOne(this);
        }
        public IRace Race { get; private set; }
        public dynamic SubRace { get; internal set; }
        public IClass Class { get; private set; }
        public dynamic SubClass { get; internal set; }
        public string Name { get; private set; }
        public Personality Personality { get; private set; }
        public int HitDie { get; set; }
        public int Level { get; set; }
        public int Proficiency
        {
            get { return Tables.LevelProf[Level]; }
            protected set { }
        }
        public WeaponModel WeaponEquiped { get; set; }


        public string Backstory { get;  private set; }
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

        public int StrengthSave
        {
            get { return IsProficient(Stat.Strength) ? StrengthMod + Proficiency : StrengthMod; }
            set { }
        }
        public int DexteritySave
        {
            get { return IsProficient(Stat.Dexterity) ? DexterityMod + Proficiency : DexterityMod; }
            set { }
        }
        public int ConstitutionSave
        {
            get { return IsProficient(Stat.Constitution) ? ConstitutionMod + Proficiency : ConstitutionMod; }
            set { }
        }
        public int WisdomSave
        {
            get { return IsProficient(Stat.Wisdom) ? WisdomMod + Proficiency : WisdomMod; }
            set { }
        }
        public int IntelligenceSave
        {
            get { return IsProficient(Stat.Intelligence) ? IntelligenceMod + Proficiency : IntelligenceMod; }
            set { }
        }
        public int CharismaSave
        {
            get { return IsProficient(Stat.Charisma) ? CharismaMod + Proficiency : CharismaMod; }
            set { }
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
        public bool IsProficient(Options.Weapon weapon) => WeaponProficiency[(int)weapon];
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
                WeaponProficiency[(int)weapon] = true;
                return true;
            }
            return false;
        }
        public bool AddProficiency(List<Weapon> weapons)
        {
            foreach (WeaponModel weapon in weapons)
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
        

        internal bool AddRandomProf(List<Skill> list)
        {
            int tries = 0;
            Skill skill = RNG.ReturnRandom(list);
            while (IsProficient(skill) && tries < 50)
            {
                skill = RNG.ReturnRandom(list);
                tries++;
            }
            if (tries >= 49) return false;
            AddProficiency(skill);
            return true;
        }
        internal bool AddRandomProf(List<StandardLanguage> list)
        {
            int tries = 0;
            StandardLanguage language = RNG.ReturnRandom(list);
            while (IsProficient(language) && tries < 50)
            {
                language = RNG.ReturnRandom(list);
                tries++;
            }
            if (tries >= 49) return false;
            AddProficiency(language);
            return true;
        }
        internal bool AddRandomProf(List<ExoticLanguage> list)
        {
            int tries = 0;
            ExoticLanguage language = RNG.ReturnRandom(list);
            while (IsProficient(language) && tries < 50)
            {
                language = RNG.ReturnRandom(list);
                tries++;
            }
            if (tries >= 49) return false;
            AddProficiency(language);
            return true;
        }
        internal bool AddRandomProf(List<Instrument> list)
        {
            int tries = 0;
            Instrument instrument = RNG.ReturnRandom(list);
            while (IsProficient(instrument) && tries < 50)
            {
                instrument = RNG.ReturnRandom(list);
                tries++;
            }
            if (tries >= 49) return false;
            AddProficiency(instrument);
            return true;
        }
        internal bool AddRandomProf(List<ArtisanTool> list)
        {
            int tries = 0;
            ArtisanTool tool = RNG.ReturnRandom(list);
            while (IsProficient(tool) && tries < 50)
            {
                tool = RNG.ReturnRandom(list);
                tries++;
            }
            if (tries >= 49) return false;
            AddProficiency(tool);
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Race: {Race}");
            sb.AppendLine($"Class: {Class}");
            sb.AppendLine($"Level: {Level}");
            sb.AppendLine($"Hit Die: {HitDie}");
            sb.AppendLine($"Health: {MaxHealth}");
            sb.AppendLine($"Proficiency: {Proficiency}\n");

            sb.AppendLine($"STR: {Stats[(int)Stat.Strength]}");
            sb.AppendLine($"DEX: {Stats[(int)Stat.Dexterity]}");
            sb.AppendLine($"CON: {Stats[(int)Stat.Constitution]}");
            sb.AppendLine($"WIS: {Stats[(int)Stat.Wisdom]}");
            sb.AppendLine($"INT: {Stats[(int)Stat.Intelligence]}");
            sb.AppendLine($"CHA: {Stats[(int)Stat.Charisma]}\n");

            sb.AppendLine($"Saving Throws: STR({ProfStar(IsProficient(Stat.Strength))}{StrengthSave})");
            sb.AppendLine($"Saving Throws: DEX({ProfStar(IsProficient(Stat.Dexterity))}{DexteritySave})");
            sb.AppendLine($"Saving Throws: CON({ProfStar(IsProficient(Stat.Constitution))}{ConstitutionSave})");
            sb.AppendLine($"Saving Throws: WIS({ProfStar(IsProficient(Stat.Wisdom))}{WisdomSave})");
            sb.AppendLine($"Saving Throws: INT({ProfStar(IsProficient(Stat.Intelligence))}{IntelligenceSave})");
            sb.AppendLine($"Saving Throws: CHA({ProfStar(IsProficient(Stat.Charisma))}{CharismaSave})\n");

            sb.AppendLine($"Athletics({ProfStar(IsProficient(Skill.Athletics))}{Athletics})");
            sb.AppendLine($"Acrobatics({ProfStar(IsProficient(Skill.Acrobatics))}{Acrobatics})");
            sb.AppendLine($"Sleight Of Hand({ProfStar(IsProficient(Skill.SleightOfHand))}{SleightOfHand})");
            sb.AppendLine($"Stealth({ProfStar(IsProficient(Skill.Stealth))}{Stealth})");
            sb.AppendLine($"Arcana({ProfStar(IsProficient(Skill.Arcana))}{Arcana})");
            sb.AppendLine($"History({ProfStar(IsProficient(Skill.History))}{History})");
            sb.AppendLine($"Investigation({ProfStar(IsProficient(Skill.Investigation))}{Investigation})");
            sb.AppendLine($"Nature({ProfStar(IsProficient(Skill.Nature))}{Nature})");
            sb.AppendLine($"Athletics({ProfStar(IsProficient(Skill.Athletics))}{Athletics})");
            sb.AppendLine($"Religion({ProfStar(IsProficient(Skill.Religion))}{Religion})");
            sb.AppendLine($"Animal Handling({ProfStar(IsProficient(Skill.AnimalHandling))}{AnimalHandling})");
            sb.AppendLine($"Insight({ProfStar(IsProficient(Skill.Insight))}{Insight})");
            sb.AppendLine($"Medicine({ProfStar(IsProficient(Skill.Medicine))}{Medicine})");
            sb.AppendLine($"Perception({ProfStar(IsProficient(Skill.Perception))}{Perception})");
            sb.AppendLine($"Survival({ProfStar(IsProficient(Skill.Survival))}{Survival})");
            sb.AppendLine($"Deception({ProfStar(IsProficient(Skill.Deception))}{Deception})");
            sb.AppendLine($"Intimidation({ProfStar(IsProficient(Skill.Intimidation))}{Intimidation})");
            sb.AppendLine($"Performance({ProfStar(IsProficient(Skill.Performance))}{Performance})");
            sb.AppendLine($"Persuasion({ProfStar(IsProficient(Skill.Persuasion))}{Persuasion})");

            return sb.ToString();
        }

        private string ProfStar(bool prof)
        {
            return prof ? "*" : " ";
        }
        private IClass GetRandomClass()
        {
            switch (RNG.ReturnRandom<Class>())
            {
                case Options.Class.Barbarian:
                    return new Barbarian();
                case Options.Class.Bard:
                    return new Bard();
                case Options.Class.Cleric:
                    return new Cleric();
                case Options.Class.Druid:
                    return new Druid();
                case Options.Class.Fighter:
                    return new Fighter();
                case Options.Class.Monk:
                    return new Monk();
                case Options.Class.Paladin:
                    return new Paladin();
                case Options.Class.Ranger:
                    return new Ranger();
                case Options.Class.Rouge:
                    return new Rouge();
                case Options.Class.Sorcerer:
                    return new Sorcerer();
                case Options.Class.Warlock:
                    return new Warlock();
                case Options.Class.Wizard:
                    return new Wizard();
                default:
                    throw new NotImplementedException();
            }
        }
        private IRace GetRandomRace()
        {
            switch (RNG.ReturnRandom<Race>())
            {
                case Options.Race.Dragonborn:
                    return new Dragonborn();
                case Options.Race.Dwarf:
                    return new Dwarf();
                case Options.Race.Elf:
                    return new Elf();
                case Options.Race.Gnome:
                    return new Gnome();
                case Options.Race.HalfElf:
                    return new HalfElf();
                case Options.Race.Halfling:
                    return new Halfling();
                case Options.Race.HalfOrc:
                    return new HalfOrc();
                case Options.Race.Human:
                    return new Human();
                case Options.Race.Tiefling:
                    return new Tiefling();
                default:
                    throw new Exception("Not a valid race for inputted character");
            }
        }
    }
}
