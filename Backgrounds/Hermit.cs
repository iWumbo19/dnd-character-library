using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Backgrounds
{
    public class Hermit : IBackground
    {
        public void Build(Character character)
        {
            character.Personality.Bond = ChooseBond();
            character.Personality.Flaw = ChooseFlaw();
            character.Personality.Ideal = ChooseIdeal(character);
            character.Personality.Trait = ChooseTrait();
            character.AddProficiency(Options.Skill.Medicine);
            character.AddProficiency(Options.Skill.Religion);
            character.AddProficiency(ArtisanTool.HerbalismKit);
            character.AddRandomProf(Utilities.GetEnumList<StandardLanguage>());
        }

        public string ChooseBond()
        {
            int roll = RNG.Roll(6);
            switch (roll)
            {
                case 1:
                    return "Nothing is more important than the other members of my hermitage, order, or association. ";
                case 2:
                    return "I entered seclusion to hide from the ones who might still be hunting me. I must someday confront them. ";
                case 3:
                    return "I’m still seeking the enlightenment I pursued in my seclusion, and it still eludes me. ";
                case 4:
                    return "I entered seclusion because I loved someone I could not have. ";
                case 5:
                    return "Should my discovery come to light, it could bring ruin to the world. ";
                case 6:
                    return "My isolation gave me great insight into a great evil that only I can destroy. ";
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
                    return "Now that I’ve returned to the world, I enjoy its delights a little too much. ";
                case 2:
                    return "I harbor dark, bloodthirsty thoughts that my isolation and meditation failed to quell. ";
                case 3:
                    return "I am dogmatic in my thoughts and philosophy. ";
                case 4:
                    return "I let my need to win arguments overshadow friendships and harmony. ";
                case 5:
                    return "I’d risk too much to uncover a lost bit of knowledge. ";
                case 6:
                    return "I like keeping secrets and won’t share them with anyone. ";
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
                    return "Greater Good. My gifts are meant to be shared with all, not used for my own benefit.";
                case 2:
                    character.Personality.Alignment.Law = Options.Law.Lawful;
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Logic. Emotions must not cloud our sense of what is right and true, or our logical thinking.";
                case 3:
                    character.Personality.Alignment.Law = Options.Law.Chaotic;
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "Free Thinking. Inquiry and curiosity are the pillars of progress.";
                case 4:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Options.Order.Evil;
                    return "Power. Solitude and contemplation are paths toward mystical or magical power.";
                case 5:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = Options.Order.Neutral;
                    return "Live and Let Live. Meddling in the affairs of others only causes trouble.";
                case 6:
                    character.Personality.Alignment.Law = RNG.ReturnRandom<Law>();
                    character.Personality.Alignment.Order = RNG.ReturnRandom<Order>();
                    return "";
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
                    return "I’ve been isolated for so long that I rarely speak, preferring gestures and the occasional grunt. ";
                case 2:
                    return "I am utterly serene, even in the face of disaster. ";
                case 3:
                    return "The leader of my community had something wise to say on every topic, and I am eager to share that wisdom. ";
                case 4:
                    return "I feel tremendous empathy for all who suffer. ";
                case 5:
                    return "I’m oblivious to etiquette and social expectations. ";
                case 6:
                    return "I connect everything that happens to me to a grand, cosmic plan. ";
                case 7:
                    return "I often get lost in my own thoughts and contemplation, becoming oblivious to my surroundings. ";
                case 8:
                    return "I am working on a grand philosophical theory and love sharing my ideas. ";
                default:
                    return "";
            }
        }
        public string GetBackgroundName() => Options.Background.Hermit.ToString();

    }
}
