using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System.Collections.Generic;

namespace DnDCharacterCreator.Classes
{
    public class Warlock : IClass
    {
        private readonly List<Skill> warlockSkillOptions = new List<Skill>()
            {
                Skill.Arcana,
                Skill.Deception,
                Skill.History,
                Skill.Intimidation,
                Skill.Investigation,
                Skill.Nature,
                Skill.Religion
            };

        public void LevelOne(Character character)
        {
            AssignStats(character);
            character.HitDie = Tables.classHitDie[Options.Class.Warlock];
            character.MaxHealth = character.HitDie + character.ConstitutionMod;
            character.AddProficiency(Utilities.SimpleWeapons);
            character.AddProficiency(Stat.Wisdom);
            character.AddProficiency(Stat.Charisma);
            character.AddRandomProf(warlockSkillOptions);
            character.AddRandomProf(warlockSkillOptions);
            character.AddAbility(Ability.OtherWorldlyPatron);
            character.AddAbility(Ability.PactMagic);
            // ADD 2 RANDOM SPELLS
        }
        public void AssignStats(Character character)
        {
            int[] stats = Utilities.GetRandomStats();
            character.Stats[(int)Stat.Strength] = stats[5];
            character.Stats[(int)Stat.Dexterity] = stats[1];
            character.Stats[(int)Stat.Constitution] = stats[2];
            character.Stats[(int)Stat.Intelligence] = stats[3];
            character.Stats[(int)Stat.Wisdom] = stats[4];
            character.Stats[(int)Stat.Charisma] = stats[0];
        }

    }
}
