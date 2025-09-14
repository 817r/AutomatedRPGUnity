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

public static class PersonalityUtility
{
    // Noble Personality Trait Ranges
    public const float pNoble_fAggresivenessMax = 0.7f;
    public const float pNoble_fAggresivenessMin = 0.2f;
    public const float pNoble_fCuriosityMax = 0.8f;
    public const float pNoble_fCuriosityMin = 0.3f;
    public const float pNoble_fLoyalMax = 0.9f;
    public const float pNoble_fLoyalMin = 0.1f;
    public const float pNoble_fGreedMax = 1f;
    public const float pNoble_fGreedMin = 0.4f;
    public const float pNoble_fBraveMax = 0.6f;
    public const float pNoble_fBraveMin = 0.1f;

    // Commoner Personality Trait Ranges
    public const float pCommoner_fAggresivenessMax = 0.8f;
    public const float pCommoner_fAggresivenessMin = 0.1f;
    public const float pCommoner_fCuriosityMax = 0.5f;
    public const float pCommoner_fCuriosityMin = 0.1f;
    public const float pCommoner_fLoyalMax = 0.9f;
    public const float pCommoner_fLoyalMin = 0.1f;
    public const float pCommoner_fGreedMax = 0.9f;
    public const float pCommoner_fGreedMin = 0.3f;
    public const float pCommoner_fBraveMax = 0.8f;
    public const float pCommoner_fBraveMin = 0.25f;

    // Outcast Personality Trait Ranges
    public const float pOutcast_fAggresivenessMax = 1f;
    public const float pOutcast_fAggresivenessMin = 0.4f;
    public const float pOutcast_fCuriosityMax = 0.9f;
    public const float pOutcast_fCuriosityMin = 0.3f;
    public const float pOutcast_fLoyalMax = 0.6f;
    public const float pOutcast_fLoyalMin = 0.1f;
    public const float pOutcast_fGreedMax = 0.8f;
    public const float pOutcast_fGreedMin = 0.2f;
    public const float pOutcast_fBraveMax = 0.9f;
    public const float pOutcast_fBraveMin = 0.3f;

    // Royal Personality Trait Ranges
    public const float pRoyal_fAggresivenessMax = 0.6f;
    public const float pRoyal_fAggresivenessMin = 0.1f;
    public const float pRoyal_fCuriosityMax = 0.7f;
    public const float pRoyal_fCuriosityMin = 0.2f;
    public const float pRoyal_fLoyalMax = 1f;
    public const float pRoyal_fLoyalMin = 0.3f;
    public const float pRoyal_fGreedMax = 0.9f;
    public const float pRoyal_fGreedMin = 0.4f;
    public const float pRoyal_fBraveMax = 0.7f;
    public const float pRoyal_fBraveMin = 0.2f;

    // Merchant Personality Trait Ranges
    public const float pMerchant_fAggresivenessMax = 0.7f;
    public const float pMerchant_fAggresivenessMin = 0.2f;
    public const float pMerchant_fCuriosityMax = 0.8f;
    public const float pMerchant_fCuriosityMin = 0.3f;
    public const float pMerchant_fLoyalMax = 0.8f;
    public const float pMerchant_fLoyalMin = 0.2f;
    public const float pMerchant_fGreedMax = 1f;
    public const float pMerchant_fGreedMin = 0.5f;
    public const float pMerchant_fBraveMax = 0.6f;
    public const float pMerchant_fBraveMin = 0.1f;

    // Warrior Personality Trait Ranges
    public const float pWarrior_fAggresivenessMax = 1f;
    public const float pWarrior_fAggresivenessMin = 0.5f;
    public const float pWarrior_fCuriosityMax = 0.6f;
    public const float pWarrior_fCuriosityMin = 0.1f;
    public const float pWarrior_fLoyalMax = 0.9f;
    public const float pWarrior_fLoyalMin = 0.2f;
    public const float pWarrior_fGreedMax = 0.7f;
    public const float pWarrior_fGreedMin = 0.2f;
    public const float pWarrior_fBraveMax = 1f;
    public const float pWarrior_fBraveMin = 0.5f;

    // Scholar Personality Trait Ranges
    public const float pScholar_fAggresivenessMax = 0.5f;
    public const float pScholar_fAggresivenessMin = 0.1f;
    public const float pScholar_fCuriosityMax = 1f;
    public const float pScholar_fCuriosityMin = 0.5f;
    public const float pScholar_fLoyalMax = 0.8f;
    public const float pScholar_fLoyalMin = 0.2f;
    public const float pScholar_fGreedMax = 0.6f;
    public const float pScholar_fGreedMin = 0.1f;
    public const float pScholar_fBraveMax = 0.7f;
    public const float pScholar_fBraveMin = 0.2f;

    // Artisan Personality Trait Ranges
    public const float pArtisan_fAggresivenessMax = 0.6f;
    public const float pArtisan_fAggresivenessMin = 0.1f;
    public const float pArtisan_fCuriosityMax = 0.9f;
    public const float pArtisan_fCuriosityMin = 0.3f;
    public const float pArtisan_fLoyalMax = 0.8f;
    public const float pArtisan_fLoyalMin = 0.2f;
    public const float pArtisan_fGreedMax = 0.7f;
    public const float pArtisan_fGreedMin = 0.2f;
    public const float pArtisan_fBraveMax = 0.6f;
    public const float pArtisan_fBraveMin = 0.1f;
}

public static class SkillUtility
{
    public const float maxGain = 10f;
    public const float minGain = 0.5f;
    public const int maxAmp = 8;
    public const int minAmp = 2;
}