using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System;
using System.Collections.Generic;

namespace DnDCharacterCreator.Classes
{
    public class Cleric : IClass
    {
        private readonly List<Weapon> clericWeaponOptions = new List<Weapon>()
        {
            Weapon.Mace,
            Weapon.Warhammer
        };
        private readonly List<Skill> clericSkillOptions = new List<Skill>()
            {
                Skill.History,
                Skill.Insight,
                Skill.Medicine,
                Skill.Persuasion,
                Skill.Religion
            };
        private readonly List<Skill> knowledgeClericSkills = new List<Skill>()
            {
                Skill.Arcana,
                Skill.History,
                Skill.Nature,
                Skill.Religion
            };
        private readonly List<Skill> natureClericSkills = new List<Skill>()
            {
                Skill.AnimalHandling,
                Skill.Nature,
                Skill.Survival
            };

        public void LevelOne(Character character)
        {
            AssignStats(character);
            character.HitDie = Tables.classHitDie[Options.Class.Cleric];
            character.MaxHealth = character.HitDie + character.ConstitutionMod;
            character.AddProficiency(Armor.Light);
            character.AddProficiency(Armor.Medium);
            character.AddProficiency(Armor.Shield);
            character.AddProficiency(Stat.Wisdom);
            character.AddProficiency(Stat.Charisma);
            character.AddRandomProf(clericSkillOptions);
            character.AddRandomProf(clericSkillOptions);
            // ADD 3 CANTRIPS   
            character.SubClass = RNG.ReturnRandom<ClericSubclass>();
            switch (character.SubClass)
            {
                case ClericSubclass.Knowledge:
                    // ADD COMMAND AND IDENTIFY
                    character.AddRandomProf(knowledgeClericSkills);
                    character.AddRandomProf(knowledgeClericSkills);
                    break;
                case ClericSubclass.Life:
                    // ADD BLESS AND CURE WOUNDS
                    character.AddAbility(Ability.DiscipleOfLife);
                    character.AddProficiency(Armor.Heavy);
                    break;
                case ClericSubclass.Light:
                    // ADD BURNING HANDS, FAERIE FIRE, LIGHT
                    character.AddAbility(Ability.WardingFlare);
                    break;
                case ClericSubclass.Nature:
                    // ADD ANIMAL FRIENDSHIP, SPEAK WITH ANIMALS
                    character.AddProficiency(Armor.Heavy);
                    character.AddRandomProf(natureClericSkills);
                    break;
                case ClericSubclass.Tempest:
                    // ADD FOG CLOUD, THUNDERWAVE
                    character.AddProficiency(Utilities.MartialWeapons);
                    character.AddProficiency(Armor.Heavy);
                    character.AddAbility(Ability.WrathOfTheStorm);
                    break;
                case ClericSubclass.Trickery:
                    // ADD CHARM PERSON, DISGUISE SELF
                    character.AddAbility(Ability.BlessingOfTheTrickster);
                    break;
                case ClericSubclass.War:
                    // ADD DIVINE FAVOR, SHIELD OF FAITH
                    character.AddProficiency(Utilities.MartialWeapons);
                    character.AddProficiency(Armor.Heavy);
                    character.AddAbility(Ability.WarPriest);
                    break;
                default:
                    throw new Exception("Not subrace found for cleric");
            }
            character.WeaponEquiped = WeaponFactory.GetWeapon(RNG.ReturnRandom(clericWeaponOptions));
        }
        public void AssignStats(Character character)
        {
            int[] stats = Utilities.GetRandomStats();
            character.Stats[(int)Stat.Strength] = stats[1];
            character.Stats[(int)Stat.Dexterity] = stats[4];
            character.Stats[(int)Stat.Constitution] = stats[2];
            character.Stats[(int)Stat.Intelligence] = stats[0];
            character.Stats[(int)Stat.Wisdom] = stats[3];
            character.Stats[(int)Stat.Charisma] = stats[5];
        }
    }
}
