using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;

namespace DnDCharacterCreator.Interfaces
{
    public interface IRace
    {
        public void Build(Character character);
        public Race GetRaceOption();
    }
}
