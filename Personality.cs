using DnDCharacterCreator.Backgrounds;
using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator
{
    public class Personality
    {
        public string Trait;
        public string Ideal;
        public string Bond;
        public string Flaw;
        public Alignment Alignment;
        public IBackground Background;

        public Personality(Character character)
        {
            GetBackground();
            Background.Build(character);
        }

        public void GetBackground()
        {
            switch (RNG.ReturnRandom<Background>())
            {
                case Options.Background.Acolyte:
                    Background = new Acolyte();
                    break;
                case Options.Background.Charlatan:
                    Background = new Charlatan();
                    break;
                case Options.Background.Criminal:
                    Background = new Criminal();
                    break;
                case Options.Background.Entertainer:
                    Background = new Entertainer();
                    break;
                case Options.Background.FolkHero:
                    Background = new FolkHero();
                    break;
                case Options.Background.GuildArtisan:
                    Background = new GuildArtisan();
                    break;
                case Options.Background.Hermit:
                    Background = new Hermit();
                    break;
                case Options.Background.Noble:
                    Background = new Noble();
                    break;
                case Options.Background.Outlander:
                    Background = new Outlander();
                    break;
                case Options.Background.Sage:
                    Background = new Sage();
                    break;
                case Options.Background.Sailor:
                    Background = new Sailor();
                    break;
                case Options.Background.Soldier:
                    Background = new Soldier();
                    break;
                case Options.Background.Urchin:
                    Background = new Urchin();
                    break;
                default:
                    Background = new Acolyte();
                    break;
            }
        }
        




    }
}
