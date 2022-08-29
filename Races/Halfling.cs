using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System;

namespace DnDCharacterCreator.Races
{
    public class Halfling : IRace
    {
        public Race Race { get; private set; } = Race.Halfling;
        public void Build(Character character)
        {
            character.IncreaseStat(Stat.Dexterity, 1);
            character.Speed = 25;
            character.AddAbility(Ability.Lucky);
            character.AddAbility(Ability.Brave);
            character.AddAbility(Ability.HalflingNimbleness);
            character.AddProficiency(StandardLanguage.Common);
            character.AddProficiency(StandardLanguage.Halfing);
            character.SubRace = RNG.ReturnRandom<HalflingSubrace>();
            switch (character.SubRace)
            {
                case (HalflingSubrace.Lightfoot):
                    character.IncreaseStat(Stat.Charisma, 1);
                    character.AddAbility(Ability.NaturallyStealthy);
                    break;
                case (HalflingSubrace.Stout):
                    character.IncreaseStat(Stat.Constitution, 1);
                    character.AddAbility(Ability.StoutResilience);
                    break;
                default:
                    throw new Exception("Failed to apply Halfling Subrace within Character Builder");
            }
        }
        public Race GetRaceOption()
        {
            return Race;
        }
        public string GetRaceName() => "Halfling";
    }
}
