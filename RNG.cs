using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DnDCharacterCreator.Models;

namespace DnDCharacterCreator
{
    internal static class RNG
    {
        private static Random random = new Random();

        public static int Roll() => random.Next(1,21);
        public static int Roll(int high) => random.Next(1, high + 1);
        public static int Roll(int low, int high) => random.Next(low, high);
        public static T ReturnRandom<T>(List<T> collection) => collection[random.Next(collection.Count)];
        public static T ReturnRandom<T>(T[] collection) => collection[random.Next(collection.Length)];
        /// <summary>
        /// ReturnRandom type of EnumType to return random from Enum
        /// </summary>
        /// <typeparam name="T">Enum</typeparam>
        /// <returns>Random Enum Value</returns>
        public static T ReturnRandom<T>()
        {
            var item = Enum.GetValues(typeof(T));
            return (T)item.GetValue(random.Next(item.Length));
        }

    }
}
