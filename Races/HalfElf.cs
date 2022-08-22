using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;

namespace DnDCharacterCreator.Races
{
    public class HalfElf : IRace
    {
        public void Build(Character character)
        {
            character.IncreaseStat(Stat.Charisma, 2);
            character.Speed = 30;
            character.AddAbility(Ability.DarkVision);
            character.AddAbility(Ability.FeyAncentry);
            Stat profOne = RNG.ReturnRandom<Stat>();
            Stat profTwo = RNG.ReturnRandom<Stat>();
            while (profOne == profTwo)
                profTwo = RNG.ReturnRandom<Stat>();
            character.AddProficiency(profOne);
            character.AddProficiency(profTwo);
            Skill skillOne = RNG.ReturnRandom<Skill>();
            Skill skillTwo = RNG.ReturnRandom<Skill>();
            while (skillOne == skillTwo)
                skillTwo = RNG.ReturnRandom<Skill>();
            character.AddProficiency(skillOne);
            character.AddProficiency(skillTwo);
            character.AddProficiency(RNG.ReturnRandom<StandardLanguage>());
        }
    }
}
