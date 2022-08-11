using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator
{
    internal static class Utilities
    {
        public static int GetEnumLength<T>()
        {
            return Enum.GetNames(typeof(T)).Length;
        }
    }
}
