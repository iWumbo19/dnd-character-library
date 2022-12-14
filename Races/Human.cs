

using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;

namespace DnDCharacterCreator.Races
{
    public class Human : IRace
    {
        public Race Race { get; private set; } = Race.Human;
        public void Build(Character character)
        {
            character.IncreaseStat(Stat.Strength, 1);
            character.IncreaseStat(Stat.Dexterity, 1);
            character.IncreaseStat(Stat.Constitution, 1);
            character.IncreaseStat(Stat.Intelligence, 1);
            character.IncreaseStat(Stat.Wisdom, 1);
            character.IncreaseStat(Stat.Charisma, 1);
            character.Speed = 30;
            character.AddProficiency(StandardLanguage.Common);
            int langRoll = RNG.Roll(2);
            if (langRoll == 1)
                character.AddProficiency(RNG.ReturnRandom<StandardLanguage>());
            else
                character.AddProficiency(RNG.ReturnRandom<ExoticLanguage>());
        }
        public Race GetRaceOption()
        {
            return Race;
        }
        public string GetRaceName() => "Human";
    }
    
}
