using System;
/*
Name: Jacob Hutson
Date: 7/18/2026
Class: CSE 210
Description: This class handles all of the running activity information.
Sources:
1. Gemini Code Advice
2. In Class Notes
*/

public class Running : Activity
{
    private double _jphDistance;

    public Running(string jph_date, int jph_minutes, double jph_distance) : base(jph_date, jph_minutes, "Running")
    {
        _jphDistance = jph_distance;
    }

    public override double GetDistance()
    {
        return _jphDistance;
    }

    public override double GetSpeed()
    {
        return (_jphDistance / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / _jphDistance;
    }
}