using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System.Collections.Generic;

namespace DnDCharacterCreator.Classes
{
    public class Druid : IClass
    {
        private readonly List<Skill> druidSkillOptions = new List<Skill>()
            {
                Skill.Arcana,
                Skill.AnimalHandling,
                Skill.Insight,
                Skill.Medicine,
                Skill.Nature,
                Skill.Perception,
                Skill.Religion,
                Skill.Survival
            };

        public void LevelOne(Character character)
        {
            AssignStats(character);
            character.HitDie = Tables.classHitDie[Options.Class.Druid];
            character.MaxHealth = character.HitDie + character.ConstitutionMod;
            character.AddProficiency(Armor.Light);
            character.AddProficiency(Armor.Medium);
            character.AddProficiency(Armor.Shield);
            character.AddProficiency(Weapon.Club);
            character.AddProficiency(Weapon.Dagger);
            character.AddProficiency(Weapon.Dart);
            character.AddProficiency(Weapon.Javelin);
            character.AddProficiency(Weapon.Mace);
            character.AddProficiency(Weapon.Quarterstaff);
            character.AddProficiency(Weapon.Scimitar);
            character.AddProficiency(Weapon.Sickle);
            character.AddProficiency(Weapon.Sling);
            character.AddProficiency(Weapon.Spear);
            character.AddProficiency(ArtisanTool.HerbalismKit);
            character.AddProficiency(Stat.Intelligence);
            character.AddProficiency(Stat.Wisdom);
            character.AddRandomProf(druidSkillOptions);
            character.AddRandomProf(druidSkillOptions);
            character.AddProficiency(StandardLanguage.Druidic);
            // ADD TWO RANDOM SPELLS   
            character.AddAbility(Ability.WildShape);
            character.WeaponEquiped = WeaponFactory.GetWeapon(Weapon.Quarterstaff);
        }
        public void AssignStats(Character character)
        {
            int[] stats = Utilities.GetRandomStats();
            character.Stats[(int)Stat.Strength] = stats[5];
            character.Stats[(int)Stat.Dexterity] = stats[1];
            character.Stats[(int)Stat.Constitution] = stats[2];
            character.Stats[(int)Stat.Intelligence] = stats[4];
            character.Stats[(int)Stat.Wisdom] = stats[0];
            character.Stats[(int)Stat.Charisma] = stats[3];
        }
    }
}
