using System;
/*
Name: Jacob Hutson
Date: 6/26/2026
Class: CSE 210
Description: The class that handles all of the checklist goal entries.
Sources:
1. Assignment Code Advice https://byui-cse.github.io/cse210-course-2023/unit05/develop.html
2. Gemini Code Advice
3. In Class Notes
*/

public class ChecklistGoal : Goal
{
    private int _jphCompleted;
    private int _jphTarget;
    private int _jphBonus;

    public ChecklistGoal(string jph_name, string jph_description, int jph_points, int jph_target, int jph_bonus) : base(jph_name, jph_description, jph_points)
    {
        _jphCompleted = 0;
        _jphTarget = jph_target;
        _jphBonus = jph_bonus;
    }

    public ChecklistGoal(string jph_name, string jph_description, int jph_points, int jph_completed, int jph_target, int jph_bonus) : base(jph_name, jph_description, jph_points)
    {
        _jphCompleted = jph_completed;
        _jphTarget = jph_target;
        _jphBonus = jph_bonus;
    }

    public override int RecordEvent()
    {
        if (_jphCompleted < _jphTarget)
        {
            _jphCompleted++;
            int jph_points = GetPoints();
            
            if (_jphCompleted == _jphTarget)
            {
                return jph_points + _jphBonus;
            }
            
            return jph_points;
        }

        return 0;
    }

    public override bool IsComplete()
    {
        return _jphCompleted >= _jphTarget;
    }

    public override string GetDetailsString()
    {
        string jph_statusCheckbox = IsComplete() ? "[X]" : "[ ]"; // 2.
        return $"{jph_statusCheckbox} {GetName()} ({GetDescription()}) -- Currently completed: {_jphCompleted}/{_jphTarget}";
    }

    public override string GetStringRepresentation() // 1.
    {
        return $"ChecklistGoal:{GetName()},{GetDescription()},{GetPoints()},{_jphCompleted},{_jphTarget},{_jphBonus}";
    }
}