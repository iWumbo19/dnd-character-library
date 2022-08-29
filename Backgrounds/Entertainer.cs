using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Backgrounds
{
    public class Entertainer : IBackground
    {
        public void Build(Character character)
        {
            character.Personality.Bond = ChooseBond();
            character.Personality.Flaw = ChooseFlaw();
            character.Personality.Ideal = ChooseIdeal(character);
            character.Personality.Trait = ChooseTrait();
            character.AddProficiency(Skill.Acrobatics);
            character.AddProficiency(Skill.Performance);
            character.AddProficiency(ArtisanTool.DisguiseKit);
            character.AddRandomProf(Utilities.GetEnumList<Instrument>());

        }

        public string ChooseBond()
        {
            int roll = RNG.Roll(6);
            switch (roll)
            {
                case 1:
                    return "My instrument is my most treasured possession, and it reminds me of someone I love. ";
                case 2:
                    return "Someone stole my precious instrument, and someday I’ll get it back. ";
                case 3:
                    return "I want to be famous, whatever it takes. ";
                case 4:
                    return "I idolize a hero of the old tales and measure my deeds against that person’s. ";
                case 5:
                    return "I will do anything to prove myself superior to my hated rival. ";
                case 6:
                    return "I would do anything for the other members of my old troupe.";
                default:
                    return "";
            }
        }

        public string ChooseFlaw()
        {
            int roll = RNG.Roll(6);
            switch (roll)
            {
                case 1:
                    return "I’ll do anything to win fame and renown. ";
                case 2:
                    return "I’m a sucker for a pretty face. ";
                case 3:
                    return "A scandal prevents me from ever going home again. That kind of trouble seems to follow me around. ";
                case 4:
                    return "I once satirized a noble who still wants my head. It was a mistake that I will likely repeat. ";
                case 5:
                    return "I have trouble keeping my true feelings hidden. My sharp tongue lands me in trouble. ";
                case 6:
                    return "Despite my best efforts, I am unreliable to my friends. ";
                default:
                    return "";
            }
        }

        public string ChooseIdeal(Character character)
        {
            int roll = RNG.Roll(6);
            switch (roll)
            {
                case 1:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Options.Order.Good;
                    return "Beauty. When I perform, I make the world better than it was.";
                case 2:
                    character.Personality.Alignment.Law = Options.Law.Lawful;
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Tradition. The stories, legends, and songs of the past must never be forgotten, for they teach us who we are.";
                case 3:
                    character.Personality.Alignment.Law = Options.Law.Chaotic;
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Creativity. The world is in need of new ideas and bold action";
                case 4:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Options.Order.Evil;
                    return "Greed. I’m only in it for the money and fame.";
                case 5:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Options.Order.Neutral;
                    return "People. I like seeing the smiles on people’s faces when I perform. That’s all that matters.";
                case 6:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Honesty. Art should reflect the soul; it should come from within and reveal who we really are.";
                default:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "";
            }
        }

        public string ChooseTrait()
        {
            int roll = RNG.Roll(8);
            switch (roll)
            {
                case 1:
                    return "I know a story relevant to almost every situation. ";
                case 2:
                    return "Whenever I come to a new place, I collect local rumors and spread gossip. ";
                case 3:
                    return "I’m a hopeless romantic, always searching for that “special someone.” ";
                case 4:
                    return "Nobody stays angry at me or around me for long, since I can defuse any amount of tension. ";
                case 5:
                    return "I love a good insult, even one directed at me. ";
                case 6:
                    return "I get bitter if I’m not the center of attention. ";
                case 7:
                    return "I’ll settle for nothing less than perfection. ";
                case 8:
                    return "I change my mood or my mind as quickly as I change key in a song. ";
                default:
                    return "";
            }
        }
        public string GetBackgroundName() => Options.Background.Entertainer.ToString();

    }
}
