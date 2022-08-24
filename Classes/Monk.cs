using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System.Collections.Generic;

namespace DnDCharacterCreator.Classes
{
    public class Monk : IClass
    {
        private readonly List<Skill> monkSkillOptions = new List<Skill>()
            {
                Skill.Acrobatics,
                Skill.Athletics,
                Skill.History,
                Skill.Insight,
                Skill.Religion,
                Skill.Stealth
            };

        public void LevelOne(Character character)
        {
            AssignStats(character);
            character.HitDie = Tables.classHitDie[Options.Class.Monk];
            character.MaxHealth = character.HitDie + character.ConstitutionMod;
            character.AddProficiency(Utilities.SimpleWeapons);
            character.AddProficiency(Weapon.Shortsword);
            character.AddRandomProf(Utilities.GetEnumList<ArtisanTool>());
            character.AddProficiency(Stat.Strength);
            character.AddProficiency(Stat.Dexterity);
            character.AddRandomProf(monkSkillOptions);
            character.AddRandomProf(monkSkillOptions);
            character.AddAbility(Ability.UnarmoredDefense);
            character.AddAbility(Ability.MartialArts);
            character.WeaponEquiped = WeaponFactory.GetWeapon(Weapon.Quarterstaff);
        }
        public void AssignStats(Character character)
        {
            int[] stats = Utilities.GetRandomStats();
            character.Stats[(int)Stat.Strength] = stats[3];
            character.Stats[(int)Stat.Dexterity] = stats[0];
            character.Stats[(int)Stat.Constitution] = stats[1];
            character.Stats[(int)Stat.Intelligence] = stats[2];
            character.Stats[(int)Stat.Wisdom] = stats[5];
            character.Stats[(int)Stat.Charisma] = stats[4];
        }
    }
}
