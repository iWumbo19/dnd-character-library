using DnDCharacterCreator.Interfaces;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator
{
    internal class CharacterBuilder
    {
        public IRace Race;

        public CharacterBuilder(Character character)
        {
            switch (character.Race)
            {
                case Options.Race.None:
                    throw new Exception("No Race found for inputted character");
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
        }

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
                character.Stats.Constiution++;
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
                        character.Stats.Wisdom++;
                        break;
                    case (DwarfSubrace.Mountain):
                        character.Stats.Strength++;
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
                character.Stats.Dexterity++;
                character.Speed = 30;
                character.AddAbility(Ability.DarkVision);
                character.Stats.PerceptionProf = true;
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
                        character.Stats.Charisma++;
                        character.AddAbility(Ability.SunlightSensitivity);
                        character.AddAbility(Ability.DrowMagic);
                        character.AddProficiency(Weapon.Rapier);
                        character.AddProficiency(Weapon.Shortsword);
                        character.AddProficiency(Weapon.Crossbow);
                        break;
                    case (ElfSubrace.High):
                        character.Stats.Intelligence++;
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
                character.Stats.Dexterity++;
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
                        character.Stats.Charisma++;
                        character.AddAbility(Ability.NaturallyStealthy);
                        break;
                    case (HalflingSubrace.Stout):
                        character.Stats.Constiution++;
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
                character.Stats.Strength++;
                character.Stats.Dexterity++;
                character.Stats.Constiution++;
                character.Stats.Intelligence++;
                character.Stats.Wisdom++;
                character.Stats.Charisma++;
                character.Speed = 30;
                character.AddProficiency(StandardLanguage.Common);
                int langRoll = RNG.Roll(2);
                if (langRoll == 1) character.AddProficiency(RNG.ReturnRandom<StandardLanguage>());
                else character.AddProficiency(RNG.ReturnRandom<ExoticLanguage>());
            }
        }

        class Dragonborn : IRace
        {
            public void Build(Character character)
            {
                character.Stats.Strength++;
                character.Stats.Charisma++;
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
                character.Stats.Intelligence += 2;
                character.Speed = 30;
                character.AddAbility(Ability.DarkVision);
                character.AddAbility(Ability.GnomeCunning);
                character.AddProficiency(StandardLanguage.Common);
                character.AddProficiency(StandardLanguage.Gnomish);
                character.SubRace = RNG.ReturnRandom<GnomeSubrace>();
                switch (character.SubRace)
                {
                    case (GnomeSubrace.Forest):
                        character.Stats.Dexterity++;
                        // ADD SPELL MINOR ILLUSION/
                        character.AddAbility(Ability.SpeakWithSmallBeasts);
                        break;
                    case (GnomeSubrace.Rock):
                        character.Stats.Constiution++;
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
                character.Stats.Charisma += 2;
                character.Speed = 30;
                character.AddAbility(Ability.DarkVision);
                character.AddAbility(Ability.FeyAncentry);
                Stat profOne = RNG.ReturnRandom<Stat>();
                Stat profTwo = RNG.ReturnRandom<Stat>();
                while (profOne == profTwo) profTwo = RNG.ReturnRandom<Stat>();
                character.AddProficiency(profOne);
                character.AddProficiency(profTwo);
                Skill skillOne = RNG.ReturnRandom<Skill>();
                Skill skillTwo = RNG.ReturnRandom<Skill>();
                while (skillOne == skillTwo) skillTwo = RNG.ReturnRandom<Skill>();
                character.AddProficiency(skillOne);
                character.AddProficiency(skillTwo);
                character.AddProficiency(RNG.ReturnRandom<StandardLanguage>());
            }
        }

        class HalfOrc : IRace
        {
            public void Build(Character character)
            {
                throw new NotImplementedException();
            }
        }

        class Tiefling : IRace
        {
            public void Build(Character character)
            {
                throw new NotImplementedException();
            }
        }
    }
}
