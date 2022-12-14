using DnDCharacterCreator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator
{
    internal class Backstories
    {
        //Instanciates Different Libraries for Reference
        private readonly List<string> backstoryBase = new List<string>();

        private readonly List<string> backgroundOptions = new List<string>()
        {
            {"Acolyte" },
            {"Charlatan" },
            {"Criminal" },
            {"Entertainer" },
            {"Folk Hero" },
            {"Gladiator" },
            {"Guild Artisan" },
            {"Hermit" },
            {"Knight" },
            {"Noble" },
            {"Outlander" },
            {"Pirate" },
            {"Sage" },
            {"Sailor" },
            {"Soldier" },
            {"Urchin" }
        };
        private readonly List<string> homeTowns = new List<string>()
        {
            {"a small fising village" },
            {"the country lord's estate" },
            {"a magical \"college town\"" },
            {"a prominent trading hub" },
            {"a nomadic caravan" },
            {"a religious ghetto" },
            {"the kingdom's capital" },
            {"the city slums" },
            {"a mountain city" },
            {"a military outpost" },
            {"the local monestary" },
            {"the kingdom's castle" },
            {"the capital suburbs" },
            {"a forest hamlet" },
            {"a mining town" }
        };
        private readonly List<string> enemyBase = new List<string>()
        {
            {"a corrupted mountain" },
            {"the underground facility beneath the city" },
            {"Deathwash Mountain" },
            {"the snowy peaks" },
            {"the old templs ruins" }
        };
        private readonly List<string> timeElapse = new List<string>()
        {
            {"5 years" },
            {"2 years" },
            {"10 years" }
        };
        private readonly List<string> fantasyLocation = new List<string>()
        {
            {"the savalier woods" },
            {"the blooming grove" },
            {"the bleeding seas" },
            {"rock fall canyon" }
        };
        private readonly List<string> somethingToFightFor = new List<string>()
        {
            {"their friends" },
            {"their loved ones" },
            {"those who believed in them" },
            {"the power of friendship" },
            {"the will of the village" }
        };
        private readonly List<string> prizedPossesion = new List<string>()
        {
            {"their mothers scarf" },
            {"a locket" },
            {"a stopwatch" },
            {"a music box" },
            {"a pressed flower" },
            {"a childhood book" },
            {"a holy symbol" }
        };
        private readonly List<string> nameOfCoolWeapon = new List<string>()
        {
            {"Starfall" },
            {"Highwind" },
            {"Excelsior" }
        };
        private readonly List<string> nameOfCoolItem = new List<string>()
        {
            {"the rod of wonder" },
            {"their dick" }
        };
        private readonly List<string> characterRelative = new List<string>()
        {
            {"mother" },
            {"sister" },
            {"brother" },
            {"father" },
            {"grandmother" },
            {"grandfather" },
            {"uncle" },
            {"aunt" }
        };
        private readonly List<string> groupOfBaddies = new List<string>()
        {
            {"a group of goblins" },
            {"a group of bandirs" },
            {"Randy Orton" },
            {"a group of dragons" },
            {"a mysterious cult" },
            {"the theive's guild" },
            {"a band of rouge orcs" }
        };

        public Backstories(Character player)
        {
            backstoryBase.Add(String.Format("\n\n{0} was a simple {1} {2} who was used to traveling {3} with their {4}. Their father, a retired fighter, " +
                "bestowed the {5} upon them when they were little in hopes that one day, they could go to {6} where the man who killed their uncle lives and slay him",
                player.Name, player.Race, BackgroundOptions(), FantasyLocation(), CharacterRelative(), NameOfCoolWeapon(), EnemyBase()));

            backstoryBase.Add(String.Format("\n\n{0}, a {1} {2}, was raised by their {3} in {4}. {5} ago, {6} attacked and gravely wounded their {3}." +
                " {0} vowed to find the legendary weapon {7}, travel to {8}, and kill the man who ordered the attack on their {3}.",
                player.Name, player.Race, BackgroundOptions(), CharacterRelative(), HomeTowns(), TimeElapse(), GroupOfBaddies(), NameOfCoolWeapon(), EnemyBase()));
        }

        private string BackgroundOptions() => RNG.ReturnRandom(backgroundOptions);
        private string HomeTowns() => RNG.ReturnRandom(homeTowns);
        private string EnemyBase() => RNG.ReturnRandom(enemyBase);
        private string TimeElapse() => RNG.ReturnRandom(timeElapse);
        private string FantasyLocation() => RNG.ReturnRandom(fantasyLocation);
        private string SomethingToFightFor() => RNG.ReturnRandom(somethingToFightFor);
        private string PrizedPossesion() => RNG.ReturnRandom(prizedPossesion);
        private string NameOfCoolWeapon() => RNG.ReturnRandom(nameOfCoolWeapon);
        private string NameOfCoolItem() => RNG.ReturnRandom(nameOfCoolItem);
        private string CharacterRelative() => RNG.ReturnRandom(characterRelative);
        private string GroupOfBaddies() => RNG.ReturnRandom(groupOfBaddies); 

        public string Generate() => RNG.ReturnRandom(backstoryBase); 

    }
}
