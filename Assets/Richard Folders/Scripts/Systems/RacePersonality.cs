using UnityEngine;

public class RacePersonality : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public enum RaceType
{
    Human,
    Elf,
    Drawf,
    Orc,
    Fae,
    Beastkin
}

public enum ElementAffinity
{
    Fire,
    Water,
    Earth,
    Air,
    Light,
    Dark
}

public enum CharacterSpeciality
{
    MagicAffinity,
    IndustryAffinity,
    NatureAffinity,
    CombatAffinity,
    CraftingAffinity,
    SurvivalAffinity,
    AdaptationAffinity,
    AgricultureAffinity,
    DiplomacyAffinity,
    StabilityAffinity
}

public enum Lineage
{
    Noble,
    Commoner,
    Outcast,
    Royal,
    Merchant,
    Warrior,
    Scholar,
    Artisan
}

public enum InateTalent
{
    Leadership,
    Stealth,
    Strength,
    Intelligence,
    Charisma,
    Endurance,
    Agility,
    Wisdom
}

public enum TalentType
{
    Leadership,
    Stealth,
    Strength,
    Intelligence,
    Charisma,
    Endurance,
    Agility,
    Wisdom
}