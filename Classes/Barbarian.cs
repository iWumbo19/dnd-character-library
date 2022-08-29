using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System.Collections.Generic;

namespace DnDCharacterCreator.Classes
{
    public class Barbarian : IClass
    {
        private readonly List<Skill> barbSkillOptions = new List<Skill>()
            {
                Skill.AnimalHandling,
                Skill.Athletics,
                Skill.Intimidation,
                Skill.Nature,
                Skill.Perception,
                Skill.Survival
            };
        public void LevelOne(Character character)
        {
            AssignStats(character);
            character.HitDie = 12;
            character.MaxHealth = character.HitDie + character.ConstitutionMod;
            character.AddProficiency(Armor.Light);
            character.AddProficiency(Armor.Medium);
            character.AddProficiency(Armor.Shield);
            character.AddProficiency(Utilities.AllWeapons);
            character.AddProficiency(Stat.Dexterity);
            character.AddProficiency(Stat.Constitution);
            character.AddRandomProf(barbSkillOptions);
            character.AddRandomProf(barbSkillOptions);
            character.AddAbility(Ability.Rage);
            character.AddAbility(Ability.UnarmoredDefense);
            character.WeaponEquiped = WeaponFactory.GetWeapon(Options.Weapon.Greataxe);
        }
        public void AssignStats(Character character)
        {
            int[] stats = Utilities.GetRandomStats();
            character.Stats[(int)Stat.Strength] = stats[0];
            character.Stats[(int)Stat.Dexterity] = stats[2];
            character.Stats[(int)Stat.Constitution] = stats[1];
            character.Stats[(int)Stat.Intelligence] = stats[5];
            character.Stats[(int)Stat.Wisdom] = stats[3];
            character.Stats[(int)Stat.Charisma] = stats[4];
        }
        public string GetClassName() => "Barbarian";
    }
}
