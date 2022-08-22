using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator
{
    internal class CharacterEditor
    {
        public IRace Race;
        public IClass Class;

        public CharacterEditor(Character character)
        {
            switch (character.Race)
            {
                case Options.Race.Dragonborn:
                    Race = new Dragonborn();
                    break;
                case Options.Race.Dwarf:
                    Race = new Dwarf();
                    break;
                case Options.Race.Elf:
                    Race = new Elf();   
                    break;
                case Options.Race.Gnome:
                    Race = new Gnome();
                    break;
                case Options.Race.HalfElf:
                    Race = new HalfElf();
                    break;
                case Options.Race.Halfling:
                    Race = new Halfling();
                    break;
                case Options.Race.HalfOrc:
                    Race = new HalfOrc();
                    break;
                case Options.Race.Human:
                    Race = new Human();
                    break;
                case Options.Race.Tiefling:
                    Race = new Tiefling();
                    break;
                default:
                    throw new Exception("Not a valid race for inputted character");
            }
            switch (character.Class)
            {
                case Options.Class.Barbarian:
                    Class = new Barbarian();
                    break;
                case Options.Class.Bard:
                    Class = new Bard();
                    break;
                case Options.Class.Cleric:
                    Class = new Cleric();
                    break;
                case Options.Class.Druid:
                    Class = new Druid();
                    break;
                case Options.Class.Fighter:
                    Class = new Fighter();
                    break;
                case Options.Class.Monk:
                    Class = new Monk();
                    break;
                case Options.Class.Paladin:
                    Class = new Paladin();
                    break;
                case Options.Class.Ranger:
                    Class = new Ranger();
                    break;
                case Options.Class.Rouge:
                    Class = new Rouge();
                    break;
                case Options.Class.Sorcerer:
                    Class = new Sorcerer();
                    break;
                case Options.Class.Warlock:
                    Class = new Warlock();
                    break;
                case Options.Class.Wizard:
                    Class = new Wizard();
                    break;
                default:
                    break;
            }
        }

        #region RACES
        class Dwarf : IRace
        {
            List<ArtisanTool> dwarfToolOptions = new List<ArtisanTool>()
            {
                ArtisanTool.SmithTools,
                ArtisanTool.BrewerSupplies,
                ArtisanTool.MasonTools
            };
            public void Build(Character character)
            {
                character.IncreaseStat(Stat.Constitution, 1);
                character.Speed = 25;
                character.AddAbility(Ability.DarkVision);
                character.AddResistance(DamageType.Poison);
                character.AddProficiency(Weapon.Battleaxe);
                character.AddProficiency(Weapon.Handaxe);
                character.AddProficiency(Weapon.LightHammer);
                character.AddProficiency(Weapon.Warhammer);
                character.AddProficiency(RNG.ReturnRandom(dwarfToolOptions));
                character.AddProficiency(StandardLanguage.Common);
                character.AddProficiency(StandardLanguage.Dwarvish);
                character.SubRace = RNG.ReturnRandom<DwarfSubrace>();
                switch (character.SubRace)
                {
                    case (DwarfSubrace.Hill):
                        character.IncreaseStat(Stat.Wisdom, 1);
                        break;
                    case (DwarfSubrace.Mountain):
                        character.IncreaseStat(Stat.Strength, 1);
                        character.AddProficiency(Armor.Light);
                        character.AddProficiency(Armor.Medium);
                        break;
                    default:
                        throw new Exception("Failed to apply Dwarf Subrace within Character Builder");
                }
            }
        }
        class Elf : IRace
        {
            public void Build(Character character)
            {
                character.IncreaseStat(Stat.Dexterity, 1);
                character.Speed = 30;
                character.AddAbility(Ability.DarkVision);
                character.AddProficiency(Skill.Perception);
                character.AddAbility(Ability.FeyAncentry);
                character.AddAbility(Ability.Trance);
                character.AddProficiency(StandardLanguage.Common);
                character.AddProficiency(StandardLanguage.Elvish);
                character.SubRace = RNG.ReturnRandom<ElfSubrace>();
                switch (character.SubRace)
                {
                    case (ElfSubrace.Wood):
                        character.AddProficiency(Weapon.Longsword);
                        character.AddProficiency(Weapon.Shortsword);
                        character.AddProficiency(Weapon.Shortbow);
                        character.AddProficiency(Weapon.Longbow);
                        character.Speed += 5;
                        character.AddAbility(Ability.MaskOfTheWild);
                        break;
                    case (ElfSubrace.Dark):
                        character.IncreaseStat(Stat.Charisma, 1);
                        character.AddAbility(Ability.SunlightSensitivity);
                        character.AddAbility(Ability.DrowMagic);
                        character.AddProficiency(Weapon.Rapier);
                        character.AddProficiency(Weapon.Shortsword);
                        character.AddProficiency(Weapon.Crossbow);
                        break;
                    case (ElfSubrace.High):
                        character.IncreaseStat(Stat.Intelligence, 1);
                        character.AddProficiency(Weapon.Longsword); ;
                        character.AddProficiency(Weapon.Shortsword);
                        character.AddProficiency(Weapon.Shortbow);
                        character.AddProficiency(Weapon.Shortsword);
                        int langRoll = RNG.Roll(2);
                        if (langRoll == 1)
                            character.AddProficiency(RNG.ReturnRandom<StandardLanguage>());
                        else 
                            character.AddProficiency(RNG.ReturnRandom<ExoticLanguage>());
                        break;
                    default:
                        throw new Exception("Failed to apply Elf Subrace within Character Builder");
                }
            }
        }
        class Halfling : IRace
        {
            public void Build(Character character)
            {
                character.IncreaseStat(Stat.Dexterity, 1);
                character.Speed = 25;
                character.AddAbility(Ability.Lucky);
                character.AddAbility(Ability.Brave);
                character.AddAbility(Ability.HalflingNimbleness);
                character.AddProficiency(StandardLanguage.Common);
                character.AddProficiency(StandardLanguage.Halfing);
                character.SubRace = RNG.ReturnRandom<HalflingSubrace>();
                switch (character.SubRace)
                {
                    case (HalflingSubrace.Lightfoot):
                        character.IncreaseStat(Stat.Charisma, 1);
                        character.AddAbility(Ability.NaturallyStealthy);
                        break;
                    case (HalflingSubrace.Stout):
                        character.IncreaseStat(Stat.Constitution, 1);
                        character.AddAbility(Ability.StoutResilience);
                        break;
                    default:
                        throw new Exception("Failed to apply Halfling Subrace within Character Builder");
                }
            }
        }
        class Human : IRace
        {
            public void Build(Character character)
            {
                character.IncreaseStat(Stat.Strength, 1);
                character.IncreaseStat(Stat.Dexterity, 1);
                character.IncreaseStat(Stat.Constitution, 1);
                character.IncreaseStat(Stat.Intelligence, 1);
                character.IncreaseStat(Stat.Wisdom, 1);
                character.IncreaseStat(Stat.Charisma, 1);
                character.Speed = 30;
                character.AddProficiency(StandardLanguage.Common);
                int langRoll = RNG.Roll(2);
                if (langRoll == 1) 
                    character.AddProficiency(RNG.ReturnRandom<StandardLanguage>());
                else 
                    character.AddProficiency(RNG.ReturnRandom<ExoticLanguage>());
            }
        }
        class Dragonborn : IRace
        {
            public void Build(Character character)
            {
                character.IncreaseStat(Stat.Strength, 1);
                character.IncreaseStat(Stat.Charisma, 1);
                character.Speed = 30;
                character.AddProficiency(StandardLanguage.Common);
                character.AddProficiency(ExoticLanguage.Draconic);
                character.AddAbility(Ability.BreathWeapon);
                character.SubRace = RNG.ReturnRandom<DragonbornSubrace>();
                switch (character.SubRace)
                {
                    case (DragonbornSubrace.Black):
                        character.AddResistance(DamageType.Acid);
                        break;
                    case (DragonbornSubrace.Blue):
                        character.AddResistance(DamageType.Lightning);
                        break;
                    case (DragonbornSubrace.Brass):
                        character.AddResistance(DamageType.Fire);
                        break;
                    case (DragonbornSubrace.Bronze):
                        character.AddResistance(DamageType.Lightning);
                        break;
                    case (DragonbornSubrace.Copper):
                        character.AddResistance(DamageType.Acid);
                        break;
                    case (DragonbornSubrace.Gold):
                        character.AddResistance(DamageType.Fire);
                        break;
                    case (DragonbornSubrace.Green):
                        character.AddResistance(DamageType.Poison);
                        break;
                    case (DragonbornSubrace.Red):
                        character.AddResistance(DamageType.Fire);
                        break;
                    case (DragonbornSubrace.Silver):
                        character.AddResistance(DamageType.Cold);
                        break;
                    case (DragonbornSubrace.White):
                        character.AddResistance(DamageType.Cold);
                        break;
                    default:
                        throw new Exception("Failed to apply Halfling Subrace within Character Builder");
                }
            }
        }
        class Gnome : IRace
        {
            public void Build(Character character)
            {
                character.IncreaseStat(Stat.Intelligence, 2);
                character.Speed = 30;
                character.AddAbility(Ability.DarkVision);
                character.AddAbility(Ability.GnomeCunning);
                character.AddProficiency(StandardLanguage.Common);
                character.AddProficiency(StandardLanguage.Gnomish);
                character.SubRace = RNG.ReturnRandom<GnomeSubrace>();
                switch (character.SubRace)
                {
                    case (GnomeSubrace.Forest):
                        character.IncreaseStat(Stat.Dexterity, 1);
                        // ADD SPELL MINOR ILLUSION/
                        character.AddAbility(Ability.SpeakWithSmallBeasts);
                        break;
                    case (GnomeSubrace.Rock):
                        character.IncreaseStat(Stat.Constitution, 2);
                        character.AddAbility(Ability.ArtificersLore);
                        character.AddAbility(Ability.Tinker);
                        character.AddProficiency(ArtisanTool.TinkerTools);
                        break;
                    default:
                        throw new Exception("Failed to apply Halfling Subrace within Character Builder");
                }
            }
        }
        class HalfElf : IRace
        {
            public void Build(Character character)
            {
                character.IncreaseStat(Stat.Charisma, 2);
                character.Speed = 30;
                character.AddAbility(Ability.DarkVision);
                character.AddAbility(Ability.FeyAncentry);
                Stat profOne = RNG.ReturnRandom<Stat>();
                Stat profTwo = RNG.ReturnRandom<Stat>();
                while (profOne == profTwo) 
                    profTwo = RNG.ReturnRandom<Stat>();
                character.AddProficiency(profOne);
                character.AddProficiency(profTwo);
                Skill skillOne = RNG.ReturnRandom<Skill>();
                Skill skillTwo = RNG.ReturnRandom<Skill>();
                while (skillOne == skillTwo) 
                    skillTwo = RNG.ReturnRandom<Skill>();
                character.AddProficiency(skillOne);
                character.AddProficiency(skillTwo);
                character.AddProficiency(RNG.ReturnRandom<StandardLanguage>());
            }
        }
        class HalfOrc : IRace
        {
            public void Build(Character character)
            {
                character.IncreaseStat(Stat.Strength, 2);
                character.IncreaseStat(Stat.Strength, 1);
                character.Speed = 30;
                character.AddAbility(Ability.DarkVision);
                character.AddProficiency(Skill.Intimidation);
                character.AddAbility(Ability.RelentlessEndurance);
                character.AddAbility(Ability.SavageAttacks);
                character.AddProficiency(StandardLanguage.Common);
                character.AddProficiency(StandardLanguage.Orc);
            }
        }
        class Tiefling : IRace
        {
            public void Build(Character character)
            {
                character.IncreaseStat(Stat.Intelligence, 1);
                character.IncreaseStat(Stat.Charisma, 2);
                character.Speed = 30;
                character.AddAbility(Ability.DarkVision);
                character.AddResistance(DamageType.Fire);
                // ADD THAUMATURGY
                character.AddProficiency(StandardLanguage.Common);
                character.AddProficiency(ExoticLanguage.Infernal);
            }
        }
        #endregion

        #region CLASSES
        class Barbarian : IClass
        {
            private readonly List<Skill> barbSkillOptions = new List<Skill>()
            {
                Skill.AnimalHandling,
                Skill.Athletics,
                Skill.Intimidation,
                Skill.Nature,
                Skill.Perception,
                Skill.Survival
            };
            public void LevelOne(Character character)
            {
                AssignStats(character);
                character.HitDie = 12;
                character.MaxHealth = character.HitDie + character.ConstitutionMod;
                character.AddProficiency(Armor.Light);
                character.AddProficiency(Armor.Medium);
                character.AddProficiency(Armor.Shield);
                character.AddProficiency(Utilities.AllWeapons);
                character.AddProficiency(Stat.Dexterity);
                character.AddProficiency(Stat.Constitution);
                character.AddRandomProf(barbSkillOptions);
                character.AddRandomProf(barbSkillOptions);
                character.AddAbility(Ability.Rage);
                character.AddAbility(Ability.UnarmoredDefense);
            }
            public void AssignStats(Character character)
            {
                int[] stats = Utilities.GetRandomStats();
                character.Stats[(int)Stat.Strength] = stats[0];
                character.Stats[(int)Stat.Dexterity] = stats[2];
                character.Stats[(int)Stat.Constitution] = stats[1];
                character.Stats[(int)Stat.Intelligence] = stats[5];
                character.Stats[(int)Stat.Wisdom] = stats[3];
                character.Stats[(int)Stat.Charisma] = stats[4];
            }
        }
        class Bard : IClass
        {
            public void LevelOne(Character character)
            {
                AssignStats(character);
                character.HitDie = Tables.classHitDie[Options.Class.Bard];
                character.MaxHealth = character.HitDie + character.ConstitutionMod;
                character.AddProficiency(Armor.Light);
                character.AddProficiency(Utilities.SimpleWeapons);
                character.AddProficiency(Weapon.Crossbow);
                character.AddProficiency(Weapon.Longsword);
                character.AddProficiency(Weapon.Rapier);
                character.AddProficiency(Weapon.Shortsword);
                character.AddProficiency(RNG.ReturnRandom<Instrument>());
                character.AddRandomProf(Instrument.Lute);
                character.AddRandomProf(Instrument.Lute);
                character.AddRandomProf(Instrument.Lute);
                character.AddProficiency(Stat.Dexterity);
                character.AddProficiency(Stat.Charisma);
                character.AddRandomProf(Skill.Arcana);
                character.AddRandomProf(Skill.Arcana);
                character.AddRandomProf(Skill.Arcana);
                // ADD 2 CANTRIPS
                character.AddAbility(Ability.BardicInspiration);
            }
            public void AssignStats(Character character)
            {
                int[] stats = Utilities.GetRandomStats();
                character.Stats[(int)Stat.Strength] = stats[5];
                character.Stats[(int)Stat.Dexterity] = stats[1];
                character.Stats[(int)Stat.Constitution] = stats[2];
                character.Stats[(int)Stat.Intelligence] = stats[3];
                character.Stats[(int)Stat.Wisdom] = stats[4];
                character.Stats[(int)Stat.Charisma] = stats[0];
            }
        }
        class Cleric : IClass
        {
            private readonly List<Skill> clericSkillOptions = new List<Skill>()
            { 
                Skill.History,
                Skill.Insight,
                Skill.Medicine,
                Skill.Persuasion,
                Skill.Religion
            };
            private readonly List<Skill> knowledgeClericSkills = new List<Skill>()
            {
                Skill.Arcana,
                Skill.History,
                Skill.Nature,
                Skill.Religion
            };
            private readonly List<Skill> natureClericSkills = new List<Skill>()
            {
                Skill.AnimalHandling,
                Skill.Nature,
                Skill.Survival
            };

            public void LevelOne(Character character)
            {
                AssignStats(character);
                character.HitDie = Tables.classHitDie[Options.Class.Cleric];
                character.MaxHealth = character.HitDie + character.ConstitutionMod;
                character.AddProficiency(Armor.Light);
                character.AddProficiency(Armor.Medium);
                character.AddProficiency(Armor.Shield);
                character.AddProficiency(Stat.Wisdom);
                character.AddProficiency(Stat.Charisma);
                character.AddRandomProf(clericSkillOptions);
                character.AddRandomProf(clericSkillOptions);
                // ADD 3 CANTRIPS   
                character.SubClass = RNG.ReturnRandom<ClericSubclass>();
                switch (character.SubClass)
                {
                    case ClericSubclass.Knowledge:
                        // ADD COMMAND AND IDENTIFY
                        character.AddRandomProf(knowledgeClericSkills);
                        character.AddRandomProf(knowledgeClericSkills);
                        break;
                    case ClericSubclass.Life:
                        // ADD BLESS AND CURE WOUNDS
                        character.AddAbility(Ability.DiscipleOfLife);
                        character.AddProficiency(Armor.Heavy);
                        break;
                    case ClericSubclass.Light:
                        // ADD BURNING HANDS, FAERIE FIRE, LIGHT
                        character.AddAbility(Ability.WardingFlare);
                        break;
                    case ClericSubclass.Nature:
                        // ADD ANIMAL FRIENDSHIP, SPEAK WITH ANIMALS
                        character.AddProficiency(Armor.Heavy);
                        character.AddRandomProf(natureClericSkills);
                        break;
                    case ClericSubclass.Tempest:
                        // ADD FOG CLOUD, THUNDERWAVE
                        character.AddProficiency(Utilities.MartialWeapons);
                        character.AddProficiency(Armor.Heavy);
                        character.AddAbility(Ability.WrathOfTheStorm);
                        break;
                    case ClericSubclass.Trickery:
                        // ADD CHARM PERSON, DISGUISE SELF
                        character.AddAbility(Ability.BlessingOfTheTrickster);
                        break;
                    case ClericSubclass.War:
                        // ADD DIVINE FAVOR, SHIELD OF FAITH
                        character.AddProficiency(Utilities.MartialWeapons);
                        character.AddProficiency(Armor.Heavy);
                        character.AddAbility(Ability.WarPriest);
                        break;
                    default:
                        throw new Exception("Not subrace found for cleric");
                }

            }
            public void AssignStats(Character character)
            {
                int[] stats = Utilities.GetRandomStats();
                character.Stats[(int)Stat.Strength] = stats[1];
                character.Stats[(int)Stat.Dexterity] = stats[4];
                character.Stats[(int)Stat.Constitution] = stats[2];
                character.Stats[(int)Stat.Intelligence] = stats[0];
                character.Stats[(int)Stat.Wisdom] = stats[3];
                character.Stats[(int)Stat.Charisma] = stats[5];
            }
        }
        class Druid : IClass
        {
            private readonly List<Skill> druidSkillOptions = new List<Skill>()
            {
                Skill.Arcana,
                Skill.AnimalHandling,
                Skill.Insight,
                Skill.Medicine,
                Skill.Nature,
                Skill.Perception,
                Skill.Religion,
                Skill.Survival
            };

            public void LevelOne(Character character)
            {
                AssignStats(character);
                character.HitDie = Tables.classHitDie[Options.Class.Druid];
                character.MaxHealth = character.HitDie + character.ConstitutionMod;
                character.AddProficiency(Armor.Light);
                character.AddProficiency(Armor.Medium);
                character.AddProficiency(Armor.Shield);
                character.AddProficiency(Weapon.Club);
                character.AddProficiency(Weapon.Dagger);
                character.AddProficiency(Weapon.Dart);
                character.AddProficiency(Weapon.Javelin);
                character.AddProficiency(Weapon.Mace);
                character.AddProficiency(Weapon.Quarterstaff);
                character.AddProficiency(Weapon.Scimitar);
                character.AddProficiency(Weapon.Sickle);
                character.AddProficiency(Weapon.Sling);
                character.AddProficiency(Weapon.Spear);
                character.AddProficiency(ArtisanTool.HerbalismKit);
                character.AddProficiency(Stat.Intelligence);
                character.AddProficiency(Stat.Wisdom);
                character.AddRandomProf(druidSkillOptions);
                character.AddRandomProf(druidSkillOptions);
                character.AddProficiency(StandardLanguage.Druidic);
                // ADD TWO RANDOM SPELLS   
                character.AddAbility(Ability.WildShape);
            }
            public void AssignStats(Character character)
            {
                int[] stats = Utilities.GetRandomStats();
                character.Stats[(int)Stat.Strength] = stats[5];
                character.Stats[(int)Stat.Dexterity] = stats[1];
                character.Stats[(int)Stat.Constitution] = stats[2];
                character.Stats[(int)Stat.Intelligence] = stats[4];
                character.Stats[(int)Stat.Wisdom] = stats[0];
                character.Stats[(int)Stat.Charisma] = stats[3];
            }
        }
        class Fighter : IClass
        {
            private readonly List<Skill> fighterSkillOptions = new List<Skill>()
            {
                Skill.Acrobatics,
                Skill.AnimalHandling,
                Skill.Athletics,
                Skill.History,
                Skill.Insight,
                Skill.Intimidation,
                Skill.Perception,
                Skill.Survival
            };

            public void LevelOne(Character character)
            {
                AssignStats(character);
                character.HitDie = Tables.classHitDie[Options.Class.Fighter];
                character.MaxHealth = character.HitDie + character.ConstitutionMod;
                character.AddProficiency(Armor.Heavy);
                character.AddProficiency(Armor.Medium);
                character.AddProficiency(Armor.Light);
                character.AddProficiency(Armor.Shield);
                character.AddProficiency(Stat.Strength);
                character.AddProficiency(Stat.Constitution);
                character.AddRandomProf(fighterSkillOptions);
                character.AddRandomProf(fighterSkillOptions);
            }
            public void AssignStats(Character character)
            {
                int[] stats = Utilities.GetRandomStats();
                character.Stats[(int)Stat.Strength] = stats[0];
                character.Stats[(int)Stat.Dexterity] = stats[2];
                character.Stats[(int)Stat.Constitution] = stats[1];
                character.Stats[(int)Stat.Intelligence] = stats[3];
                character.Stats[(int)Stat.Wisdom] = stats[5];
                character.Stats[(int)Stat.Charisma] = stats[4];
            }
        }
        class Monk : IClass
        {
            private readonly List<Skill> monkSkillOptions = new List<Skill>()
            {
                Skill.Acrobatics,
                Skill.Athletics,
                Skill.History,
                Skill.Insight,
                Skill.Religion,
                Skill.Stealth
            };

            public void LevelOne(Character character)
            {
                AssignStats(character);
                character.HitDie = Tables.classHitDie[Options.Class.Monk];
                character.MaxHealth = character.HitDie + character.ConstitutionMod;
                character.AddProficiency(Utilities.SimpleWeapons);
                character.AddProficiency(Weapon.Shortsword);
                character.AddRandomProf(ArtisanTool.AlchemistSupplies);
                character.AddProficiency(Stat.Strength);
                character.AddProficiency(Stat.Dexterity);
                character.AddRandomProf(monkSkillOptions);
                character.AddRandomProf(monkSkillOptions);
                character.AddAbility(Ability.UnarmoredDefense);
                character.AddAbility(Ability.MartialArts);
            }
            public void AssignStats(Character character)
            {
                int[] stats = Utilities.GetRandomStats();
                character.Stats[(int)Stat.Strength] = stats[3];
                character.Stats[(int)Stat.Dexterity] = stats[0];
                character.Stats[(int)Stat.Constitution] = stats[1];
                character.Stats[(int)Stat.Intelligence] = stats[2];
                character.Stats[(int)Stat.Wisdom] = stats[5];
                character.Stats[(int)Stat.Charisma] = stats[4];
            }
        }
        class Paladin : IClass
        {
            private readonly List<Skill> paladinSkillOptions = new List<Skill>()
            {
                Skill.Athletics,
                Skill.Insight,
                Skill.Intimidation,
                Skill.Medicine,
                Skill.Persuasion,
                Skill.Religion
            };

            public void LevelOne(Character character)
            {
                AssignStats(character);
                character.HitDie = Tables.classHitDie[Options.Class.Paladin];
                character.MaxHealth = character.HitDie + character.ConstitutionMod;
                character.AddProficiency(Armor.Light);
                character.AddProficiency(Armor.Medium);
                character.AddProficiency(Armor.Heavy);
                character.AddProficiency(Armor.Shield);
                character.AddProficiency(Utilities.AllWeapons);
                character.AddProficiency(Stat.Wisdom);
                character.AddProficiency(Stat.Charisma);
                character.AddRandomProf(paladinSkillOptions);
                character.AddRandomProf(paladinSkillOptions);
                character.AddAbility(Ability.DivineSense);
                character.AddAbility(Ability.LayOnHands);
            }
            public void AssignStats(Character character)
            {
                int[] stats = Utilities.GetRandomStats();
                character.Stats[(int)Stat.Strength] = stats[0];
                character.Stats[(int)Stat.Dexterity] = stats[3];
                character.Stats[(int)Stat.Constitution] = stats[1];
                character.Stats[(int)Stat.Intelligence] = stats[4];
                character.Stats[(int)Stat.Wisdom] = stats[5];
                character.Stats[(int)Stat.Charisma] = stats[2];
            }
        }
        class Ranger : IClass
        {
            private readonly List<Skill> rangerSkillOptions = new List<Skill>()
            {
                Skill.AnimalHandling,
                Skill.Athletics,
                Skill.Insight,
                Skill.Investigation,
                Skill.Nature,
                Skill.Perception,
                Skill.Stealth,
                Skill.Survival
            };

            public void LevelOne(Character character)
            {
                AssignStats(character);
                character.HitDie = Tables.classHitDie[Options.Class.Ranger];
                character.MaxHealth = character.HitDie + character.ConstitutionMod;
                character.AddProficiency(Armor.Light);
                character.AddProficiency(Armor.Medium);
                character.AddProficiency(Armor.Shield);
                character.AddProficiency(Utilities.AllWeapons);
                character.AddRandomProf(rangerSkillOptions);
                character.AddRandomProf(rangerSkillOptions);
                character.AddRandomProf(rangerSkillOptions);
                character.AddAbility(Ability.FavoredEnemy);
                character.AddAbility(Ability.NaturalExplorer);
            }
            public void AssignStats(Character character)
            {
                int[] stats = Utilities.GetRandomStats();
                character.Stats[(int)Stat.Strength] = stats[5];
                character.Stats[(int)Stat.Dexterity] = stats[0];
                character.Stats[(int)Stat.Constitution] = stats[2];
                character.Stats[(int)Stat.Intelligence] = stats[3];
                character.Stats[(int)Stat.Wisdom] = stats[1];
                character.Stats[(int)Stat.Charisma] = stats[4];
            }
        }
        class Rouge : IClass
        {
            private readonly List<Skill> rougeSkillOptions = new List<Skill>()
            {
                Skill.Acrobatics,
                Skill.Athletics,
                Skill.Deception,
                Skill.Insight,
                Skill.Intimidation,
                Skill.Investigation,
                Skill.Perception,
                Skill.Performance,
                Skill.Persuasion,
                Skill.SleightOfHand,
                Skill.Stealth
            };

            public void LevelOne(Character character)
            {
                AssignStats(character);
                character.HitDie = Tables.classHitDie[Options.Class.Rouge];
                character.MaxHealth = character.HitDie + character.ConstitutionMod;
                character.AddProficiency(Armor.Light);
                character.AddProficiency(Utilities.SimpleWeapons);
                character.AddProficiency(Weapon.Crossbow);
                character.AddProficiency(Weapon.Longsword);
                character.AddProficiency(Weapon.Rapier);
                character.AddProficiency(Weapon.Shortsword);
                character.AddProficiency(ArtisanTool.ThievesTools);
                character.AddProficiency(Stat.Dexterity);
                character.AddProficiency(Stat.Intelligence);
                character.AddRandomProf(rougeSkillOptions);
                character.AddRandomProf(rougeSkillOptions);
                character.AddRandomProf(rougeSkillOptions);
                character.AddRandomProf(rougeSkillOptions);
                character.AddAbility(Ability.Expertise);
                character.AddAbility(Ability.SneakAttack);
                character.AddProficiency(StandardLanguage.ThievesCant);
            }
            public void AssignStats(Character character)
            {
                int[] stats = Utilities.GetRandomStats();
                character.Stats[(int)Stat.Strength] = stats[5];
                character.Stats[(int)Stat.Dexterity] = stats[0];
                character.Stats[(int)Stat.Constitution] = stats[1];
                character.Stats[(int)Stat.Intelligence] = stats[3];
                character.Stats[(int)Stat.Wisdom] = stats[4];
                character.Stats[(int)Stat.Charisma] = stats[2];
            }
        }
        class Sorcerer : IClass
        {
            private readonly List<Skill> sorcererSkillOptions = new List<Skill>()
            {
                Skill.Arcana,
                Skill.Deception,
                Skill.Insight,
                Skill.Intimidation,
                Skill.Persuasion,
                Skill.Religion
            };

            public void LevelOne(Character character)
            {
                AssignStats(character);
                character.HitDie = Tables.classHitDie[Options.Class.Sorcerer];
                character.MaxHealth = character.HitDie + character.ConstitutionMod;
                character.AddProficiency(Weapon.Dagger);
                character.AddProficiency(Weapon.Dart);
                character.AddProficiency(Weapon.Sling);
                character.AddProficiency(Weapon.Quarterstaff);
                character.AddProficiency(Weapon.Crossbow);
                character.AddProficiency(Stat.Constitution);
                character.AddProficiency(Stat.Charisma);
                character.AddRandomProf(sorcererSkillOptions);
                character.AddRandomProf(sorcererSkillOptions);
                // ADD FOUR RANDOM CANTRIPS 
            }
            public void AssignStats(Character character)
            {
                int[] stats = Utilities.GetRandomStats();
                character.Stats[(int)Stat.Strength] = stats[5];
                character.Stats[(int)Stat.Dexterity] = stats[1];
                character.Stats[(int)Stat.Constitution] = stats[2];
                character.Stats[(int)Stat.Intelligence] = stats[3];
                character.Stats[(int)Stat.Wisdom] = stats[4];
                character.Stats[(int)Stat.Charisma] = stats[0];
            }
        }
        class Warlock : IClass
        {
            private readonly List<Skill> warlockSkillOptions = new List<Skill>()
            {
                Skill.Arcana,
                Skill.Deception,
                Skill.History,
                Skill.Intimidation,
                Skill.Investigation,
                Skill.Nature,
                Skill.Religion
            };

            public void LevelOne(Character character)
            {
                AssignStats(character);
                character.HitDie = Tables.classHitDie[Options.Class.Warlock];
                character.MaxHealth = character.HitDie + character.ConstitutionMod;
                character.AddProficiency(Utilities.SimpleWeapons);
                character.AddProficiency(Stat.Wisdom);
                character.AddProficiency(Stat.Charisma);
                character.AddRandomProf(warlockSkillOptions);
                character.AddRandomProf(warlockSkillOptions);
                character.AddAbility(Ability.OtherWorldlyPatron);
                character.AddAbility(Ability.PactMagic);
                // ADD 2 RANDOM SPELLS
            }
            public void AssignStats(Character character)
            {
                int[] stats = Utilities.GetRandomStats();
                character.Stats[(int)Stat.Strength] = stats[5];
                character.Stats[(int)Stat.Dexterity] = stats[1];
                character.Stats[(int)Stat.Constitution] = stats[2];
                character.Stats[(int)Stat.Intelligence] = stats[3];
                character.Stats[(int)Stat.Wisdom] = stats[4];
                character.Stats[(int)Stat.Charisma] = stats[0];
            }

        }
        class Wizard : IClass
        {
            private readonly List<Skill> wizardSkillOptions = new List<Skill>()
            {
                Skill.Arcana,
                Skill.History,
                Skill.Insight,
                Skill.Investigation,
                Skill.Medicine,
                Skill.Religion
            };

            public void LevelOne(Character character)
            {
                AssignStats(character);
                character.HitDie = Tables.classHitDie[Options.Class.Wizard];
                character.MaxHealth = character.HitDie + character.ConstitutionMod;
                character.AddProficiency(Weapon.Dagger);
                character.AddProficiency(Weapon.Dart);
                character.AddProficiency(Weapon.Sling);
                character.AddProficiency(Weapon.Quarterstaff);
                character.AddProficiency(Stat.Intelligence);
                character.AddProficiency(Stat.Wisdom);
                character.AddRandomProf(wizardSkillOptions);
                character.AddRandomProf(wizardSkillOptions);
                character.AddAbility(Ability.ArcaneRecovery);
            }
            public void AssignStats(Character character)
            {
                int[] stats = Utilities.GetRandomStats();
                character.Stats[(int)Stat.Strength] = stats[5];
                character.Stats[(int)Stat.Dexterity] = stats[1];
                character.Stats[(int)Stat.Constitution] = stats[2];
                character.Stats[(int)Stat.Intelligence] = stats[0];
                character.Stats[(int)Stat.Wisdom] = stats[3];
                character.Stats[(int)Stat.Charisma] = stats[4];
            }
        }
        #endregion
    }
}
