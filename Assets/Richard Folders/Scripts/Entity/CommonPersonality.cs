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
    public TalentValues[] talentValues;
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