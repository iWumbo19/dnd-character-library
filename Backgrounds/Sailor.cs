using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;

namespace DnDCharacterCreator.Backgrounds
{
    public class Sailor : IBackground
    {
        public void Build(Character character)
        {
            character.Personality.Bond = ChooseBond();
            character.Personality.Flaw = ChooseFlaw();
            character.Personality.Ideal = ChooseIdeal(character);
            character.Personality.Trait = ChooseTrait();
            character.AddProficiency(Skill.Athletics);
            character.AddProficiency(Skill.Perception);
            character.AddProficiency(ArtisanTool.NavigatorsTools);
        }

        public string ChooseBond()
        {
            int roll = RNG.Roll(6);
            switch (roll)
            {
                case 1:
                    return "I’m loyal to my captain first, everything else second. ";
                case 2:
                    return "The ship is most important — crewmates and captains come and go. ";
                case 3:
                    return "I’ll always remember my first ship. ";
                case 4:
                    return "In a harbor town, I have a paramour whose eyes nearly stole me from the sea. ";
                case 5:
                    return "I was cheated out of my fair share of the profits, and I want to get my due. ";
                case 6:
                    return "Ruthless pirates murdered my captain and crewmates, plundered our ship, and left me to die. Vengeance will be mine. ";
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
                    return "I follow orders, even if I think they’re wrong. ";
                case 2:
                    return "I’ll say anything to avoid having to do extra work. ";
                case 3:
                    return "Once someone questions my courage, I never back down no matter how dangerous the situation. ";
                case 4:
                    return "Once I start drinking, it’s hard for me to stop. ";
                case 5:
                    return "I can’t help but pocket loose coins and other trinkets I come across. ";
                case 6:
                    return "My pride will probably lead to my destruction. ";
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
                    return "Respect. The thing that keeps a ship together is mutual respect between captain and crew.";
                case 2:
                    character.Personality.Alignment.Law = Law.Lawful;
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Fairness. We all do the work, so we all share in the rewards.";
                case 3:
                    character.Personality.Alignment.Law = Law.Chaotic;
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Freedom. The sea is freedom — the freedom to go anywhere and do anything.";
                case 4:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Order.Evil;
                    return "Mastery. I’m a predator, and the other ships on the sea are my prey.";
                case 5:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Order.Neutral;
                    return "People. I’m committed to my crewmates, not to ideals.";
                case 6:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "";
                default:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Aspiration. Someday I’ll own my own ship and chart my own destiny.";
            }
        }

        public string ChooseTrait()
        {
            int roll = RNG.Roll(8);
            switch (roll)
            {
                case 1:
                    return "My friends know they can rely on me, no matter what. ";
                case 2:
                    return "I work hard so that I can play hard when the work is done. ";
                case 3:
                    return "I enjoy sailing into new ports and making new friends over a flagon of ale. ";
                case 4:
                    return "I stretch the truth for the sake of a good story. ";
                case 5:
                    return "To me, a tavern brawl is a nice way to get to know a new city. ";
                case 6:
                    return "I never pass up a friendly wager. ";
                case 7:
                    return "My language is as foul as an otyugh nest. ";
                case 8:
                    return "I like a job well done, especially if I can convince someone else to do it. ";
                default:
                    return "";
            }
        }
    }
}
