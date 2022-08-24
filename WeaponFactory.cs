using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System;

namespace DnDCharacterCreator
{
    public static class WeaponFactory
    {
        public static Models.WeaponModel GetWeapon(Options.Weapon weapon)
        {
            switch (weapon)
            {
                case Options.Weapon.Club:
                    return new Models.WeaponModel("Club", 1, 4, DamageType.Bludgeoning,WeaponType.SimpleMelee);
                case Options.Weapon.Dagger:
                    return new Models.WeaponModel("Dagger", 1, 4, DamageType.Piercing, WeaponType.SimpleMelee);
                case Options.Weapon.Greatclub:
                    return new Models.WeaponModel("Greatclub", 1, 8, DamageType.Bludgeoning, WeaponType.SimpleMelee);
                case Options.Weapon.Handaxe:
                    return new Models.WeaponModel("Handaxe",1,6,DamageType.Slashing, WeaponType.SimpleMelee);
                case Options.Weapon.Javelin:
                    return new Models.WeaponModel("Javelin",1,6,DamageType.Piercing, WeaponType.SimpleMelee);
                case Options.Weapon.LightHammer:
                    return new Models.WeaponModel("Light Hammer",1,4,DamageType.Bludgeoning, WeaponType.SimpleMelee);
                case Options.Weapon.Mace:
                    return new Models.WeaponModel("Mace",1,6,DamageType.Bludgeoning, WeaponType.SimpleMelee);
                case Options.Weapon.Quarterstaff:
                    return new Models.WeaponModel("Quarterstaff",1,6,DamageType.Bludgeoning, WeaponType.SimpleMelee);
                case Options.Weapon.Sickle:
                    return new Models.WeaponModel("Sickle",1,4,DamageType.Slashing, WeaponType.SimpleMelee);
                case Options.Weapon.Spear:
                    return new Models.WeaponModel("Spear",1,6, DamageType.Piercing, WeaponType.SimpleMelee);
                case Options.Weapon.Crossbow:
                    return new Models.WeaponModel("Light Crossbow",1,8,DamageType.Piercing, WeaponType.SimpleRanged);
                case Options.Weapon.Dart:
                    return new Models.WeaponModel("Dart",1,4,DamageType.Piercing, WeaponType.SimpleRanged);
                case Options.Weapon.Shortbow:
                    return new Models.WeaponModel("Shortbow",1,6,DamageType.Piercing, WeaponType.SimpleRanged);
                case Options.Weapon.Sling:
                    return new Models.WeaponModel("Sling",1,4,DamageType.Bludgeoning, WeaponType.SimpleRanged);
                case Options.Weapon.Battleaxe:
                    return new Models.WeaponModel("Battleaxe",1,8,DamageType.Slashing, WeaponType.MartialMelee);
                case Options.Weapon.Flail:
                    return new Models.WeaponModel("Flail",1,8,DamageType.Bludgeoning, WeaponType.MartialMelee);
                case Options.Weapon.Glaive:
                    return new Models.WeaponModel("Glaive", 1,10,DamageType.Slashing, WeaponType.MartialMelee);
                case Options.Weapon.Greataxe:
                    return new Models.WeaponModel("Greataxe",1,12,DamageType.Slashing, WeaponType.MartialMelee);
                case Options.Weapon.Greatsword:
                    return new Models.WeaponModel("Greatsword",2,6,DamageType.Slashing, WeaponType.MartialMelee);
                case Options.Weapon.Halberd:
                    return new Models.WeaponModel("Halbred",1,10,DamageType.Slashing, WeaponType.MartialMelee);
                case Options.Weapon.Lance:
                    return new Models.WeaponModel("Lance",1,12,DamageType.Piercing, WeaponType.MartialMelee);
                case Options.Weapon.Longsword:
                    return new Models.WeaponModel("Longsword",1,8,DamageType.Slashing, WeaponType.MartialMelee);
                case Options.Weapon.Maul:
                    return new Models.WeaponModel("Maul",2,6,DamageType.Bludgeoning, WeaponType.MartialMelee);
                case Options.Weapon.Morningstar:
                    return new Models.WeaponModel("Morningstar",1,8,DamageType.Piercing, WeaponType.MartialMelee);
                case Options.Weapon.Pike:
                    return new Models.WeaponModel("Pike",1,10,DamageType.Piercing, WeaponType.MartialMelee);
                case Options.Weapon.Rapier:
                    return new Models.WeaponModel("Rapier",1,8,DamageType.Piercing, WeaponType.MartialMelee);
                case Options.Weapon.Scimitar:
                    return new Models.WeaponModel("Scimitar",1,6,DamageType.Slashing, WeaponType.MartialMelee);
                case Options.Weapon.Shortsword:
                    return new Models.WeaponModel("Shortsword", 1,6,DamageType.Slashing, WeaponType.MartialMelee);
                case Options.Weapon.Trident:
                    return new Models.WeaponModel("Trident",1,6,DamageType.Piercing, WeaponType.MartialMelee);
                case Options.Weapon.WarPick:
                    return new Models.WeaponModel("War Pick",1,8,DamageType.Piercing, WeaponType.MartialMelee);
                case Options.Weapon.Warhammer:
                    return new Models.WeaponModel("Warhammer",1,8,DamageType.Bludgeoning, WeaponType.MartialMelee);
                case Options.Weapon.Whip:
                    return new Models.WeaponModel("Whip",1,4,DamageType.Slashing, WeaponType.MartialMelee);
                case Options.Weapon.Blowgun:
                    return new Models.WeaponModel("Blowgun",1,1,DamageType.Piercing, WeaponType.MartialRanged);
                case Options.Weapon.Longbow:
                    return new Models.WeaponModel("Hand Crossbow",1,6,DamageType.Piercing, WeaponType.MartialRanged);
                case Options.Weapon.HeavyCrossbow:
                    return new Models.WeaponModel("Heavy Crossbow", 1,10,DamageType.Piercing, WeaponType.MartialRanged);
                case Options.Weapon.Net:
                    return new Models.WeaponModel("Net",1,1,DamageType.Bludgeoning, WeaponType.MartialRanged);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
