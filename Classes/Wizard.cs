using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System.Collections.Generic;

namespace DnDCharacterCreator.Classes
{
    public class Wizard : IClass
    {
        private readonly List<Skill> wizardSkillOptions = new List<Skill>()
            {
                Skill.Arcana,
                Skill.History,
                Skill.Insight,
                Skill.Investigation,
                Skill.Medicine,
                Skill.Religion
            };

        public void LevelOne(Character character)
        {
            AssignStats(character);
            character.HitDie = Tables.classHitDie[Options.Class.Wizard];
            character.MaxHealth = character.HitDie + character.ConstitutionMod;
            character.AddProficiency(Weapon.Dagger);
            character.AddProficiency(Weapon.Dart);
            character.AddProficiency(Weapon.Sling);
            character.AddProficiency(Weapon.Quarterstaff);
            character.AddProficiency(Stat.Intelligence);
            character.AddProficiency(Stat.Wisdom);
            character.AddRandomProf(wizardSkillOptions);
            character.AddRandomProf(wizardSkillOptions);
            character.AddAbility(Ability.ArcaneRecovery);
            character.WeaponEquiped = WeaponFactory.GetWeapon(Weapon.Quarterstaff);
        }
        public void AssignStats(Character character)
        {
            int[] stats = Utilities.GetRandomStats();
            character.Stats[(int)Stat.Strength] = stats[5];
            character.Stats[(int)Stat.Dexterity] = stats[1];
            character.Stats[(int)Stat.Constitution] = stats[2];
            character.Stats[(int)Stat.Intelligence] = stats[0];
            character.Stats[(int)Stat.Wisdom] = stats[3];
            character.Stats[(int)Stat.Charisma] = stats[4];
        }
    }
}
