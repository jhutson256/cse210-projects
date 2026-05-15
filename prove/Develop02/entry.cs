using System;
// 1. Assignment page, code helps section, https://byui-cse.github.io/cse210-course-2023/unit02/develop.html
// 2. Gemini code advice

public class jph_Entry
{
    public string _jphResponse;
    public DateTime _theCurrentTime = DateTime.Now; // 1.
    public jph_Prompt _jphEntryPrompt = new jph_Prompt();
    public string _jphPrompt;

    public void DisplayPrompt()
    {
        _jphPrompt = _jphEntryPrompt.GetPrompt();
        Console.WriteLine(_theCurrentTime);
        Console.WriteLine(_jphPrompt);
        Console.Write("> ");
        _jphResponse = Console.ReadLine();
    }

    public override string ToString()
    {
        return $"{_theCurrentTime} \n {_jphPrompt} \n {_jphResponse}";
    }

    public string ToCSV()
    {
        return $"{_theCurrentTime} || {_jphPrompt} || {_jphResponse}";
    }

    public string FromCSV(DateTime jph_dateTime, string jph_csvPrompt, string jph_csvResponse)
    {
        _theCurrentTime = jph_dateTime;
        _jphPrompt = jph_csvPrompt;
        _jphResponse = jph_csvResponse;

        return $"{_theCurrentTime} || {_jphPrompt} || {_jphResponse}";
    }

    public string CalculateDaysSinceEntry()
    {
        DateTime jph_today = DateTime.Today;
        TimeSpan difference = jph_today - _theCurrentTime; // 2.
        int jph_days = difference.Days; // 2.

        return $"It has been {jph_days} days since this entry.";
    }
}