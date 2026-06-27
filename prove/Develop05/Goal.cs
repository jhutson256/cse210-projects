using System;
/*
Name: Jacob Hutson
Date: 6/26/2026
Class: CSE 210
Description: The parent class for all of the goal classes. This class handles all of the attributes 
and methods shared by all derived classes.
Sources:
1. Assignment Code Advice https://byui-cse.github.io/cse210-course-2023/unit05/develop.html
2. Gemini Code Advice
3. In Class Notes
*/

public abstract class Goal
{
    private string _jphName;
    private string _jphDescription;
    private int _jphPoints;

    public Goal()
    {
        _jphName = "";
        _jphDescription = "";
        _jphPoints = 0;
    }

    public Goal(string jph_name, string jph_description, int jph_points)
    {
        _jphName = jph_name;
        _jphDescription = jph_description;
        _jphPoints = jph_points;
    }

    public string GetName()
    {
        return _jphName;
    }

    public string GetDescription()
    {
        return _jphDescription;
    }

    public int GetPoints()
    {
        return _jphPoints;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation(); // 1.

    public virtual string GetDetailsString()
    {
        string jph_statusCheckbox = IsComplete() ? "[X]" : "[ ]"; // 2.
        return $"{jph_statusCheckbox} {_jphName} ({_jphDescription})";
    }
}