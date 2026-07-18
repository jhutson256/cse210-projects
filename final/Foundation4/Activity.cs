using System;
/*
Name: Jacob Hutson
Date: 7/18/2026
Class: CSE 210
Description: This is the parent class of the program. The code marked with 1. was code advice from Google 
Gemini to help me format the numbers to specific decimal places when displaying the numbers to the user.
Sources:
1. Gemini Code Advice
2. In Class Notes
*/

public abstract class Activity
{
    private string _jphDate;
    private int _jphMinutes;
    private string _jphActivityType;

    public Activity(string jph_date, int jph_minutes, string jph_activityType)
    {
        _jphDate = jph_date;
        _jphMinutes = jph_minutes;
        _jphActivityType = jph_activityType;
    }

    public int GetMinutes() 
    {
        return _jphMinutes;
    }

    public string GetDate()
    {
        return _jphDate;
    }
    public string GetActivityType()
    {
        return _jphActivityType;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();
    
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_jphDate} {_jphActivityType} ({_jphMinutes} min) - " +
                $"Distance: {GetDistance():F1} miles, " + // 1.
                $"Speed: {GetSpeed():F1} mph, " + // 1.
                $"Pace: {GetPace():F2} min per mile"; // 1.
    }
}