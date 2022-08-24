using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Backgrounds
{
    public class Sage : IBackground
    {
        public void Build(Character character)
        {
            character.Personality.Bond = ChooseBond();
            character.Personality.Flaw = ChooseFlaw();
            character.Personality.Ideal = ChooseIdeal(character);
            character.Personality.Trait = ChooseTrait();
            character.AddProficiency(Options.Skill.Arcana);
            character.AddProficiency(Options.Skill.History);
            character.AddRandomProf(Utilities.GetEnumList<StandardLanguage>());
            character.AddRandomProf(Utilities.GetEnumList<StandardLanguage>());
        }

        public string ChooseBond()
        {
            int roll = RNG.Roll(6);
            switch (roll)
            {
                case 1:
                    return "It is my duty to protect my students. ";
                case 2:
                    return "I have an ancient text that holds terrible secrets that must not fall into the wrong hands. ";
                case 3:
                    return "I work to preserve a library, university, scriptorium, or monastery. ";
                case 4:
                    return "My life’s work is a series of tomes related to a specific field of lore. ";
                case 5:
                    return "I’ve been searching my whole life for the answer to a certain question. ";
                case 6:
                    return "I sold my soul for knowledge. I hope to do great deeds and win it back. ";
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
                    return "I am easily distracted by the promise of information. ";
                case 2:
                    return "Most people scream and run when they see a demon. I stop and take notes on its anatomy. ";
                case 3:
                    return "Unlocking an ancient mystery is worth the price of a civilization. ";
                case 4:
                    return "I overlook obvious solutions in favor of complicated ones. ";
                case 5:
                    return "I speak without really thinking through my words, invariably insulting others. ";
                case 6:
                    return "I can’t keep a secret to save my life, or anyone else’s. ";
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
                    character.Personality.Alignment.Order = Order.Neutral;
                    return "Knowledge. The path to power and self-improvement is through knowledge.";
                case 2:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Order.Good;
                    return "Beauty. What is beautiful points us beyond itself toward what is true.";
                case 3:
                    character.Personality.Alignment.Law = Law.Lawful;
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Logic. Emotions must not cloud our logical thinking.";
                case 4:
                    character.Personality.Alignment.Law = Law.Chaotic;
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "No Limits. Nothing should fetter the infinite possibility inherent in all existence.";
                case 5:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Order.Evil;
                    return "Power. Knowledge is the path to power and domination. ";
                case 6:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Self-Improvement. The goal of a life of study is the betterment of oneself.";
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
                    return "I use polysyllabic words that convey the impression of great erudition. ";
                case 2:
                    return "I’ve read every book in the world’s greatest libraries—or I like to boast that I have. ";
                case 3:
                    return "I’m used to helping out those who aren’t as smart as I am, and I patiently explain anything and everything to others. ";
                case 4:
                    return "There’s nothing I like more than a good mystery. ";
                case 5:
                    return "I’m willing to listen to every side of an argument before I make my own judgment. ";
                case 6:
                    return "I … speak … slowly … when talking … to idiots, … which … almost … everyone … is … compared … to me. ";
                case 7:
                    return "I am horribly, horribly awkward in social situations. ";
                case 8:
                    return "I’m convinced that people are always trying to steal my secrets. ";
                default:
                    return "";
            }
        }
    }
}
