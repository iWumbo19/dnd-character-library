using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Backgrounds
{
    public class Soldier : IBackground
    {
        public void Build(Character character)
        {
            character.Personality.Bond = ChooseBond();
            character.Personality.Flaw = ChooseFlaw();
            character.Personality.Ideal = ChooseIdeal(character);
            character.Personality.Trait = ChooseTrait();
            character.AddProficiency(Skill.Athletics);
            character.AddProficiency(Skill.Intimidation);
            character.AddRandomProf(Utilities.GamingTools);
        }

        public string ChooseBond()
        {
            int roll = RNG.Roll(6);
            switch (roll)
            {
                case 1:
                    return "I would still lay down my life for the people I served with. ";
                case 2:
                    return "Someone saved my life on the battlefield. To this day, I will never leave a friend behind.";
                case 3:
                    return "My honor is my life. ";
                case 4:
                    return "I’ll never forget the crushing defeat my company suffered or the enemies who dealt it. ";
                case 5:
                    return "Those who fight beside me are those worth dying for. ";
                case 6:
                    return "I fight for those who cannot fight for themselves. ";
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
                    return "The monstrous enemy we faced in battle still leaves me quivering with fear. ";
                case 2:
                    return "I have little respect for anyone who is not a proven warrior. ";
                case 3:
                    return "I made a terrible mistake in battle that cost many lives—and I would do anything to keep that mistake secret. ";
                case 4:
                    return "My hatred of my enemies is blind and unreasoning. ";
                case 5:
                    return "I obey the law, even if the law causes misery. ";
                case 6:
                    return "I’d rather eat my armor than admit when I’m wrong. ";
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
                    return "Greater Good. Our lot is to lay down our lives in defense of others.";
                case 2:
                    character.Personality.Alignment.Law = Law.Lawful;
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Responsibility. I do what I must and obey just authority.";
                case 3:
                    character.Personality.Alignment.Law = Law.Chaotic;
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Independence. When people follow orders blindly, they embrace a kind of tyranny.";
                case 4:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Order.Evil;
                    return "Might. In life as in war, the stronger force wins. ";
                case 5:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Order.Neutral;
                    return "Live and Let Live. Ideals aren’t worth killing over or going to war for.";
                case 6:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Nation. My city, nation, or people are all that matter.";
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
                    return "I’m always polite and respectful. ";
                case 2:
                    return "I’m haunted by memories of war. I can’t get the images of violence out of my mind. ";
                case 3:
                    return "I’ve lost too many friends, and I’m slow to make new ones. ";
                case 4:
                    return "I’m full of inspiring and cautionary tales from my military experience relevant to almost every combat situation. ";
                case 5:
                    return "I can stare down a hell hound without flinching. ";
                case 6:
                    return "I enjoy being strong and like breaking things. ";
                case 7:
                    return "I have a crude sense of humor. ";
                case 8:
                    return "I face problems head-on. A simple, direct solution is the best path to success. ";
                default:
                    return "";
            }
        }
        public string GetBackgroundName() => Options.Background.Soldier.ToString();

    }
}
