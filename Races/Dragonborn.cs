using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System;

namespace DnDCharacterCreator.Races
{
    public class Dragonborn : IRace
    {
        public void Build(Character character)
        {
            character.IncreaseStat(Stat.Strength, 1);
            character.IncreaseStat(Stat.Charisma, 1);
            character.Speed = 30;
            character.AddProficiency(StandardLanguage.Common);
            character.AddProficiency(ExoticLanguage.Draconic);
            character.AddAbility(Ability.BreathWeapon);
            character.SubRace = RNG.ReturnRandom<DragonbornSubrace>();
            switch (character.SubRace)
            {
                case (DragonbornSubrace.Black):
                    character.AddResistance(DamageType.Acid);
                    break;
                case (DragonbornSubrace.Blue):
                    character.AddResistance(DamageType.Lightning);
                    break;
                case (DragonbornSubrace.Brass):
                    character.AddResistance(DamageType.Fire);
                    break;
                case (DragonbornSubrace.Bronze):
                    character.AddResistance(DamageType.Lightning);
                    break;
                case (DragonbornSubrace.Copper):
                    character.AddResistance(DamageType.Acid);
                    break;
                case (DragonbornSubrace.Gold):
                    character.AddResistance(DamageType.Fire);
                    break;
                case (DragonbornSubrace.Green):
                    character.AddResistance(DamageType.Poison);
                    break;
                case (DragonbornSubrace.Red):
                    character.AddResistance(DamageType.Fire);
                    break;
                case (DragonbornSubrace.Silver):
                    character.AddResistance(DamageType.Cold);
                    break;
                case (DragonbornSubrace.White):
                    character.AddResistance(DamageType.Cold);
                    break;
                default:
                    throw new Exception("Failed to apply Halfling Subrace within Character Builder");
            }
        }
    }
}
