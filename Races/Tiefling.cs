using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;

namespace DnDCharacterCreator.Races
{
    class Tiefling : IRace
    {
        public Race Race { get; private set; } = Race.Tiefling;
        public void Build(Character character)
        {
            character.IncreaseStat(Stat.Intelligence, 1);
            character.IncreaseStat(Stat.Charisma, 2);
            character.Speed = 30;
            character.AddAbility(Ability.DarkVision);
            character.AddResistance(DamageType.Fire);
            // ADD THAUMATURGY
            character.AddProficiency(StandardLanguage.Common);
            character.AddProficiency(ExoticLanguage.Infernal);
        }
        public Race GetRaceOption()
        {
            return Race;
        }
    }
    
}
