using DnDCharacterCreator.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator
{
    public class Alignment
    {
        public Law Law;
        public Order Order;


        public override string ToString()
        {
            return $"{Law} {Order}";
        }
    }
}
