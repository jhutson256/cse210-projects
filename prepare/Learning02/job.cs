using System;

public class jph_Job
{
    public string _jphjobTitle;
    public string _jphcompany;
    public int _jphstartYear;
    public int _jphendYear;

    public void Display()
    {
        Console.WriteLine($"{_jphjobTitle} ({_jphcompany}) {_jphstartYear}-{_jphendYear}");
    }
}