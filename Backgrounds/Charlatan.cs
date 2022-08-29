using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;

namespace DnDCharacterCreator.Backgrounds
{
    internal class Charlatan : IBackground
    {
        public void Build(Character character)
        {
            character.Personality.Trait = ChooseTrait();
            character.Personality.Bond = ChooseBond();
            character.Personality.Ideal = ChooseIdeal(character);
            character.Personality.Flaw = ChooseFlaw();
            character.AddProficiency(Options.Skill.Deception);
            character.AddProficiency(Options.Skill.SleightOfHand);
            character.AddProficiency(Options.ArtisanTool.DisguiseKit);
            character.AddProficiency(Options.ArtisanTool.ForgeryKit);
        }

        public string ChooseBond()
        {
            int roll = RNG.Roll(6);
            switch (roll)
            {
                case 1:
                    return "I fleeced the wrong person and must work to ensure that this individual never crosses paths with me or those I care about.  ";
                case 2:
                    return "I owe everything to my mentor—a horrible person who’s probably rotting in jail somewhere. ";
                case 3:
                    return "Somewhere out there, I have a child who doesn’t know me. I’m making the world better for him or her. ";
                case 4:
                    return "I come from a noble family, and one day I’ll reclaim my lands and title from those who stole them from me. ";
                case 5:
                    return "A powerful person killed someone I love. Some day soon, I’ll have my revenge. ";
                case 6:
                    return "I swindled and ruined a person who didn’t deserve it. I seek to atone for my misdeeds but might never be able to forgive myself";
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
                    return "I can’t resist a pretty face.  ";
                case 2:
                    return "I’m always in debt. I spend my ill-gotten gains on decadent luxuries faster than I bring them in...  ";
                case 3:
                    return "I’m convinced that no one could ever fool me the way I fool others.  ";
                case 4:
                    return "I’m too greedy for my own good. I can’t resist taking a risk if there’s money involved.  ";
                case 5:
                    return "I can’t resist swindling people who are more powerful than me. ";
                case 6:
                    return "I hate to admit it and will hate myself for it, but I’ll run and preserve my own hide if the going gets tough. ";
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
                    return "Independence. I am a free spirit—no one tells me what to do";
                case 2:
                    character.Personality.Alignment.Law = Options.Law.Lawful;
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Fairness. I never target people who can’t afford to lose a few coins.";
                case 3:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Options.Order.Good;
                    return "Charity. I distribute the money I acquire to the people who really need it.";
                case 4:
                    character.Personality.Alignment.Law = Options.Law.Chaotic;
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Creativity. I never run the same con twice.";
                case 5:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Options.Order.Good;
                    return "Friendship. Material goods come and go. Bonds of friendship last forever.";
                case 6:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Aspiration. I’m determined to make something of myself";
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
                    return "I fall in and out of love easily, and am always pursuing someone. ";
                case 2:
                    return "I have a joke for every occasion, especially occasions where humor is inappropriate.  ";
                case 3:
                    return "Flattery is my preferred trick for getting what I want.  ";
                case 4:
                    return "I’m a born gambler who can’t resist taking a risk for a potential payoff. ";
                case 5:
                    return "I lie about almost everything, even when there’s no good reason to. ";
                case 6:
                    return "Sarcasm and insults are my weapons of choice.  ";
                case 7:
                    return "I keep multiple holy symbols on me and invoke whatever deity might come in useful at any given moment.  ";
                case 8:
                    return "I pocket anything I see that might have some value.  ";
                default:
                    return "";
            }
        }
        public string GetBackgroundName() => Options.Background.Charlatan.ToString();

    }
}
