using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Classes
{
    public class Paladin : IClass
    {
        private readonly List<Skill> paladinSkillOptions = new List<Skill>()
            {
                Skill.Athletics,
                Skill.Insight,
                Skill.Intimidation,
                Skill.Medicine,
                Skill.Persuasion,
                Skill.Religion
            };

        public void LevelOne(Character character)
        {
            AssignStats(character);
            character.HitDie = Tables.classHitDie[Options.Class.Paladin];
            character.MaxHealth = character.HitDie + character.ConstitutionMod;
            character.AddProficiency(Armor.Light);
            character.AddProficiency(Armor.Medium);
            character.AddProficiency(Armor.Heavy);
            character.AddProficiency(Armor.Shield);
            character.AddProficiency(Utilities.AllWeapons);
            character.AddProficiency(Stat.Wisdom);
            character.AddProficiency(Stat.Charisma);
            character.AddRandomProf(paladinSkillOptions);
            character.AddRandomProf(paladinSkillOptions);
            character.AddAbility(Ability.DivineSense);
            character.AddAbility(Ability.LayOnHands);
        }
        public void AssignStats(Character character)
        {
            int[] stats = Utilities.GetRandomStats();
            character.Stats[(int)Stat.Strength] = stats[0];
            character.Stats[(int)Stat.Dexterity] = stats[3];
            character.Stats[(int)Stat.Constitution] = stats[1];
            character.Stats[(int)Stat.Intelligence] = stats[4];
            character.Stats[(int)Stat.Wisdom] = stats[5];
            character.Stats[(int)Stat.Charisma] = stats[2];
        }
    }
}
