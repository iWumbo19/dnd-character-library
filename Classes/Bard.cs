using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;

namespace DnDCharacterCreator.Classes
{
    public class Bard : IClass
    {
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
            character.AddRandomProf(Instrument.Lute);
            character.AddRandomProf(Instrument.Lute);
            character.AddRandomProf(Instrument.Lute);
            character.AddProficiency(Stat.Dexterity);
            character.AddProficiency(Stat.Charisma);
            character.AddRandomProf(Skill.Arcana);
            character.AddRandomProf(Skill.Arcana);
            character.AddRandomProf(Skill.Arcana);
            // ADD 2 CANTRIPS
            character.AddAbility(Ability.BardicInspiration);
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
    }
}
