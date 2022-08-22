using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Backgrounds
{
    public class Acolyte : IBackground
    {
        public void Build(Character character)
        {
            character.Personality.Trait = ChooseTrait();
            character.Personality.Bond = ChooseBond();
            character.Personality.Ideal = ChooseIdeal(character);
            character.Personality.Flaw = ChooseFlaw();
            character.AddProficiency(Options.Skill.Insight);
            character.AddProficiency(Options.Skill.Religion);
            character.AddRandomProf(Utilities.GetEnumList<StandardLanguage>());
            character.AddRandomProf(Utilities.GetEnumList<ExoticLanguage>());
        }

        public string ChooseBond()
        {
            int roll = RNG.Roll(6);
            switch (roll)
            {
                case 1:
                    return "I would die to recover an ancient relic of my faith that was lost long ago. ";
                case 2:
                    return "I will someday get revenge on the corrupt temple hierarchy who branded me a heretic. ";
                case 3:
                    return "I owe my life to the priest who took me in when my parents died. ";
                case 4:
                    return "Everything I do is for the common people. ";
                case 5:
                    return "I will do anything to protect the temple where I served. ";
                case 6:
                    return "I seek to preserve a sacred text that my enemies consider heretical and seek to destroy. ";
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
                    return "I judge others harshly, and myself even more severely. ";
                case 2:
                    return "I put too much trust in those who wield power within my temple’s hierarchy. ";
                case 3:
                    return "My piety sometimes leads me to blindly trust those that profess faith in my god. ";
                case 4:
                    return "I am inflexible in my thinking. ";
                case 5:
                    return "I am suspicious of strangers and expect the worst of them. ";
                case 6:
                    return "Once I pick a goal, I become obsessed with it to the detriment of everything else in my life. ";
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
                    return "Tradition. The ancient traditions of worship and sacrifice must be preserved and upheld";
                case 2:
                    character.Personality.Alignment.Order = Options.Order.Good;
                    return "Charity. I always try to help those in need, no matter what the personal cost.";
                case 3:
                    character.Personality.Alignment.Law = Options.Law.Chaotic;
                    return "Change. We must help bring about the changes the gods are constantly working in the world.";
                case 4:
                    character.Personality.Alignment.Law = Options.Law.Lawful;
                    return "Power. I hope to one day rise to the top of my faith’s religious hierarchy.";
                case 5:
                    character.Personality.Alignment.Law = Options.Law.Lawful;
                    return "Faith. I trust that my deity will guide my actions. I have faith that if I work hard, things will go well.";
                case 6:
                    return "Aspiration. I seek to prove myself worthy of my god’s favor by matching my actions against his or her teachings.";
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
                    return "I idolize a particular hero of my faith, and constantly refer to that person’s deeds and example.";
                case 2:
                    return "I can find common ground between the fiercest enemies, empathizing with them and always working toward peace. ";
                case 3:
                    return "I see omens in every event and action. The gods try to speak to us, we just need to listen. ";
                case 4:
                    return "Nothing can shake my optimistic attitude. ";
                case 5:
                    return "I quote (or misquote) sacred texts and proverbs in almost every situation. ";
                case 6:
                    return "I am tolerant (or intolerant) of other faiths and respect (or condemn) the worship of other gods. ";
                case 7:
                    return "I’ve enjoyed fine food, drink, and high society among my temple’s elite. Rough living grates on me. ";
                case 8:
                    return "I’ve spent so long in the temple that I have little practical experience dealing with people in the outside world. ";
                default:
                    return "";
            }
        }

    }
}
