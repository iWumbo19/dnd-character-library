using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;

namespace DnDCharacterCreator.Races
{
    public class HalfOrc : IRace
    {
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
    }
}
