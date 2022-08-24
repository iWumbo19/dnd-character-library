using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Backgrounds
{
    public class FolkHero : IBackground
    {
        public void Build(Character character)
        {
            character.Personality.Bond = ChooseBond();
            character.Personality.Flaw = ChooseFlaw();
            character.Personality.Ideal = ChooseIdeal(character);
            character.Personality.Trait = ChooseTrait();
            character.AddProficiency(Skill.AnimalHandling);
            character.AddProficiency(Skill.Survival);
            character.AddRandomProf(Utilities.GetEnumList<ArtisanTool>());
        }

        public string ChooseBond()
        {
            int roll = RNG.Roll(6);
            switch (roll)
            {
                case 1:
                    return "I have a family, but I have no idea where they are. One day, I hope to see them again. ";
                case 2:
                    return "I worked the land, I love the land, and I will protect the land. ";
                case 3:
                    return "A proud noble once gave me a horrible beating, and I will take my revenge on any bully I encounter. ";
                case 4:
                    return "My tools are symbols of my past life, and I carry them so that I will never forget my roots. ";
                case 5:
                    return "I protect those who cannot protect themselves. ";
                case 6:
                    return "I wish my childhood sweetheart had come with me to pursue my destiny. ";
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
                    return "The tyrant who rules my land will stop at nothing to see me killed. ";
                case 2:
                    return "I’m convinced of the significance of my destiny, and blind to my shortcomings and the risk of failure. ";
                case 3:
                    return "The people who knew me when I was young know my shameful secret, so I can never go home again. ";
                case 4:
                    return "I have a weakness for the vices of the city, especially hard drink. ";
                case 5:
                    return "Secretly, I believe that things would be better if I were a tyrant lording over the land. ";
                case 6:
                    return "I have trouble trusting in my allies. ";
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
                    return "Respect. People deserve to be treated with dignity and respect.";
                case 2:
                    character.Personality.Alignment.Law = Options.Law.Lawful;
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Fairness. No one should get preferential treatment before the law, and no one is above the law.";
                case 3:
                    character.Personality.Alignment.Law = Options.Law.Chaotic;
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Freedom. Tyrants must not be allowed to oppress the people.";
                case 4:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Options.Order.Evil;
                    return "Might. If I become strong, I can take what I want—what I deserve.";
                case 5:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Options.Order.Neutral;
                    return "Sincerity. There’s no good in pretending to be something I’m not.";
                case 6:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Destiny. Nothing and no one can steer me away from my higher calling.";
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
                    return "I judge people by their actions, not their words. ";
                case 2:
                    return "If someone is in trouble, I’m always ready to lend help. ";
                case 3:
                    return "When I set my mind to something, I follow through no matter what gets in my way. ";
                case 4:
                    return "I have a strong sense of fair play and always try to find the most equitable solution to arguments. ";
                case 5:
                    return "I’m confident in my own abilities and do what I can to instill confidence in others. ";
                case 6:
                    return "Thinking is for other people. I prefer action. ";
                case 7:
                    return "I misuse long words in an attempt to sound smarter. ";
                case 8:
                    return "I get bored easily. When am I going to get on with my destiny? ";
                default:
                    return "";
            }
        }
    }
}
