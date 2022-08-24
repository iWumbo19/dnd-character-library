using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Backgrounds
{
    public class Noble : IBackground
    {
        public void Build(Character character)
        {
            character.Personality.Bond = ChooseBond();
            character.Personality.Flaw = ChooseFlaw();
            character.Personality.Ideal = ChooseIdeal(character);
            character.Personality.Trait = ChooseTrait();
            character.AddProficiency(Options.Skill.History);
            character.AddProficiency(Options.Skill.Persuasion);
            character.AddRandomProf(Utilities.GetEnumList<ArtisanTool>());
        }

        public string ChooseBond()
        {
            int roll = RNG.Roll(6);
            switch (roll)
            {
                case 1:
                    return "I will face any challenge to win the approval of my family. ";
                case 2:
                    return "My house’s alliance with another noble family must be sustained at all costs. ";
                case 3:
                    return "Nothing is more important than the other members of my family. ";
                case 4:
                    return "I am in love with the heir of a family that my family despises. ";
                case 5:
                    return "My loyalty to my sovereign is unwavering. ";
                case 6:
                    return "The common folk must see me as a hero of the people. ";
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
                    return "I secretly believe that everyone is beneath me. ";
                case 2:
                    return "I hide a truly scandalous secret that could ruin my family forever. ";
                case 3:
                    return "I too often hear veiled insults and threats in every word addressed to me, and I’m quick to anger. ";
                case 4:
                    return "I have an insatiable desire for carnal pleasures. ";
                case 5:
                    return "In fact, the world does revolve around me. ";
                case 6:
                    return "By my words and actions, I often bring shame to my family. ";
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
                    return "Respect. Respect is due to me because of my position, but all people regardless of station deserve to be treated with dignity.";
                case 2:
                    character.Personality.Alignment.Law = Options.Law.Lawful;
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Responsibility. It is my duty to respect the authority of those above me, just as those below me must respect mine.";
                case 3:
                    character.Personality.Alignment.Law = Options.Law.Chaotic;
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Independence. I must prove that I can handle myself without the coddling of my family.";
                case 4:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Options.Order.Evil;
                    return "Power. If I can attain more power, no one will tell me what to do.";
                case 5:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Options.Order.Neutral;
                    return "Family. Blood runs thicker than water. ";
                case 6:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Options.Order.Good;
                    return "Noble Obligation. It is my duty to protect and care for the people beneath me.";
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
                    return "My eloquent flattery makes everyone I talk to feel like the most wonderful and important person in the world. ";
                case 2:
                    return "The common folk love me for my kindness and generosity. ";
                case 3:
                    return "No one could doubt by looking at my regal bearing that I am a cut above the unwashed masses.  ";
                case 4:
                    return "I take great pains to always look my best and follow the latest fashions. ";
                case 5:
                    return "I don’t like to get my hands dirty, and I won’t be caught dead in unsuitable accommodations. ";
                case 6:
                    return "Despite my noble birth, I do not place myself above other folk. We all have the same blood. ";
                case 7:
                    return "My favor, once lost, is lost forever. ";
                case 8:
                    return "If you do me an injury, I will crush you, ruin your name, and salt your fields. dd";
                default:
                    return "";
            }
        }
    }
}
