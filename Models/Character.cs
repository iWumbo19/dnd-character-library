using DnDCharacterCreator.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Models
{
    internal class Character
    {
        public Character()
        {
            Resistances = new bool[Utilities.GetEnumLength<DamageType>()];
            ToolProficiency = new bool[Utilities.GetEnumLength<ArtisanTool>()];
            InstrumentProficiency = new bool[Utilities.GetEnumLength<Instrument>()];
            StandardLanguage = new bool[Utilities.GetEnumLength<StandardLanguage>()];
            ExoticLanguage = new bool[Utilities.GetEnumLength<ExoticLanguage>()];
            WeaponProficiency = new bool[Utilities.GetEnumLength<Weapon>()];
            ArmorProficiency = new bool[Utilities.GetEnumLength<Armor>()];
        }
        public Race Race { get; set; }
        public Class Class { get; set; }
        public string FirstName { get; set; }
        public string Nickname { get; set; }
        public string LastName { get; set; }
        public string Background { get; set; }
        public Stats Stats { get; set; }
        public bool[] Resistances { get; set; }
        public bool[] ToolProficiency { get; set; }
        public bool[] ArmorProficiency { get; set; }
        public bool[] WeaponProficiency { get; set; }
        public bool[] InstrumentProficiency { get; set; }
        public bool[] StandardLanguage { get; set; }
        public bool[] ExoticLanguage { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }

        public bool IsResistant(DamageType type) => Resistances[(int)type];
        public bool IsProficient(ArtisanTool tool) => ToolProficiency[(int)tool];
        public bool IsProficient(Instrument instrument) => InstrumentProficiency[(int)instrument];
        public bool IsProficient(StandardLanguage standard) => StandardLanguage[(int)standard];
        public bool IsProficient(ExoticLanguage exotic) => ExoticLanguage[(int)exotic];
        public bool IsProficient(Weapon weapon) => WeaponProficiency[(int)weapon];
        public bool IsProficient(Armor armor) => ArmorProficiency[(int)armor];
    }
}
