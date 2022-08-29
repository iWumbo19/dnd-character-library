using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Backgrounds
{
    public class Urchin : IBackground
    {
        public void Build(Character character)
        {
            character.Personality.Bond = ChooseBond();
            character.Personality.Flaw = ChooseFlaw();
            character.Personality.Ideal = ChooseIdeal(character);
            character.Personality.Trait = ChooseTrait();
            character.AddProficiency(Skill.SleightOfHand);
            character.AddProficiency(Skill.Stealth);
            character.AddProficiency(ArtisanTool.DisguiseKit);
            character.AddProficiency(ArtisanTool.ThievesTools);
        }

        public string ChooseBond()
        {
            int roll = RNG.Roll(6);
            switch (roll)
            {
                case 1:
                    return "My town or city is my home, and I’ll fight to defend it. ";
                case 2:
                    return "I sponsor an orphanage to keep others from enduring what I was forced to endure. ";
                case 3:
                    return "I owe my survival to another urchin who taught me to live on the streets. ";
                case 4:
                    return "I owe a debt I can never repay to the person who took pity on me. ";
                case 5:
                    return "I escaped my life of poverty by robbing an important person, and I’m wanted for it. ";
                case 6:
                    return "No one else should have to endure the hardships I’ve been through. ";
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
                    return "If I’m outnumbered, I will run away from a fight. ";
                case 2:
                    return "Gold seems like a lot of money to me, and I’ll do just about anything for more of it. ";
                case 3:
                    return "I will never fully trust anyone other than myself. ";
                case 4:
                    return "I’d rather kill someone in their sleep than fight fair. ";
                case 5:
                    return "It’s not stealing if I need it more than someone else. ";
                case 6:
                    return "People who can’t take care of themselves get what they deserve. ";
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
                    character.Personality.Alignment.Order = Order.Good;
                    return "Respect. All people, rich or poor, deserve respect.";
                case 2:
                    character.Personality.Alignment.Law = Law.Lawful;
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Community. We have to take care of each other, because no one else is going to do it.";
                case 3:
                    character.Personality.Alignment.Law = Law.Chaotic;
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Change. The low are lifted up, and the high and mighty are brought down. Change is the nature of things.";
                case 4:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Order.Evil;
                    return "Retribution. The rich need to be shown what life and death are like in the gutters";
                case 5:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Order.Neutral;
                    return "People. I help the people who help me — that’s what keeps us alive. ";
                case 6:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Aspiration. I’m going to prove that I’m worthy of a better life. ";
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
                    return "";
                case 2:
                    return "";
                case 3:
                    return "";
                case 4:
                    return "";
                case 5:
                    return "";
                case 6:
                    return "";
                case 7:
                    return "";
                case 8:
                    return "";
                default:
                    return "";
            }
        }
        public string GetBackgroundName() => Options.Background.Urchin.ToString();

    }
}
