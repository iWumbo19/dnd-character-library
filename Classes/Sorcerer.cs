using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System.Collections.Generic;

namespace DnDCharacterCreator.Classes
{
    public class Sorcerer : IClass
    {
        private readonly List<Skill> sorcererSkillOptions = new List<Skill>()
            {
                Skill.Arcana,
                Skill.Deception,
                Skill.Insight,
                Skill.Intimidation,
                Skill.Persuasion,
                Skill.Religion
            };

        public void LevelOne(Character character)
        {
            AssignStats(character);
            character.HitDie = Tables.classHitDie[Options.Class.Sorcerer];
            character.MaxHealth = character.HitDie + character.ConstitutionMod;
            character.AddProficiency(Weapon.Dagger);
            character.AddProficiency(Weapon.Dart);
            character.AddProficiency(Weapon.Sling);
            character.AddProficiency(Weapon.Quarterstaff);
            character.AddProficiency(Weapon.Crossbow);
            character.AddProficiency(Stat.Constitution);
            character.AddProficiency(Stat.Charisma);
            character.AddRandomProf(sorcererSkillOptions);
            character.AddRandomProf(sorcererSkillOptions);
            // ADD FOUR RANDOM CANTRIPS 
            character.WeaponEquiped = WeaponFactory.GetWeapon(Weapon.Quarterstaff);
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
        public string GetClassName() => "Sorcerer";
    }
}
