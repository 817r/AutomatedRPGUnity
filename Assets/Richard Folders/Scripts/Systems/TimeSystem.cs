using System;
using UnityEngine;

public class TimeSystem : MonoBehaviour
{
    [SerializeField] SeasonType currentSeason;
    public static TimeSystem instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static SimulationTime CurrentTime
    {
        get
        {
            return new SimulationTime
            {
                clock = new SimulationTimeClock
                {
                    hour = instance.currentHour,
                    minute = instance.currentMinute,
                    second = (int)instance.currentSecond
                },
                date = new SimulationTimeDate
                {
                    day = instance.currentDay,
                    month = instance.currentMonth,
                    year = instance.currentYear
                },
                seasonType = instance.currentSeason
            };
        }
    }
    [Space(15)]

    // Current Time
    [SerializeField] int currentHour;
    [SerializeField] int currentMinute;
    [SerializeField] float currentSecond;
    [SerializeField] int currentDay;
    [SerializeField] int currentMonth;
    [SerializeField] int currentYear;
    [Space(15)]

    // Configuration
    [SerializeField] int daysInMonth = 30;
    [SerializeField] int monthsInYear = 12;
    [SerializeField] int hoursInDay = 24;
    [SerializeField] int minutesInHour = 60;
    [SerializeField] int secondsInMinute = 60;
    [SerializeField] float realtimePerGameSecond = 1f;

    private void Update()
    {
        UpdateTime();
    }

    private void UpdateTime()
    {
        float gameSecondsPassed = Time.deltaTime / realtimePerGameSecond;
        currentSecond += gameSecondsPassed;
        if (currentSecond >= secondsInMinute)
        {
            currentSecond = 0;
            currentMinute++;
        }
        if (currentMinute >= minutesInHour)
        {
            currentMinute = 0;
            currentHour++;
        }
        if (currentHour >= hoursInDay)
        {
            currentHour = 0;
            currentDay++;
        }
        if (currentDay > daysInMonth)
        {
            currentDay = 1;
            currentMonth++;
        }
        if (currentMonth > monthsInYear)
        {
            currentMonth = 1;
            currentYear++;
        }
        UpdateSeason();
    }

    private void UpdateSeason()
    {
        if (currentMonth >= 3 && currentMonth <= 5)
        {
            currentSeason = SeasonType.Spring;
        }
        else if (currentMonth >= 6 && currentMonth <= 8)
        {
            currentSeason = SeasonType.Summer;
        }
        else if (currentMonth >= 9 && currentMonth <= 11)
        {
            currentSeason = SeasonType.Autumn;
        }
        else
        {
            currentSeason = SeasonType.Winter;
        }
    }
}

public enum SeasonType
{
    Spring,
    Summer,
    Autumn,
    Winter
}

[Serializable]
public class SimulationTime
{
    public SimulationTimeClock clock;

    public SimulationTimeDate date;
    [Space(15)]

    public SeasonType seasonType;
}

[Serializable]
public struct SimulationTimeDate
{
    [Range(1,30)]public int day;
    [Range(1,12)]public int month;
    public int year;
}

[Serializable]
public struct SimulationTimeClock
{
    [Range(1, 24)] public int hour;
    [Range(1, 60)] public int minute;
    [Range(1, 60)] public int second;
}