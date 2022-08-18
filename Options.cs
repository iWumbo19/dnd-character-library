using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Options
{

    public enum Race
    {
        Dragonborn,
        Dwarf,
        Elf,
        Gnome,
        HalfElf,
        Halfling,
        HalfOrc,
        Human,
        Tiefling,

    }
    public enum Class
    {
        Barbarian,
        Bard,
        Cleric,
        Druid,
        Fighter,
        Monk,
        Paladin,
        Ranger,
        Rouge, 
        Sorcerer,
        Warlock,
        Wizard
    }
    public enum Weapon
    {
        Club,
        Dagger,
        Greatclub,
        Handaxe,
        Javelin,
        LightHammer,
        Mace,
        Quarterstaff,
        Sickle,
        Spear,
        Crossbow,
        Dart,
        Shortbow,
        Sling,
        Battleaxe,
        Flail,
        Glaive,
        Greataxe,
        Greatsword,
        Halberd,
        Lance,
        Longsword,
        Maul,
        Morningstar,
        Pike,
        Rapier,
        Scimitar,
        Shortsword,
        Trident,
        WarPick,
        Warhammer,
        Whip,
        Blowgun,
        Longbow,
        HeavyCrossbow,
        Net
    }
    public enum Armor
    {
        Light,
        Medium,
        Heavy,
        Shield
    }
    public enum Stat
    {
        Strength,
        Dexterity,
        Constitution,
        Intelligence,
        Wisdom,
        Charisma
    }
    public enum Skill
    {
        Athletics,
        Acrobatics,
        SleightOfHand,
        Stealth,
        Arcana,
        History,
        Investigation,
        Nature,
        Religion,
        AnimalHandling,
        Insight,
        Medicine,
        Perception,
        Survival,
        Deception,
        Intimidation,
        Performance,
        Persuasion
    }
    public enum DamageType
    {
        Slashing,
        Bludgeoning,
        Piercing,
        Poison,
        Acid,
        Fire,
        Cold,
        Radiant,
        Necrotic,
        Lightning,
        Thunder,
        Force,
        Psychic
    }


    public enum HalflingSubrace
    {
        Lightfoot,
        Stout
    }
    public enum ElfSubrace
    {
        High,
        Wood,
        Dark
    }
    public enum GnomeSubrace
    {
        Forest,
        Rock
    }
    public enum DwarfSubrace
    {
        Hill,
        Mountain
    }
    public enum DragonbornSubrace
    {
        Black,
        Blue,
        Brass,
        Bronze,
        Copper,
        Gold,
        Green,
        Red,
        Silver,
        White
    }


    public enum ClericSubclass
    {
        Knowledge,
        Life,
        Light,
        Nature,
        Tempest,
        Trickery,
        War
    }


    public enum StandardLanguage
    {
        Common,
        Dwarvish,
        Elvish,
        Giant,
        Gnomish,
        Gobline,
        Halfing,
        Orc,
        Druidic,
        ThievesCant
    }
    public enum ExoticLanguage
    {
        Abyssal,
        Celestial,
        Draconic,
        DeepSpeech,
        Infernal,
        Primordial,
        Sylvan,
        Undercommon
    }
    public enum Instrument
    {
        Bagpipes,
        Drum,
        Dulcimer,
        Flute,
        Lute,
        Lyre,
        Horn,
        PanFlute,
        Shawm,
        Viol
    }
    public enum ArtisanTool
    {
        AlchemistSupplies,
        BrewerSupplies,
        CaligrapherSupplies,
        CarpenterTools,
        CartographerTools,
        CobblerTools,
        CookUtensils,
        GlassblowerTools,
        JewelerTools,
        LeatherworkTools,
        MasonTools,
        PainterTools,
        PotterTools,
        SmithTools,
        TinkerTools,
        WeaverTools,
        WoodcarverTools,
        ThievesTools,
        HerbalismKit
    }
    public enum Ability
    {
        DarkVision,
        FeyAncentry,
        Trance,
        MaskOfTheWild,
        SunlightSensitivity,
        DrowMagic,
        Lucky,
        Brave,
        HalflingNimbleness,
        NaturallyStealthy,
        StoutResilience,
        BreathWeapon,
        GnomeCunning,
        SpeakWithSmallBeasts,
        ArtificersLore,
        Tinker,
        RelentlessEndurance,
        SavageAttacks,
        Rage,
        UnarmoredDefense,
        BardicInspiration,
        DiscipleOfLife,
        WardingFlare,
        WrathOfTheStorm,
        BlessingOfTheTrickster,
        WarPriest,
        WildShape,
        MartialArts,
        DivineSense,
        LayOnHands,
        FavoredEnemy,
        NaturalExplorer,
        Expertise,
        SneakAttack,
        OtherWorldlyPatron,
        PactMagic,
        ArcaneRecovery
    }
}
