using System;
using UnityEngine;

public class Profile : MonoBehaviour
{
    [SerializeField] string Name;
    [SerializeField] string surname;
    [SerializeField] RaceType raceType;
    [SerializeField] SimulationTimeDate birthDate;
    [SerializeField] Genetics genetics;


    // ~ Constructors ~ //
    public Profile(string Ename, string Esurname, RaceType ErType, SimulationTimeDate EdateOfBirth, Genetics Egen)
    {
       Name = Ename;
       surname = Esurname;
       raceType = ErType;
       birthDate = EdateOfBirth;
       genetics = Egen;
    }
}

[Serializable]
public struct PhysicalAppareance
{
    public int height;
    public int weight;

    public PhysicalAppareance(int Eheight, int Eweight)
    {
        height = Eheight;
        weight = Eweight;
    }
}

[Serializable]
public class Genetics
{
    public PhysicalAppareance physicalAppareance;
    public BloodType bloodType;

    public Genetics(PhysicalAppareance EphysApp, BloodType EbloodType)
    {
        physicalAppareance = EphysApp;
        bloodType = EbloodType;
    }
}

public enum BloodType
{
    A_Positive,
    A_Negative,
    B_Positive,
    B_Negative,
    AB_Positive,
    AB_Negative,
    O_Positive,
    O_Negative
}