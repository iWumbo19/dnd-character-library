using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System;

namespace DnDCharacterCreator.Races
{
    public class Elf : IRace
    {
        public Race Race { get; private set; } = Race.Elf;
        public void Build(Character character)
        {
            character.IncreaseStat(Stat.Dexterity, 1);
            character.Speed = 30;
            character.AddAbility(Ability.DarkVision);
            character.AddProficiency(Skill.Perception);
            character.AddAbility(Ability.FeyAncentry);
            character.AddAbility(Ability.Trance);
            character.AddProficiency(StandardLanguage.Common);
            character.AddProficiency(StandardLanguage.Elvish);
            character.SubRace = RNG.ReturnRandom<ElfSubrace>();
            switch (character.SubRace)
            {
                case (ElfSubrace.Wood):
                    character.AddProficiency(Weapon.Longsword);
                    character.AddProficiency(Weapon.Shortsword);
                    character.AddProficiency(Weapon.Shortbow);
                    character.AddProficiency(Weapon.Longbow);
                    character.Speed += 5;
                    character.AddAbility(Ability.MaskOfTheWild);
                    break;
                case (ElfSubrace.Dark):
                    character.IncreaseStat(Stat.Charisma, 1);
                    character.AddAbility(Ability.SunlightSensitivity);
                    character.AddAbility(Ability.DrowMagic);
                    character.AddProficiency(Weapon.Rapier);
                    character.AddProficiency(Weapon.Shortsword);
                    character.AddProficiency(Weapon.Crossbow);
                    break;
                case (ElfSubrace.High):
                    character.IncreaseStat(Stat.Intelligence, 1);
                    character.AddProficiency(Weapon.Longsword); ;
                    character.AddProficiency(Weapon.Shortsword);
                    character.AddProficiency(Weapon.Shortbow);
                    character.AddProficiency(Weapon.Shortsword);
                    int langRoll = RNG.Roll(2);
                    if (langRoll == 1)
                        character.AddProficiency(RNG.ReturnRandom<StandardLanguage>());
                    else
                        character.AddProficiency(RNG.ReturnRandom<ExoticLanguage>());
                    break;
                default:
                    throw new Exception("Failed to apply Elf Subrace within Character Builder");
            }
        }
        public Race GetRaceOption()
        {
            return Race;
        }
        public string GetRaceName() => "Elf";
    }
}
