using DnDCharacterCreator.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Models
{
    public class WeaponModel
    {
        public int DieAmount { get; private set; }
        public int DamageDie { get; private set; }
        public string Name { get; private set; }
        public DamageType DamageType { get; private set; }
        public WeaponType WeaponType { get; private set; }
        public WeaponModel(string name, int dieAmount, int dieDmg, DamageType type, WeaponType weapontype)
        {
            DieAmount = dieAmount;
            DamageDie = dieDmg;
            Name = name;
            DamageType = type;
            WeaponType = weapontype;
        }
    }
}
