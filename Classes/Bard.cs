using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System.Collections.Generic;

namespace DnDCharacterCreator.Classes
{
    public class Bard : IClass
    {
        private readonly List<Weapon> bardWeaponOptions = new List<Weapon>()
        {
            Weapon.Rapier,
            Weapon.Longsword
        };

        public void LevelOne(Character character)
        {
            AssignStats(character);
            character.HitDie = Tables.classHitDie[Options.Class.Bard];
            character.MaxHealth = character.HitDie + character.ConstitutionMod;
            character.AddProficiency(Armor.Light);
            character.AddProficiency(Utilities.SimpleWeapons);
            character.AddProficiency(Weapon.Crossbow);
            character.AddProficiency(Weapon.Longsword);
            character.AddProficiency(Weapon.Rapier);
            character.AddProficiency(Weapon.Shortsword);
            character.AddProficiency(RNG.ReturnRandom<Instrument>());
            character.AddRandomProf(Utilities.GetEnumList<Instrument>());
            character.AddRandomProf(Utilities.GetEnumList<Instrument>());
            character.AddRandomProf(Utilities.GetEnumList<Instrument>());
            character.AddProficiency(Stat.Dexterity);
            character.AddProficiency(Stat.Charisma);
            character.AddRandomProf(Utilities.GetEnumList<Skill>());
            character.AddRandomProf(Utilities.GetEnumList<Skill>());
            character.AddRandomProf(Utilities.GetEnumList<Skill>());
            // ADD 2 CANTRIPS
            character.AddAbility(Ability.BardicInspiration);
            character.WeaponEquiped = WeaponFactory.GetWeapon(RNG.ReturnRandom(bardWeaponOptions));
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
        public string GetClassName() => "Bard";
    }
}
