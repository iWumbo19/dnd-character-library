using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;

namespace DnDCharacterCreator.Races
{
    public class HalfOrc : IRace
    {
        public Race Race { get; private set; } = Race.HalfOrc;

        public void Build(Character character)
        {
            character.IncreaseStat(Stat.Strength, 2);
            character.IncreaseStat(Stat.Strength, 1);
            character.Speed = 30;
            character.AddAbility(Ability.DarkVision);
            character.AddProficiency(Skill.Intimidation);
            character.AddAbility(Ability.RelentlessEndurance);
            character.AddAbility(Ability.SavageAttacks);
            character.AddProficiency(StandardLanguage.Common);
            character.AddProficiency(StandardLanguage.Orc);
        }
        public Race GetRaceOption()
        {
            return Race;
        }
    }
    
}
