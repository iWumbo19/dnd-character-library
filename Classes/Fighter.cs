using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System.Collections.Generic;

namespace DnDCharacterCreator.Classes
{
    public class Fighter : IClass
    {
        
        private readonly List<Skill> fighterSkillOptions = new List<Skill>()
            {
                Skill.Acrobatics,
                Skill.AnimalHandling,
                Skill.Athletics,
                Skill.History,
                Skill.Insight,
                Skill.Intimidation,
                Skill.Perception,
                Skill.Survival
            };

        public void LevelOne(Character character)
        {
            AssignStats(character);
            character.HitDie = Tables.classHitDie[Options.Class.Fighter];
            character.MaxHealth = character.HitDie + character.ConstitutionMod;
            character.AddProficiency(Armor.Heavy);
            character.AddProficiency(Armor.Medium);
            character.AddProficiency(Armor.Light);
            character.AddProficiency(Armor.Shield);
            character.AddProficiency(Stat.Strength);
            character.AddProficiency(Stat.Constitution);
            character.AddRandomProf(fighterSkillOptions);
            character.AddRandomProf(fighterSkillOptions);
            character.WeaponEquiped = WeaponFactory.GetWeapon(RNG.ReturnRandom(Utilities.AllWeapons));
        }
        public void AssignStats(Character character)
        {
            int[] stats = Utilities.GetRandomStats();
            character.Stats[(int)Stat.Strength] = stats[0];
            character.Stats[(int)Stat.Dexterity] = stats[2];
            character.Stats[(int)Stat.Constitution] = stats[1];
            character.Stats[(int)Stat.Intelligence] = stats[3];
            character.Stats[(int)Stat.Wisdom] = stats[5];
            character.Stats[(int)Stat.Charisma] = stats[4];
        }
    }
}
