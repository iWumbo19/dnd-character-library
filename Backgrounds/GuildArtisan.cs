using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Backgrounds
{
    public class GuildArtisan : IBackground
    {
        public void Build(Character character)
        {
            character.Personality.Bond = ChooseBond();
            character.Personality.Flaw = ChooseFlaw();
            character.Personality.Ideal = ChooseIdeal(character);
            character.Personality.Trait = ChooseTrait();
            character.AddProficiency(Skill.Insight);
            character.AddProficiency(Skill.Persuasion);
            character.AddRandomProf(Utilities.GetEnumList<ArtisanTool>());
        }

        public string ChooseBond()
        {
            int roll = RNG.Roll(6);
            switch (roll)
            {
                case 1:
                    return "The workshop where I learned my trade is the most important place in the world to me. ";
                case 2:
                    return "I created a great work for someone, and then found them unworthy to receive it. I’m still looking for someone worthy. ";
                case 3:
                    return "I owe my guild a great debt for forging me into the person I am today. ";
                case 4:
                    return "I pursue wealth to secure someone’s love. ";
                case 5:
                    return "One day I will return to my guild and prove that I am the greatest artisan of them all. ";
                case 6:
                    return "I will get revenge on the evil forces that destroyed my place of business and ruined my livelihood. ";
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
                    return "I’ll do anything to get my hands on something rare or priceless. ";
                case 2:
                    return "I’m quick to assume that someone is trying to cheat me. ";
                case 3:
                    return "No one must ever learn that I once stole money from guild coffers.";
                case 4:
                    return "I’m never satisfied with what I have — I always want more. ";
                case 5:
                    return "I would kill to acquire a noble title. ";
                case 6:
                    return "I’m horribly jealous of anyone who can outshine my handiwork. Everywhere I go, I’m surrounded by rivals. ";
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
                    return "Community. It is the duty of all civilized people to strengthen the bonds of community and the security of civilization";
                case 2:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Options.Order.Good;
                    return "Generosity. My talents were given to me so that I could use them to benefit the world.";
                case 3:
                    character.Personality.Alignment.Law = Options.Law.Chaotic;
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Freedom. Everyone should be free to pursue his or her own livelihood";
                case 4:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Options.Order.Evil;
                    return "Greed. I’m only in it for the money.";
                case 5:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Options.Order.Neutral;
                    return "People. I’m committed to the people I care about, not to ideals. ";
                case 6:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Aspiration. I work hard to be the best there is at my craft. ";
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
                    return "I believe that anything worth doing is worth doing right. I can’t help it — I’m a perfectionist. ";
                case 2:
                    return "I’m a snob who looks down on those who can’t appreciate fine art. ";
                case 3:
                    return "I always want to know how things work and what makes people tick. ";
                case 4:
                    return "I’m full of witty aphorisms and have a proverb for every occasion. ";
                case 5:
                    return "I’m rude to people who lack my commitment to hard work and fair play. ";
                case 6:
                    return "I like to talk at length about my profession. ";
                case 7:
                    return "I don’t part with my money easily and will haggle tirelessly to get the best deal possible. ";
                case 8:
                    return "I’m well known for my work, and I want to make sure everyone appreciates it. I’m always taken aback when people haven’t heard of me. ";
                default:
                    return "";
            }
        }
        public string GetBackgroundName() => "Guild Artisan";

    }
}
