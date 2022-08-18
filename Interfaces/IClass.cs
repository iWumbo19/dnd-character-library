using DnDCharacterCreator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Interfaces
{
    internal interface IClass
    {
        public void AssignStats(Character character);
        public void LevelOne(Character character);
    }
}
