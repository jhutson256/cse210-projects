using System;
/*
Name: Jacob Hutson
Date: 7/18/2026
Class: CSE 210
Description: This class handles all of the cycling activity information.
Sources:
1. Gemini Code Advice
2. In Class Notes
*/

public class Cycling : Activity
{
    private double _jphSpeed;

    public Cycling(string jph_date, int jph_minutes, double jph_speed) : base(jph_date, jph_minutes, "Cycling")
    {
        _jphSpeed = jph_speed;
    }

    public override double GetDistance()
    {
        return (_jphSpeed * GetMinutes()) / 60;
    }

    public override double GetSpeed()
    {
        return _jphSpeed;
    }

    public override double GetPace()
    {
        return 60 / _jphSpeed;
    }
}