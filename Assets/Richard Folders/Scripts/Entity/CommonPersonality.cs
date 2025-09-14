using UnityEngine;
using System;

public class CommonPersonality : MonoBehaviour
{
    public Trait traits;

    private void Start()
    {
        InitializeTrait();
    }

    protected void InitializeTrait()
    {
        traits = new Trait();
        traits.coreTrait = EntityManager.instance.GetRandomCoreTrait();
        traits.dynamicTrait = InitializeDynamicTrait();
    }

    protected DynamicTrait InitializeDynamicTrait()
    {
        DynamicTrait dynamicTrait = new DynamicTrait();
        switch (traits.coreTrait.lineage)
        {
            case Lineage.Noble:
                dynamicTrait.personalityTraits.Aggresiveness = UnityEngine.Random.Range(PersonalityUtility.pNoble_fAggresivenessMin, PersonalityUtility.pNoble_fAggresivenessMin);
                dynamicTrait.personalityTraits.Curiosity = UnityEngine.Random.Range(PersonalityUtility.pNoble_fCuriosityMin, PersonalityUtility.pNoble_fCuriosityMax);
                dynamicTrait.personalityTraits.Loyal = UnityEngine.Random.Range(PersonalityUtility.pNoble_fLoyalMin, PersonalityUtility.pNoble_fLoyalMax);
                dynamicTrait.personalityTraits.Greedy = UnityEngine.Random.Range(PersonalityUtility.pNoble_fGreedMin, PersonalityUtility.pNoble_fGreedMax);
                dynamicTrait.personalityTraits.Brave = UnityEngine.Random.Range(PersonalityUtility.pNoble_fBraveMin, PersonalityUtility.pNoble_fBraveMax);
                break;
            case Lineage.Commoner:
                dynamicTrait.personalityTraits.Aggresiveness = UnityEngine.Random.Range(PersonalityUtility.pCommoner_fAggresivenessMin, PersonalityUtility.pCommoner_fAggresivenessMax);
                dynamicTrait.personalityTraits.Curiosity = UnityEngine.Random.Range(PersonalityUtility.pCommoner_fCuriosityMin, PersonalityUtility.pCommoner_fCuriosityMax);
                dynamicTrait.personalityTraits.Loyal = UnityEngine.Random.Range(PersonalityUtility.pCommoner_fLoyalMin, PersonalityUtility.pCommoner_fLoyalMax);
                dynamicTrait.personalityTraits.Greedy = UnityEngine.Random.Range(PersonalityUtility.pCommoner_fGreedMin, PersonalityUtility.pCommoner_fGreedMax);
                dynamicTrait.personalityTraits.Brave = UnityEngine.Random.Range(PersonalityUtility.pCommoner_fBraveMin, PersonalityUtility.pCommoner_fBraveMax);
                break;
            case Lineage.Outcast:
                dynamicTrait.personalityTraits.Aggresiveness = UnityEngine.Random.Range(PersonalityUtility.pOutcast_fAggresivenessMin, PersonalityUtility.pOutcast_fAggresivenessMax);
                dynamicTrait.personalityTraits.Curiosity = UnityEngine.Random.Range(PersonalityUtility.pOutcast_fCuriosityMin, PersonalityUtility.pOutcast_fCuriosityMax);
                dynamicTrait.personalityTraits.Loyal = UnityEngine.Random.Range(PersonalityUtility.pOutcast_fLoyalMin, PersonalityUtility.pOutcast_fLoyalMax);
                dynamicTrait.personalityTraits.Greedy = UnityEngine.Random.Range(PersonalityUtility.pOutcast_fGreedMin, PersonalityUtility.pOutcast_fGreedMax);
                dynamicTrait.personalityTraits.Brave = UnityEngine.Random.Range(PersonalityUtility.pOutcast_fBraveMin, PersonalityUtility.pOutcast_fBraveMax);
                break;
            case Lineage.Royal:
                dynamicTrait.personalityTraits.Aggresiveness = UnityEngine.Random.Range(PersonalityUtility.pRoyal_fAggresivenessMin, PersonalityUtility.pRoyal_fAggresivenessMax);
                dynamicTrait.personalityTraits.Curiosity = UnityEngine.Random.Range(PersonalityUtility.pRoyal_fCuriosityMin, PersonalityUtility.pRoyal_fCuriosityMax);
                dynamicTrait.personalityTraits.Loyal = UnityEngine.Random.Range(PersonalityUtility.pRoyal_fLoyalMin, PersonalityUtility.pRoyal_fLoyalMax);
                dynamicTrait.personalityTraits.Greedy = UnityEngine.Random.Range(PersonalityUtility.pRoyal_fGreedMin, PersonalityUtility.pRoyal_fGreedMax);
                dynamicTrait.personalityTraits.Brave = UnityEngine.Random.Range(PersonalityUtility.pRoyal_fBraveMin, PersonalityUtility.pRoyal_fBraveMax);
                break;
            case Lineage.Merchant:
                dynamicTrait.personalityTraits.Aggresiveness = UnityEngine.Random.Range(PersonalityUtility.pMerchant_fAggresivenessMin, PersonalityUtility.pMerchant_fAggresivenessMax);
                dynamicTrait.personalityTraits.Curiosity = UnityEngine.Random.Range(PersonalityUtility.pMerchant_fCuriosityMin, PersonalityUtility.pMerchant_fCuriosityMax);
                dynamicTrait.personalityTraits.Loyal = UnityEngine.Random.Range(PersonalityUtility.pMerchant_fLoyalMin, PersonalityUtility.pMerchant_fLoyalMax);
                dynamicTrait.personalityTraits.Greedy = UnityEngine.Random.Range(PersonalityUtility.pMerchant_fGreedMin, PersonalityUtility.pMerchant_fGreedMax);
                dynamicTrait.personalityTraits.Brave = UnityEngine.Random.Range(PersonalityUtility.pMerchant_fBraveMin, PersonalityUtility.pMerchant_fBraveMax);
                break;
            case Lineage.Warrior:
                dynamicTrait.personalityTraits.Aggresiveness = UnityEngine.Random.Range(PersonalityUtility.pWarrior_fAggresivenessMin, PersonalityUtility.pWarrior_fAggresivenessMax);
                dynamicTrait.personalityTraits.Curiosity = UnityEngine.Random.Range(PersonalityUtility.pWarrior_fCuriosityMin, PersonalityUtility.pWarrior_fCuriosityMax);
                dynamicTrait.personalityTraits.Loyal = UnityEngine.Random.Range(PersonalityUtility.pWarrior_fLoyalMin, PersonalityUtility.pWarrior_fLoyalMax);
                dynamicTrait.personalityTraits.Greedy = UnityEngine.Random.Range(PersonalityUtility.pWarrior_fGreedMin, PersonalityUtility.pWarrior_fGreedMax);
                dynamicTrait.personalityTraits.Brave = UnityEngine.Random.Range(PersonalityUtility.pWarrior_fBraveMin, PersonalityUtility.pWarrior_fBraveMax);
                break;
            case Lineage.Scholar:
                dynamicTrait.personalityTraits.Aggresiveness = UnityEngine.Random.Range(PersonalityUtility.pScholar_fAggresivenessMin, PersonalityUtility.pScholar_fAggresivenessMax);
                dynamicTrait.personalityTraits.Curiosity = UnityEngine.Random.Range(PersonalityUtility.pScholar_fCuriosityMin, PersonalityUtility.pScholar_fCuriosityMax);
                dynamicTrait.personalityTraits.Loyal = UnityEngine.Random.Range(PersonalityUtility.pScholar_fLoyalMin, PersonalityUtility.pScholar_fLoyalMax);
                dynamicTrait.personalityTraits.Greedy = UnityEngine.Random.Range(PersonalityUtility.pScholar_fGreedMin, PersonalityUtility.pScholar_fGreedMax);
                dynamicTrait.personalityTraits.Brave = UnityEngine.Random.Range(PersonalityUtility.pScholar_fBraveMin, PersonalityUtility.pScholar_fBraveMax);
                break;
            case Lineage.Artisan:
                dynamicTrait.personalityTraits.Aggresiveness = UnityEngine.Random.Range(PersonalityUtility.pArtisan_fAggresivenessMin, PersonalityUtility.pArtisan_fAggresivenessMax);
                dynamicTrait.personalityTraits.Curiosity = UnityEngine.Random.Range(PersonalityUtility.pArtisan_fCuriosityMin, PersonalityUtility.pArtisan_fCuriosityMax);
                dynamicTrait.personalityTraits.Loyal = UnityEngine.Random.Range(PersonalityUtility.pArtisan_fLoyalMin, PersonalityUtility.pArtisan_fLoyalMax);
                dynamicTrait.personalityTraits.Greedy = UnityEngine.Random.Range(PersonalityUtility.pArtisan_fGreedMin, PersonalityUtility.pArtisan_fGreedMax);
                dynamicTrait.personalityTraits.Brave = UnityEngine.Random.Range(PersonalityUtility.pArtisan_fBraveMin, PersonalityUtility.pArtisan_fBraveMax);
                break;
        }

        for (int i = 0; i < traits.coreTrait.characterSpecialities.Length; i++)
        {
            switch(traits.coreTrait.characterSpecialities[i])
            {
                case CharacterSpeciality.MagicAffinity:
                    dynamicTrait.skillAndStats.Intelligence += Mathf.RoundToInt(UnityEngine.Random.Range(SkillUtility.minGain, SkillUtility.maxGain));
                    break;
                case CharacterSpeciality.IndustryAffinity:
                    dynamicTrait.skillAndStats.Endurance += Mathf.RoundToInt(UnityEngine.Random.Range(SkillUtility.minGain, SkillUtility.maxGain));
                    break;
                case CharacterSpeciality.NatureAffinity:
                    dynamicTrait.skillAndStats.Agility += Mathf.RoundToInt(UnityEngine.Random.Range(SkillUtility.minGain, SkillUtility.maxGain));
                    break;
                case CharacterSpeciality.CombatAffinity:
                    dynamicTrait.skillAndStats.Strength += Mathf.RoundToInt(UnityEngine.Random.Range(SkillUtility.minGain, SkillUtility.maxGain));
                    break;
                case CharacterSpeciality.CraftingAffinity:
                    dynamicTrait.skillAndStats.Wisdom += Mathf.RoundToInt(UnityEngine.Random.Range(SkillUtility.minGain, SkillUtility.maxGain));
                    break;
                case CharacterSpeciality.SurvivalAffinity:
                    dynamicTrait.skillAndStats.Endurance += Mathf.RoundToInt(UnityEngine.Random.Range(SkillUtility.minGain, SkillUtility.maxGain));
                    break;
                case CharacterSpeciality.AdaptationAffinity:
                    dynamicTrait.skillAndStats.Agility += Mathf.RoundToInt(UnityEngine.Random.Range(SkillUtility.minGain, SkillUtility.maxGain));
                    break;
                case CharacterSpeciality.AgricultureAffinity:
                    dynamicTrait.skillAndStats.Wisdom += Mathf.RoundToInt(UnityEngine.Random.Range(SkillUtility.minGain, SkillUtility.maxGain));
                    break;
                case CharacterSpeciality.DiplomacyAffinity:
                    dynamicTrait.skillAndStats.Charisma += Mathf.RoundToInt(UnityEngine.Random.Range(SkillUtility.minGain, SkillUtility.maxGain));
                    break;
                case CharacterSpeciality.StabilityAffinity:
                    dynamicTrait.skillAndStats.Leadership += Mathf.RoundToInt(UnityEngine.Random.Range(SkillUtility.minGain, SkillUtility.maxGain));
                    break;
            }
        }

        foreach (InateTalent talent in traits.coreTrait.inateTalents)
        {
            switch (talent)
            {
                case InateTalent.Leadership:
                    dynamicTrait.skillAndStats.Leadership *= Mathf.RoundToInt(UnityEngine.Random.Range(SkillUtility.minAmp, SkillUtility.maxAmp));
                    break;
                case InateTalent.Stealth:
                    dynamicTrait.skillAndStats.Stealth *= Mathf.RoundToInt(UnityEngine.Random.Range(SkillUtility.minAmp, SkillUtility.maxAmp));
                    break;
                case InateTalent.Strength:
                    dynamicTrait.skillAndStats.Strength *= Mathf.RoundToInt(UnityEngine.Random.Range(SkillUtility.minAmp, SkillUtility.maxAmp));
                    break;
                case InateTalent.Intelligence:
                    dynamicTrait.skillAndStats.Intelligence *= Mathf.RoundToInt(UnityEngine.Random.Range(SkillUtility.minAmp, SkillUtility.maxAmp));
                    break;
                case InateTalent.Charisma:
                    dynamicTrait.skillAndStats.Charisma *= Mathf.RoundToInt(UnityEngine.Random.Range(SkillUtility.minAmp, SkillUtility.maxAmp));
                    break;
                case InateTalent.Endurance:
                    dynamicTrait.skillAndStats.Endurance *= Mathf.RoundToInt(UnityEngine.Random.Range(SkillUtility.minAmp, SkillUtility.maxAmp));
                    break;
                case InateTalent.Agility:
                    dynamicTrait.skillAndStats.Agility *= Mathf.RoundToInt(UnityEngine.Random.Range(SkillUtility.minAmp, SkillUtility.maxAmp));
                    break;
                case InateTalent.Wisdom:
                    dynamicTrait.skillAndStats.Wisdom *= Mathf.RoundToInt(UnityEngine.Random.Range(SkillUtility.minAmp, SkillUtility.maxAmp));
                    break;
            }
        }

        return dynamicTrait;
    }
}

[Serializable]
public class Trait
{
    public RaceType raceType;
    public CoreTrait coreTrait;
    public DynamicTrait dynamicTrait;
    public ExternalTrait externalTrait;
    public SocialTrait socialTrait;
}

[Serializable]
public class CoreTrait
{
    public Lineage lineage;
    public CharacterSpeciality[] characterSpecialities;
    public InateTalent[] inateTalents;
}

[Serializable]
public class DynamicTrait
{
    public PersonalityTraits personalityTraits;
    public SkillAndStats skillAndStats;
    public CulturalAlignment culturalAlignment;
    public LifeExperienceTraits lifeExperienceTraits;

    public DynamicTrait()
    {
        personalityTraits = new PersonalityTraits();
        skillAndStats = new SkillAndStats();
        culturalAlignment = new CulturalAlignment();
        lifeExperienceTraits = new LifeExperienceTraits();
    }
}

[Serializable]
public class ExternalTrait
{
}

[Serializable]
public class SocialTrait
{
    public int Reputation;
    public int Influence;
    public Relationship[] relationships;
}

[Serializable]
public class PersonalityTraits
{
    [Range(0,1)] public float Aggresiveness; // 0 to 1
    [Range(0,1)] public float Curiosity; // 0 to 1
    [Range(0,1)] public float Loyal; // 0 to 1
    [Range(0,1)] public float Greedy; // 0 to 1
    [Range(0,1)] public float Brave; // 0 to 1
}

[Serializable]
public class SkillAndStats
{
    public float Leadership = 10;
    public float Stealth = 10;
    public float Strength = 10;
    public float Intelligence = 10;
    public float Charisma = 10;
    public float Endurance = 10;
    public float Agility = 10;
    public float Wisdom = 10;
}

[Serializable]
public class TalentValues
{
    public TalentType talentType;
    public int Value;
}

[Serializable]
public class CulturalAlignment
{
    public float Religious;
    public float Nationalistic;
    public float Traditional;
    public float Collectivist;
}

[Serializable]
public class LifeExperienceTraits
{
    public LifeEvents[] lifeEvents;
}

[Serializable]
public class LifeEvents
{
    public string eventName;
    [TextArea()]public string eventDescription;
    public SimulationTime eventDate;

    public LifeEvents(string name, string description, SimulationTime date)
    {
        eventName = name;
        eventDescription = description;
        eventDate = date;
    }
}

[Serializable]
public class Relationship
{
    public string personName; // Switch to a unique ID system later
    public RelationshipType relationshipType;
    public int relationshipStrength;
}

public enum RelationshipType
{
    Family,
    Friend,
    Acquaintance,
    Rival,
    Enemy,
    Romantic
}