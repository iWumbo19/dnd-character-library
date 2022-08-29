using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System.Collections.Generic;

namespace DnDCharacterCreator.Classes
{
    public class Rouge : IClass
    {
        private readonly List<Skill> rougeSkillOptions = new List<Skill>()
            {
                Skill.Acrobatics,
                Skill.Athletics,
                Skill.Deception,
                Skill.Insight,
                Skill.Intimidation,
                Skill.Investigation,
                Skill.Perception,
                Skill.Performance,
                Skill.Persuasion,
                Skill.SleightOfHand,
                Skill.Stealth
            };

        public void LevelOne(Character character)
        {
            AssignStats(character);
            character.HitDie = Tables.classHitDie[Options.Class.Rouge];
            character.MaxHealth = character.HitDie + character.ConstitutionMod;
            character.AddProficiency(Armor.Light);
            character.AddProficiency(Utilities.SimpleWeapons);
            character.AddProficiency(Weapon.Crossbow);
            character.AddProficiency(Weapon.Longsword);
            character.AddProficiency(Weapon.Rapier);
            character.AddProficiency(Weapon.Shortsword);
            character.AddProficiency(ArtisanTool.ThievesTools);
            character.AddProficiency(Stat.Dexterity);
            character.AddProficiency(Stat.Intelligence);
            character.AddRandomProf(rougeSkillOptions);
            character.AddRandomProf(rougeSkillOptions);
            character.AddRandomProf(rougeSkillOptions);
            character.AddRandomProf(rougeSkillOptions);
            character.AddAbility(Ability.Expertise);
            character.AddAbility(Ability.SneakAttack);
            character.AddProficiency(StandardLanguage.ThievesCant);
            character.WeaponEquiped = WeaponFactory.GetWeapon(Weapon.Dagger);
        }
        public void AssignStats(Character character)
        {
            int[] stats = Utilities.GetRandomStats();
            character.Stats[(int)Stat.Strength] = stats[5];
            character.Stats[(int)Stat.Dexterity] = stats[0];
            character.Stats[(int)Stat.Constitution] = stats[1];
            character.Stats[(int)Stat.Intelligence] = stats[3];
            character.Stats[(int)Stat.Wisdom] = stats[4];
            character.Stats[(int)Stat.Charisma] = stats[2];
        }
        public string GetClassName() => "Rouge";
    }
}
