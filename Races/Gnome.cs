using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System;

namespace DnDCharacterCreator.Races
{
    public class Gnome : IRace
    {
        public void Build(Character character)
        {
            character.IncreaseStat(Stat.Intelligence, 2);
            character.Speed = 30;
            character.AddAbility(Ability.DarkVision);
            character.AddAbility(Ability.GnomeCunning);
            character.AddProficiency(StandardLanguage.Common);
            character.AddProficiency(StandardLanguage.Gnomish);
            character.SubRace = RNG.ReturnRandom<GnomeSubrace>();
            switch (character.SubRace)
            {
                case (GnomeSubrace.Forest):
                    character.IncreaseStat(Stat.Dexterity, 1);
                    // ADD SPELL MINOR ILLUSION/
                    character.AddAbility(Ability.SpeakWithSmallBeasts);
                    break;
                case (GnomeSubrace.Rock):
                    character.IncreaseStat(Stat.Constitution, 2);
                    character.AddAbility(Ability.ArtificersLore);
                    character.AddAbility(Ability.Tinker);
                    character.AddProficiency(ArtisanTool.TinkerTools);
                    break;
                default:
                    throw new Exception("Failed to apply Halfling Subrace within Character Builder");
            }
        }
    }
}
