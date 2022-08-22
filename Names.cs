using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnDCharacterCreator
{
    internal static class Names
    {
        // Dwarf Names
        private static readonly List<string> dwarfMale = new List<string>()
        {
            {"Adrik" },
            {"Alberich" },
            {"Baern" },
            {"Barendd" },
            {"Brottor" },
            {"Bruenor" },
            {"Dain" },
            {"Darrak" },
            {"Delg" },
            {"Eberk" },
            {"Einkil" },
            {"Fargrim" },
            {"Flint" },
            {"Gardain" },
            {"Harbek" },
            {"Kildrak" },
            {"Morgran" },
            {"Orsik" },
            {"Oskar" },
            {"Rangrim" },
            {"Rurik" },
            {"Taklinn" },
            {"Thoradin" },
            {"Thorin" },
            {"Tordek" },
            {"Traubon" },
            {"Travok" },
            {"Ulfgar" },
            {"Viet" },
            {"Vondal" }
        };
        private static readonly List<string> dwarfFemale = new List<string>()
        {
            { "Amber" },
            { "Artin" },
            { "Audhild" },
            { "Bardryn" },
            { "Dagnal" },
            { "Diesa" },
            { "Eldeth" },
            { "Falkrunn" },
            { "Finellen" },
            { "Gunnloda" },
            { "Gurdis" },
            { "Helja" },
            { "Hlin" },
            { "Kathra" },
            { "Kristryd" },
            { "Ilde" },
            { "Liftrasa" },
            { "Mardred" },
            { "Riswynn" },
            { "Sannl" },
            { "Torbera" },
            { "Torgga" },
            { "Vistra" }
        };
        private static readonly List<string> dwarfClan = new List<string>()
        {
            { "Balderk" },
            { "Battlehammer" },
            { "Brawnanvil" },
            { "Dankil" },
            { "Fireforge" },
            { "Frostbeard" },
            { "Gorunn" },
            { "Holderhek" },
            { "Ironfist" },
            { "Loderr" },
            { "Lutgehr" },
            { "Rumnaheim" },
            { "Strakeln" },
            { "Torunn" },
            { "Ungart" }
        };

        // Elf Names
        private static readonly List<string> elfMale = new List<string>()
        {
            {"Adran" },
            {"Aelar" },
            {"Aramil" },
            {"Arannis" },
            {"Aust" },
            {"Beiro" },
            {"Berrian" },
            {"Carric" },
            {"Erdan" },
            {"Galinndan" },
            {"Hadarai" },
            {"Heian" },
            {"Himo" },
            {"Immeral" },
            {"Ivellios" },
            {"Laucian" },
            {"Mindartis" },
            {"Paelias" },
            {"Peren" },
            {"Quarion" },
            {"Riardon" },
            {"Rolen" },
            {"Soveliss" },
            {"Thamior" },
            {"Tharivol" },
            {"Theren" },
            {"Varis" }
        };
        private static readonly List<string> elfFemale = new List<string>()
        {
            {"Adrie" },
            {"Althaea" },
            {"Anastrianna" },
            {"Andraste" },
            {"Antinua" },
            {"Bethrynna" },
            {"Birel" },
            {"Caelynn" },
            {"Drusilia" },
            {"Enna" },
            {"Felosial" },
            {"Ielenia" },
            {"Jelenneth" },
            {"Keyleth" },
            {"Leshanna" },
            {"Lia" },
            {"Meriele" },
            {"Mialee" },
            {"Naivara" },
            {"Quelenna" },
            {"Quilathe" },
            {"Sariel" },
            {"Shanairra" },
            {"Shava" },
            {"Silaqui" },
            {"Theirastra" },
            {"Thia" },
            {"Vadania" },
            {"Valanthe" },
            {"Xanaphia" }
        };
        private static readonly List<string> elfFamily = new List<string>()
        {
            {"Amakiir (Gemflower)" },
            {"Amastacia(Starflower)" },
            {"Galanodel (Moonwhisper)" },
            {"Holimion (Diamonddew)" },
            {"Ilphelkiir (Gemblossom)" },
            {"Liadon (Silverfrond)" },
            {"Meliamne (Oakenheel)" },
            {"Nailo (Nightbreeze)" },
            {"Siannodel (Moonbrook)" },
            {"Xiloscient (Goldpetal)" }
        };

        // Halfing Names
        private static readonly List<string> halflingMale = new List<string>()
        {
            {"Alton" },
            {"Ander" },
            {"Cade" },
            {"Corrin" },
            {"Eldon" },
            {"Errich" },
            {"Finnan" },
            {"Garret" },
            {"Lindal" },
            {"Lyle" },
            {"Merric" },
            {"Milo" },
            {"Osborn" },
            {"Perrin" },
            {"Reed" },
            {"Roscoe" },
            {"Wellby" }
        };
        private static readonly List<string> halflingFemale = new List<string>()
        {
            {"Andry" },
            {"Bree" },
            {"Callie" },
            {"Cora" },
            {"Euphemia" },
            {"Jillian" },
            {"Kithri" },
            {"Lavinia" },
            {"Lidda" },
            {"Merla" },
            {"Nedda" },
            {"Paela" },
            {"Portia" },
            {"Seraphina" },
            {"Shaena" },
            {"Trym" },
            {"Vani" },
            {"Verna" }
        };
        private static readonly List<string> halflingFamily = new List<string>()
        {
            {"Brushgather" },
            {"Goodbarrel" },
            {"Greenbottle" },
            {"High-hill" },
            {"Hilltopple" },
            {"Leagallow" },
            {"Tealeaf" },
            {"Thorngage" },
            {"Tosscobble" },
            {"Underbough" }
        };

        // Human Names
        private static readonly List<string> humanMale = new List<string>()
        {
            {"Adran" },
            {"Aelar" },
            {"Aramil" },
            {"Arannis" },
            {"Aust" },
            {"Beiro" },
            {"Berrian" },
            {"Carric" },
            {"Erdan" },
            {"Galinndan" },
            {"Hadarai" },
            {"Heian" },
            {"Himo" },
            {"Immeral" },
            {"Ivellios" },
            {"Laucian" },
            {"Mindartis" },
            {"Paelias" },
            {"Peren" },
            {"Quarion" },
            {"Riardon" },
            {"Rolen" },
            {"Soveliss" },
            {"Thamior" },
            {"Tharivol" },
            {"Theren" },
            {"Varis" },
            {"Adrik" },
            {"Alberich" },
            {"Baern" },
            {"Barendd" },
            {"Brottor" },
            {"Bruenor" },
            {"Dain" },
            {"Darrak" },
            {"Delg" },
            {"Eberk" },
            {"Einkil" },
            {"Fargrim" },
            {"Flint" },
            {"Gardain" },
            {"Harbek" },
            {"Kildrak" },
            {"Morgran" },
            {"Orsik" },
            {"Oskar" },
            {"Rangrim" },
            {"Rurik" },
            {"Taklinn" },
            {"Thoradin" },
            {"Thorin" },
            {"Tordek" },
            {"Traubon" },
            {"Travok" },
            {"Ulfgar" },
            {"Viet" },
            {"Vondal" }
        };
        private static readonly List<string> humanFemale = new List<string>()
        {
            {"Adrie" },
            {"Althaea" },
            {"Anastrianna" },
            {"Andraste" },
            {"Antinua" },
            {"Bethrynna" },
            {"Birel" },
            {"Caelynn" },
            {"Drusilia" },
            {"Enna" },
            {"Felosial" },
            {"Ielenia" },
            {"Jelenneth" },
            {"Keyleth" },
            {"Leshanna" },
            {"Lia" },
            {"Meriele" },
            {"Mialee" },
            {"Naivara" },
            {"Quelenna" },
            {"Quilathe" },
            {"Sariel" },
            {"Shanairra" },
            {"Shava" },
            {"Silaqui" },
            {"Theirastra" },
            {"Thia" },
            {"Vadania" },
            {"Valanthe" },
            {"Xanaphia" },
            { "Amber" },
            { "Artin" },
            { "Audhild" },
            { "Bardryn" },
            { "Dagnal" },
            { "Diesa" },
            { "Eldeth" },
            { "Falkrunn" },
            { "Finellen" },
            { "Gunnloda" },
            { "Gurdis" },
            { "Helja" },
            { "Hlin" },
            { "Kathra" },
            { "Kristryd" },
            { "Ilde" },
            { "Liftrasa" },
            { "Mardred" },
            { "Riswynn" },
            { "Sannl" },
            { "Torbera" },
            { "Torgga" },
            { "Vistra" }
        };
        private static readonly List<string> humanFamily = new List<string>()
        {
            {"Amakiir (Gemflower)" },
            {"Amastacia(Starflower)" },
            {"Galanodel (Moonwhisper)" },
            {"Holimion (Diamonddew)" },
            {"Ilphelkiir (Gemblossom)" },
            {"Liadon (Silverfrond)" },
            {"Meliamne (Oakenheel)" },
            {"Nailo (Nightbreeze)" },
            {"Siannodel (Moonbrook)" },
            {"Xiloscient (Goldpetal)" },
            { "Balderk" },
            { "Battlehammer" },
            { "Brawnanvil" },
            { "Dankil" },
            { "Fireforge" },
            { "Frostbeard" },
            { "Gorunn" },
            { "Holderhek" },
            { "Ironfist" },
            { "Loderr" },
            { "Lutgehr" },
            { "Rumnaheim" },
            { "Strakeln" },
            { "Torunn" },
            { "Ungart" }
        };

        // Dragonborn Names
        private static readonly List<string> dragonbornMale = new List<string>()
        {
            {"Arjhan" },
            {"Balasar" },
            {"Bharash" },
            {"Donaar" },
            {"Ghesh" },
            {"Heskan" },
            {"Kriv" },
            {"Medrash" },
            {"Mehen" },
            {"Nadarr" },
            {"Pendjed" },
            {"Patrin" },
            {"Rhogar" },
            {"Shamash" },
            {"Shedinn" },
            {"Tarhun" },
            {"Torinn" }
        };
        private static readonly List<string> dragonbornFemale = new List<string>()
        {
            {"Akra" },
            {"Biri" },
            {"Daar" },
            {"Farideh" },
            {"Harann" },
            {"Havilar" },
            {"Jheri" },
            {"Kava" },
            {"Korinn" },
            {"Mishann" },
            {"Nala" },
            {"Perra" },
            {"Raiann" },
            {"Sora" },
            {"Surina" },
            {"Thava" },
            {"Uadjit" }
        };
        private static readonly List<string> dragonbornClan = new List<string>()
        {
            { "Clenthtinthiallor" },
            { "Daardendrian" },
            { "Delmirev" },
            { "Drachendandion" },
            { "Fenkenkebradon" },
            { "Kepeshkmolik" },
            { "Kerrhylon" },
            { "Kimbatuul" },
            { "Linxakasendalor" },
            { "Myastan" },
            { "Nemmonis" },
            { "Norixius" },
            { "Ophinshtalajiir" },
            { "Prexijandilin" },
            { "Shestendeliath" },
            { "Turnuroth" },
            { "Verthisathurgiesh" },
            { "Yarjerit" }
        };

        // Gnome Names
        private static readonly List<string> gnomeMale = new List<string>()
        {
            {"Alston" },
            {"Alvyn" },
            {"Boddynock" },
            {"Brocc" },
            {"Burgell" },
            {"Dimble" },
            {"Eldon" },
            {"Erky" },
            {"Fonkin" },
            {"Frug" },
            {"Gerbo" },
            {"Gimble" },
            {"Glim" },
            {"Jebeddo" },
            {"Kellen" },
            {"Namfoodle" },
            {"Orryn" },
            {"Roondar" },
            {"Seebo" },
            {"Sindri" },
            {"Warryn" },
            {"Wrenn" },
            {"Zook" }
        };
        private static readonly List<string> gnomeFemale = new List<string>()
        {
            {"Bimpnottin" },
            {"Breena" },
            {"Caramip" },
            {"Carlin" },
            {"Donella" },
            {"Duvamil" },
            {"Ella" },
            {"Ellyjobell" },
            {"Ellywick" },
            {"Lilli" },
            {"Loppmottin" },
            {"Lorilla" },
            {"Mardnab" },
            {"Nissa" },
            {"Nyx" },
            {"Oda" },
            {"Orla" },
            {"Roywyn" },
            {"Shamil" },
            {"Tana" },
            {"Waywocket" },
            {"Zanna" }
        };
        private static readonly List<string> gnomeClan = new List<string>()
        {
            {"Beren" },
            {"Daergel" },
            {"Folkor" },
            {"Garrick" },
            {"Nackle" },
            {"Murnig" },
            {"Ningel" },
            {"Raulnor" },
            {"Scheppen" },
            {"Timbers" },
            {"Turen" }
        };
        private static readonly List<string> gnomeNickname = new List<string>()
        {
            {"Aleslosh" },
            {"Ashhearth" },
            {"Badger" },
            {"Cloak" },
            {"Doublelock" },
            {"Filchbatter" },
            {"Fnipper" },
            {"Ku" },
            {"Nim" },
            {"Oneshoe" },
            {"Pock" },
            {"Sparklegem" }
        };

        // Halforc Names
        private static readonly List<string> halforcMale = new List<string>()
        {
            {"Dench" },
            {"Feng" },
            {"Gell" },
            {"Henk" },
            {"Holg" },
            {"Imsh" },
            {"Keth" },
            {"Krusk" },
            {"Mhurren" },
            {"Ront" },
            {"Shump" },
            {"Thokk" }
        };
        private static readonly List<string> halforcFemale = new List<string>()
        {
            {"Baggi" },
            {"Emen" },
            {"Engong" },
            {"Kansif" },
            {"Myev" },
            {"Neega" },
            {"Ovak" },
            {"Ownka" },
            {"Shautha" },
            {"Sutha" },
            {"Vola" },
            {"Volen" },
            {"Yevelda" }
        };

        // Tiefling Names
        private static readonly List<string> tieflingMale = new List<string>()
        {
            {"Akmenos" },
            {"Amnon" },
            {"Barakas" },
            {"Damakos" },
            {"Ekemon" },
            {"Lados" },
            {"Kairon" },
            {"Leucis" },
            {"Melech" },
            {"Mordai" },
            {"Morthos" },
            {"Pelaios" },
            {"Skamos" },
            {"Therai" }
        };
        private static readonly List<string> tieflingFemale = new List<string>()
        {
            {"Akta" },
            {"Anakis" },
            {"Bryseis" },
            {"Criella" },
            {"Damaia" },
            {"Ea" },
            {"Kallista" },
            {"Lerissa" },
            {"Makaria" },
            {"Nemeia" },
            {"Orianna" },
            {"Phelaia" },
            {"Rieta" }
        };
        private static readonly List<string> tieflingVirtue = new List<string>()
        {
            {"Art" },
            {"Carrion" },
            {"Chant" },
            {"Creed" },
            {"Despair" },
            {"Excellence" },
            {"Fear" },
            {"Glory" },
            {"Hope" },
            {"Ideal" },
            {"Music" },
            {"Nowhere" },
            {"Open" },
            {"Poetry" },
            {"Quest" },
            {"Random" },
            {"Reverence" },
            {"Sorrow" },
            {"Temerity" },
            {"Torment" },
            {"Weary" }
        };

        
        public static string Generate(IRace race)
        {
            switch (race.GetRaceOption())
            {
                case Options.Race.Dragonborn:
                    return Dragonborn();
                case Options.Race.Dwarf:
                    return Dwarf();
                case Options.Race.Elf:
                    return Elf();
                case Options.Race.Gnome:
                    return Gnome();
                case Options.Race.HalfElf:
                    return Halfelf();
                case Options.Race.Halfling:
                    return Halfling();
                case Options.Race.HalfOrc:
                    return Halforc();
                case Options.Race.Human:
                    return Human();
                case Options.Race.Tiefling:
                    return Tiefling();
                default:
                    return Human();
            }
        }


        private static string Dwarf()
        {
            int genderRoll = RNG.Roll(2);
            string firstName = genderRoll == 1 ? RNG.ReturnRandom(dwarfMale) : RNG.ReturnRandom(dwarfFemale);
            string clanName = RNG.ReturnRandom(dwarfClan);
            return String.Format("{0} {1}", firstName, clanName);
        }
        private static string Elf()
        {
            int genderRoll = RNG.Roll(2);
            string firstName = genderRoll == 1 ? RNG.ReturnRandom(elfMale) : RNG.ReturnRandom(elfFemale);
            string familyName = RNG.ReturnRandom(elfFamily);
            return String.Format("{0} {1}", firstName, familyName);
        }
        private static string Halfling()
        {
            int genderRoll = RNG.Roll(2);
            string firstName = genderRoll == 1 ? RNG.ReturnRandom(halflingMale) : RNG.ReturnRandom(halflingFemale);
            string familyName = RNG.ReturnRandom(halflingFamily);
            return String.Format("{0} {1}", firstName, familyName);
        }
        private static string Human()
        {
            int genderRoll = RNG.Roll(2);
            string firstName = genderRoll == 1 ? RNG.ReturnRandom(humanMale) : RNG.ReturnRandom(humanFemale);
            string familyName = RNG.ReturnRandom(humanFamily);
            return String.Format("{0} {1}", firstName, familyName);
        }
        private static string Dragonborn()
        {
            int genderRoll = RNG.Roll(2);
            string firstName = genderRoll == 1 ? RNG.ReturnRandom(dragonbornMale) : RNG.ReturnRandom(dragonbornFemale);
            string familyName = RNG.ReturnRandom(dragonbornClan);
            return String.Format("{0} {1}", firstName, familyName);
        }
        private static string Gnome()
        {
            int genderRoll = RNG.Roll(2);
            string firstName = genderRoll == 1 ? RNG.ReturnRandom(gnomeMale) : RNG.ReturnRandom(gnomeFemale);
            string nickName = RNG.ReturnRandom(gnomeNickname);
            string familyName = RNG.ReturnRandom(gnomeClan);
            return String.Format("{0} \"{1}\" {2}", firstName, nickName, familyName);
        }
        private static string Halfelf()
        {
            return Human(); // Half Elfs use same conventions as Humans
        }
        private static string Halforc()
        {
            int genderRoll = RNG.Roll(2);
            return genderRoll == 1 ? RNG.ReturnRandom(halforcMale) : RNG.ReturnRandom(halforcFemale);
        }
        private static string Tiefling()
        {
            int genderRoll = RNG.Roll(2);
            string firstName = genderRoll == 1 ? RNG.ReturnRandom(tieflingMale) : RNG.ReturnRandom(tieflingFemale);
            string familyName = RNG.ReturnRandom(tieflingVirtue);
            return String.Format("{0} {1}", firstName, familyName);
        }
    }
}
