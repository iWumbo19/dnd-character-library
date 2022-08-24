using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Backgrounds
{
    public class Outlander
    {
        public void Build(Character character)
        {
            character.Personality.Bond = ChooseBond();
            character.Personality.Flaw = ChooseFlaw();
            character.Personality.Ideal = ChooseIdeal(character);
            character.Personality.Trait = ChooseTrait();
            character.AddProficiency(Options.Skill.Athletics);
            character.AddProficiency(Options.Skill.Survival);
            character.AddRandomProf(Utilities.GetEnumList<Instrument>());
            character.AddRandomProf(Utilities.GetEnumList<StandardLanguage>());
        }

        public string ChooseBond()
        {
            int roll = RNG.Roll(6);
            switch (roll)
            {
                case 1:
                    return "My family, clan, or tribe is the most important thing in my life, even when they are far from me. ";
                case 2:
                    return "An injury to the unspoiled wilderness of my home is an injury to me. ";
                case 3:
                    return "I will bring terrible wrath down on the evildoers who destroyed my homeland. ";
                case 4:
                    return "I am the last of my tribe, and it is up to me to ensure their names enter legend. ";
                case 5:
                    return "I suffer awful visions of a coming disaster and will do anything to prevent it. ";
                case 6:
                    return "It is my duty to provide children to sustain my tribe. ";
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
                    return "I am too enamored of ale, wine, and other intoxicants. ";
                case 2:
                    return "There’s no room for caution in a life lived to the fullest. ";
                case 3:
                    return "I remember every insult I’ve received and nurse a silent resentment toward anyone who’s ever wronged me. ";
                case 4:
                    return "I am slow to trust members of other races, tribes, and societies. ";
                case 5:
                    return "Violence is my answer to almost any challenge. ";
                case 6:
                    return "Don’t expect me to save those who can’t save themselves. It is nature’s way that the strong thrive and the weak perish. ";
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
                    character.Personality.Alignment.Law = Options.Law.Chaotic;
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Change. Life is like the seasons, in constant change, and we must change with it.";
                case 2:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Options.Order.Good;
                    return "Greater Good. It is each person’s responsibility to make the most happiness for the whole tribe. ";
                case 3:
                    character.Personality.Alignment.Law = Options.Law.Lawful;
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Honor. If I dishonor myself, I dishonor my whole clan.";
                case 4:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Options.Order.Evil;
                    return "Might. The strongest are meant to rule.";
                case 5:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Options.Order.Neutral;
                    return "Nature. The natural world is more important than all the constructs of civilization.";
                case 6:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Glory. I must earn glory in battle, for myself and my clan.";
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
                    return "I’m driven by a wanderlust that led me away from home. ";
                case 2:
                    return "I watch over my friends as if they were a litter of newborn pups. ";
                case 3:
                    return "I once ran twenty-five miles without stopping to warn to my clan of an approaching orc horde. I’d do it again if I had to. ";
                case 4:
                    return "I have a lesson for every situation, drawn from observing nature. ";
                case 5:
                    return "I place no stock in wealthy or well-mannered folk. Money and manners won’t save you from a hungry owlbear. ";
                case 6:
                    return "I’m always picking things up, absently fiddling with them, and sometimes accidentally breaking them. ";
                case 7:
                    return "I feel far more comfortable around animals than people. ";
                case 8:
                    return "I was, in fact, raised by wolves. ";
                default:
                    return "";
            }
        }
    }
}
