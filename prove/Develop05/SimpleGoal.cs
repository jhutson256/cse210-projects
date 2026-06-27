using System;
/*
Name: Jacob Hutson
Date: 6/26/2026
Class: CSE 210
Description: The class that handles all of the simple goal entries.
Sources:
1. Assignment Code Advice https://byui-cse.github.io/cse210-course-2023/unit05/develop.html
2. Gemini Code Advice
3. In Class Notes
*/

public class SimpleGoal : Goal
{
    private bool _jphIsComplete;

    public SimpleGoal(string jph_name, string jph_description, int jph_points) : base(jph_name, jph_description, jph_points)
    {
        _jphIsComplete = false;
    }

    public SimpleGoal(string jph_name, string jph_description, int jph_points, bool jph_isComplete) : base(jph_name, jph_description, jph_points)
    {
        _jphIsComplete = jph_isComplete;
    }

    public override int RecordEvent()
    {
        if (!_jphIsComplete)
        {
            _jphIsComplete = true;
            int jph_points = GetPoints();
            return jph_points;
        }
        
        return 0;
    }

    public override bool IsComplete()
    {
        return _jphIsComplete;
    }

    public override string GetStringRepresentation() // 1.
    {
        return $"SimpleGoal:{GetName()},{GetDescription()},{GetPoints()},{_jphIsComplete}";
    }
}