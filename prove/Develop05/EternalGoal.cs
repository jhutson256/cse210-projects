using System;
/*
Name: Jacob Hutson
Date: 6/26/2026
Class: CSE 210
Description: The class that handles all of the eternal goal entries.
Sources:
1. Assignment Code Advice https://byui-cse.github.io/cse210-course-2023/unit05/develop.html
2. Gemini Code Advice
3. In Class Notes
*/

public class EternalGoal : Goal
{
    public EternalGoal(string jph_name, string jph_description, int jph_points) : base(jph_name, jph_description, jph_points)
    {
    }

    public override int RecordEvent()
    {
        int jph_points = GetPoints();
        return jph_points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation() // 1.
    {
        return $"EternalGoal:{GetName()},{GetDescription()},{GetPoints()}";
    }
}