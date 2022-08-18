using System;
using System.Collections.Generic;
using DnDCharacterCreator.Options;
using System.Text;

namespace DnDCharacterCreator
{
    internal static class Utilities
    {
        public static readonly List<Weapon> SimpleMeleeWeapons = new List<Weapon>()
        {
            Weapon.Club,
            Weapon.Dagger,
            Weapon.Greatclub,
            Weapon.Handaxe,
            Weapon.Javelin,
            Weapon.LightHammer,
            Weapon.Mace,
            Weapon.Quarterstaff,
            Weapon.Sickle,
            Weapon.Spear
        };
        public static readonly List<Weapon> SimpleRangedWeapons = new List<Weapon>()
        { 
            Weapon.Crossbow,
            Weapon.Dart,
            Weapon.Shortbow,
            Weapon.Sling
        };
        public static readonly List<Weapon> MartialMeleeWeapons = new List<Weapon>()
        {
            Weapon.Battleaxe,
            Weapon.Flail,
            Weapon.Greataxe,
            Weapon.Halberd,
            Weapon.Lance,
            Weapon.Longsword,
            Weapon.Maul,
            Weapon.Morningstar,
            Weapon.Pike,
            Weapon.Rapier,
            Weapon.Scimitar,
            Weapon.Shortsword,
            Weapon.Trident,
            Weapon.WarPick,
            Weapon.Warhammer,
            Weapon.Whip
        };
        public static readonly List<Weapon> MartialRangedWeapons = new List<Weapon>()
        {
            Weapon.Blowgun,
            Weapon.HeavyCrossbow,
            Weapon.Longbow,
            Weapon.Net
        };
        public static readonly List<Weapon> SimpleWeapons = new List<Weapon>()
        {
            Weapon.Club,
            Weapon.Dagger,
            Weapon.Greatclub,
            Weapon.Handaxe,
            Weapon.Javelin,
            Weapon.LightHammer,
            Weapon.Mace,
            Weapon.Quarterstaff,
            Weapon.Sickle,
            Weapon.Spear,
            Weapon.Crossbow,
            Weapon.Dart,
            Weapon.Shortbow,
            Weapon.Sling
        };
        public static readonly List<Weapon> MartialWeapons = new List<Weapon>()
        {
            Weapon.Battleaxe,
            Weapon.Flail,
            Weapon.Greataxe,
            Weapon.Halberd,
            Weapon.Lance,
            Weapon.Longsword,
            Weapon.Maul,
            Weapon.Morningstar,
            Weapon.Pike,
            Weapon.Rapier,
            Weapon.Scimitar,
            Weapon.Shortsword,
            Weapon.Trident,
            Weapon.WarPick,
            Weapon.Warhammer,
            Weapon.Whip,
            Weapon.Blowgun,
            Weapon.HeavyCrossbow,
            Weapon.Longbow,
            Weapon.Net
        };
        public static readonly List<Weapon> AllWeapons = new List<Weapon>()
        {
            Weapon.Club,
            Weapon.Dagger,
            Weapon.Greatclub,
            Weapon.Handaxe,
            Weapon.Javelin,
            Weapon.LightHammer,
            Weapon.Mace,
            Weapon.Quarterstaff,
            Weapon.Sickle,
            Weapon.Spear,
            Weapon.Crossbow,
            Weapon.Dart,
            Weapon.Shortbow,
            Weapon.Sling,
            Weapon.Battleaxe,
            Weapon.Flail,
            Weapon.Greataxe,
            Weapon.Halberd,
            Weapon.Lance,
            Weapon.Longsword,
            Weapon.Maul,
            Weapon.Morningstar,
            Weapon.Pike,
            Weapon.Rapier,
            Weapon.Scimitar,
            Weapon.Shortsword,
            Weapon.Trident,
            Weapon.WarPick,
            Weapon.Warhammer,
            Weapon.Whip,
            Weapon.Blowgun,
            Weapon.HeavyCrossbow,
            Weapon.Longbow,
            Weapon.Net
        };

        public static int GetEnumLength<T>() => Enum.GetNames(typeof(T)).Length;

        public static int[] GetRandomStats()
        {
            List<int> output = new List<int>();
            for (int i = 0; i < 7; i++)
                output.Add(RNG.Roll(6) + RNG.Roll(6) + RNG.Roll(6));
            output.Sort();
            output.RemoveAt(0);
            output.Reverse();
            return output.ToArray();

        }
    }
}
