using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Backgrounds
{
    internal class Criminal : IBackground
    {

        public void Build(Character character)
        {
            character.Personality.Bond = ChooseBond();
            character.Personality.Flaw = ChooseFlaw();
            character.Personality.Ideal = ChooseIdeal(character);
            character.Personality.Trait = ChooseTrait();
            character.AddProficiency(Options.Skill.Deception);
            character.AddProficiency(Options.Skill.Stealth);
            character.AddProficiency(Options.ArtisanTool.ThievesTools);
        }

        public string ChooseBond()
        {
            int roll = RNG.Roll(6);
            switch (roll)
            {
                case 1:
                    return "I’m trying to pay off an old debt I owe to a generous benefactor. ";
                case 2:
                    return "My ill-gotten gains go to support my family. ";
                case 3:
                    return "Something important was taken from me, and I aim to steal it back. ";
                case 4:
                    return "I will become the greatest thief that ever lived. ";
                case 5:
                    return "I’m guilty of a terrible crime. I hope I can redeem myself for it. ";
                case 6:
                    return "Someone I loved died because of a mistake I made. That will never happen again. ";
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
                    return "When I see something valuable, I can’t think about anything but how to steal it. ";
                case 2:
                    return "When faced with a choice between money and my friends, I usually choose the money. ";
                case 3:
                    return "If there’s a plan, I’ll forget it. If I don’t forget it, I’ll ignore it. ";
                case 4:
                    return "I have a “tell” that reveals when I’m lying. ";
                case 5:
                    return "I turn tail and run when things look bad. ";
                case 6:
                    return "An innocent person is in prison for a crime that I committed. I’m okay with that. ";
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
                    character.Personality.Alignment.Law = Options.Law.Lawful;
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Honor. I don’t steal from others in the trade.";
                case 2:
                    character.Personality.Alignment.Law = Options.Law.Chaotic;
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Freedom. Chains are meant to be broken, as are those who would forge them.";
                case 3:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Options.Order.Good;
                    return "Charity. I steal from the wealthy so that I can help people in need.";
                case 4:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Options.Order.Evil;
                    return "Greed. I will do whatever it takes to become wealthy.";
                case 5:
                    character.Personality.Alignment.Law = Options.Law.Neutral;
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "People. I’m loyal to my friends, not to any ideals, and everyone else can take a trip down the Styx for all I care.";
                case 6:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Redemption. There’s a spark of good in everyone. ";
                default:
                    return "";
            }
        }

        public string ChooseTrait()
        {
            int roll = RNG.Roll(8);
            switch (roll)
            {
                case 1:
                    return "I always have a plan for what to do when things go wrong. ";
                case 2:
                    return "I am always calm, no matter what the situation. I never raise my voice or let my emotions control me. ";
                case 3:
                    return "The first thing I do in a new place is note the locations of everything valuable—or where such things could be hidden. ";
                case 4:
                    return "I would rather make a new friend than a new enemy. ";
                case 5:
                    return "I am incredibly slow to trust. Those who seem the fairest often have the most to hide.";
                case 6:
                    return "I don’t pay attention to the risks in a situation. Never tell me the odds.";
                case 7:
                    return "The best way to get me to do something is to tell me I can’t do it.";
                case 8:
                    return "I blow up at the slightest insult.";
                default:
                    return "";
            }
        }
    }
}
