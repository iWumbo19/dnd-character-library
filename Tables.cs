using DnDCharacterCreator.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator
{
    internal static class Tables
    {
        public static readonly Dictionary<Class, int> classHitDie = new Dictionary<Class, int>()
        {
            {Class.Sorcerer, 6 },
            {Class.Wizard,6 },
            {Class.Bard,8 },
            {Class.Cleric,8 },
            {Class.Druid,8 },
            {Class.Monk,8 },
            {Class.Rouge,8 },
            {Class.Warlock,8 },
            {Class.Fighter,10 },
            {Class.Paladin,10 },
            {Class.Ranger,10 },
            {Class.Barbarian,12 },
        };
        public static readonly Dictionary<int, int> LevelProf = new Dictionary<int, int>()
        {
            {1,2 },
            {2,2 },
            {3,2 },
            {4,2 },
            {5,3 },
            {6,3 },
            {7,3 },
            {8,3 },
            {9,4 },
            {10,4 },
            {11,4 },
            {12,4 },
            {13,5 },
            {14,5 },
            {15,5 },
            {16,5 },
            {17,6 },
            {18,6 },
            {19,6 },
            {20,6 },
        };
        public static readonly Dictionary<int, int> ScoreMod = new Dictionary<int, int>()
        {
            {1,-5 },
            {2,-4 },
            {3,-4 },
            {4,-3 },
            {5,-3 },
            {6,-2 },
            {7,-2 },
            {8,-1 },
            {9,-1 },
            {10,0 },
            {11,0 },
            {12,1 },
            {13,1 },
            {14,2 },
            {15,2 },
            {16,3 },
            {17,3 },
            {18,4 },
            {19,4 },
            {20,5 },
            {21,5 },
            {22,6 },
            {23,6 },
            {24,7 },
            {25,7 },
            {26,8 },
            {27,8 },
            {28,9 },
            {29,9 },
            {30,10 },
        };
    }
}
