using DnDCharacterCreator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Interfaces
{
    public interface IBackground
    {
        
        public void Build(Character character);

        public string ChooseTrait();
        public string ChooseIdeal(Character character);
        public string ChooseBond();
        public string ChooseFlaw();
        public string GetBackgroundName();

    }
}
