using DnDCharacterCreator.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    class LibraryOLD
    {
        private readonly Random rnd = new Random(Program.Seeder());
        //Stat Number Translators
        
        public Dictionary<Class, int> classHitDie = new Dictionary<Class, int>()
        {
            {Class.Sorcerer, 6 },
            {Class.Wizard,6 },
            {Class.Bard,8 },
            {Class.Cleric,8 },
            {Class.Druid,8 },
            {Class.Monk,8 },
            {Class.Rouge,8 },
            {Class.Warlock,8 },
            {Class.Fighter,10 },
            {Class.Paladin,10 },
            {Class.Ranger,10 },
            {Class.Barbarian,12 },
        };
        public int SkillModMath(int rawScore, bool prof, int profBonus)
        {
            int returnScore = scoreMod[rawScore];
            if (prof == true)
            {
                returnScore += profBonus;
            }
            return returnScore;
        }
        
        //Lists of Specific Choices
        public List<string> abilityCategories = new List<string>()
        {
            {"Strength" },
            {"Dexterity" },
            {"Constitution" },
            {"Wisdom" },
            {"Inteligence" },
            {"Charisma" }
        };
        public List<string> skillCategories = new List<string>()
        {
            {"Acrobatics" },
            {"Animal Handling" },
            {"Arcana" },
            {"Athletics" },
            {"Deception" },
            {"History" },
            {"Insight" },
            {"Intimidation" },
            {"Invetigation" },
            {"Medicine" },
            {"Nature" },
            {"Perception" },
            {"Performance" },
            {"Persuasion" },
            {"Religon" },
            {"Slieght Of Hand" },
            {"Stealth" },
            {"Survival" }
        };
        public List<string> musicalInstruments = new List<string>()
        {
            {"Bagpipes" },
            {"Drum" },
            {"Dulcimer" },
            {"Flute" },
            {"Lute" },
            {"Lyre" },
            {"Horn" },
            {"Pan Flute" },
            {"Shawm" },
            {"Viol" }
        };
        public List<string> artisansTools = new List<string>()
        {
            {"Alchemist's supplies" },
            {"Brewer's supplies" },
            {"Calligrapher's supplies" },
            {"Carpenter's tools" },
            {"Cartographer's tools" },
            {"Cobbler's tools" },
            {"Cook's utensils" },
            {"Glassblower's tools" },
            {"Jeweler's tools" },
            {"Leatherworker's tools" },
            {"Mason's tools" },
            {"Painter's supplies" },
            {"Potter's tools" },
            {"Smith's tools" },
            {"Tinker's tools" },
            {"Weaver's tools" },
            {"Woodcarver's tools" }
        };

        //Basic PHB Races/Classes
        public List<string> raceList = new List<string>()
        {
            {"Dwarf" },
            {"Elf" },
            {"Halfling" },
            {"Human" },
            {"Dragonborn" },
            {"Gnome" },
            {"Half-elf" },
            {"Half-orc" },
            {"Tiefling" }
        };
        public List<string> classList = new List<string>()
        {
            {"Barbarian" },
            {"Bard" },
            {"Cleric" },
            {"Druid" },
            {"Fighter" },
            {"Monk" },
            {"Paladin" },
            {"Ranger" },
            {"Rouge" },
            {"Sorcerer" },
            {"Warlock" },
            {"Wizard" }
        };

        //Lists containing PHB Subraces
        public List<string> halflingSubRace = new List<string>()
        {
            {"Lightfoot" },
            {"Stout" }
        };
        public List<string> elfSubRace = new List<string>()
        {
            {"High Elf" },
            {"Wood Elf" },
            {"Dark Elf (Drow)" }
        };
        public List<string> gnomeSubRace = new List<string>()
        {
            {"Forest Gnome" },
            {"Rock Gnome" }
        };

        //Lists containing PHB languages
        public List<string> standardLanguages = new List<string>()
        {
            {"Common" },
            {"Dwarvish" },
            {"Elvish" },
            {"Giant" },
            {"Gnomish" },
            {"Goblin" },
            {"Halfling" },
            {"Orc" }
        };
        public List<string> exoticLanguages = new List<string>()
        {
            {"Abyssal" },
            {"Celestial" },
            {"Draconic" },
            {"Deep Speech" },
            {"Infernal" },
            {"Primordial" },
            {"Sylvan" },
            {"Undercommon" }
        };
        public List<string> allLanguages = new List<string>()
        {
            {"Common" },
            {"Dwarvish" },
            {"Elvish" },
            {"Giant" },
            {"Gnomish" },
            {"Goblin" },
            {"Halfling" },
            {"Orc" },
            {"Abyssal" },
            {"Celestial" },
            {"Draconic" },
            {"Deep Speech" },
            {"Infernal" },
            {"Primordial" },
            {"Sylvan" },
            {"Undercommon" }
        };

        //Spell Compendium
        public List<string> spellWizardCantrips = new List<string>
        {
            {"Acid Splash" },
            {"Chill Touch" },
            {"Dancing Lights" },
            {"Fire Bolt" },
            {"Light" },
            {"Mage Hand" },
            {"Mending" },
            {"Message" },
            {"Minor Illusion" },
            {"Poison Spray" },
            {"Prestidigitation" },
            {"Ray of Frost" },
            {"Shocking Grasp" },
            {"True Strike" }
        };



        ////Rolls on tables to generate random choosings of traits
        //Returns Languages
        public string RandomAllLanguage()
        {
            int languageRoll = rnd.Next(allLanguages.Count);
            return allLanguages[languageRoll];
        }

        //Returns Subraces
        public string RandomElfSubrace()
        {
            return elfSubRace[rnd.Next(elfSubRace.Count)];
        }
        public string RandomHalflingSubRace()
        {
            return halflingSubRace[rnd.Next(halflingSubRace.Count)];
        }
        public string RandomGnomeSubrace()
        {
            return gnomeSubRace[rnd.Next(gnomeSubRace.Count)];
        }

        //Returns Spells
        public string RandomWizardCantrip()
        {
            return spellWizardCantrips[rnd.Next(spellWizardCantrips.Count)];
        }

        //Returns Random Things
        public string RandomAbilityCategory()
        {
            return abilityCategories[rnd.Next(abilityCategories.Count)];
        }
        public string RandomSkillCategory()
        {
            return skillCategories[rnd.Next(skillCategories.Count)];
        }

        //Returns Random Numbers
        public int RandomRoll(int low, int high) {return rnd.Next(low, high);}
        public int RandomRoll(int high) { return rnd.Next(high); }


    }
}
