using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System;
using System.Collections.Generic;

namespace DnDCharacterCreator.Races
{
    public class Dwarf : IRace
    {
        List<ArtisanTool> dwarfToolOptions = new List<ArtisanTool>()
            {
                ArtisanTool.SmithTools,
                ArtisanTool.BrewerSupplies,
                ArtisanTool.MasonTools
            };
        public void Build(Character character)
        {
            character.IncreaseStat(Stat.Constitution, 1);
            character.Speed = 25;
            character.AddAbility(Ability.DarkVision);
            character.AddResistance(DamageType.Poison);
            character.AddProficiency(Weapon.Battleaxe);
            character.AddProficiency(Weapon.Handaxe);
            character.AddProficiency(Weapon.LightHammer);
            character.AddProficiency(Weapon.Warhammer);
            character.AddProficiency(RNG.ReturnRandom(dwarfToolOptions));
            character.AddProficiency(StandardLanguage.Common);
            character.AddProficiency(StandardLanguage.Dwarvish);
            character.SubRace = RNG.ReturnRandom<DwarfSubrace>();
            switch (character.SubRace)
            {
                case (DwarfSubrace.Hill):
                    character.IncreaseStat(Stat.Wisdom, 1);
                    break;
                case (DwarfSubrace.Mountain):
                    character.IncreaseStat(Stat.Strength, 1);
                    character.AddProficiency(Armor.Light);
                    character.AddProficiency(Armor.Medium);
                    break;
                default:
                    throw new Exception("Failed to apply Dwarf Subrace within Character Builder");
            }
        }
    }
}
