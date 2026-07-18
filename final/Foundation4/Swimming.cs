using System;
/*
Name: Jacob Hutson
Date: 7/18/2026
Class: CSE 210
Description: This class handles all of the swimming activity information.
Sources:
1. Gemini Code Advice
2. In Class Notes
*/

public class Swimming : Activity
{
    private int _jphLaps;

    public Swimming(string jph_date, int jph_minutes, int jph_laps) : base(jph_date, jph_minutes, "Swimming")
    {
        _jphLaps = jph_laps;
    }

    public override double GetDistance()
    {
        return _jphLaps * 50.0 / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}