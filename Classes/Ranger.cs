using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System.Collections.Generic;

namespace DnDCharacterCreator.Classes
{
    public class Ranger : IClass
    {
        private readonly List<Skill> rangerSkillOptions = new List<Skill>()
            {
                Skill.AnimalHandling,
                Skill.Athletics,
                Skill.Insight,
                Skill.Investigation,
                Skill.Nature,
                Skill.Perception,
                Skill.Stealth,
                Skill.Survival
            };

        public void LevelOne(Character character)
        {
            AssignStats(character);
            character.HitDie = Tables.classHitDie[Options.Class.Ranger];
            character.MaxHealth = character.HitDie + character.ConstitutionMod;
            character.AddProficiency(Armor.Light);
            character.AddProficiency(Armor.Medium);
            character.AddProficiency(Armor.Shield);
            character.AddProficiency(Utilities.AllWeapons);
            character.AddRandomProf(rangerSkillOptions);
            character.AddRandomProf(rangerSkillOptions);
            character.AddRandomProf(rangerSkillOptions);
            character.AddAbility(Ability.FavoredEnemy);
            character.AddAbility(Ability.NaturalExplorer);
            character.WeaponEquiped = WeaponFactory.GetWeapon(Weapon.Longbow);
        }
        public void AssignStats(Character character)
        {
            int[] stats = Utilities.GetRandomStats();
            character.Stats[(int)Stat.Strength] = stats[5];
            character.Stats[(int)Stat.Dexterity] = stats[0];
            character.Stats[(int)Stat.Constitution] = stats[2];
            character.Stats[(int)Stat.Intelligence] = stats[3];
            character.Stats[(int)Stat.Wisdom] = stats[1];
            character.Stats[(int)Stat.Charisma] = stats[4];
        }
        public string GetClassName() => "Ranger";
    }
}
