using System;
/*
Name: Jacob Hutson
Date: 7/18/2026
Class: CSE 210
Description: This is the parent class of the program.
Sources:
1. Gemini Code Advice
2. In Class Notes
*/

public abstract class Event
{
    private string _jphTitle;
    private string _jphDescription;
    private string _jphDate;
    private string _jphTime;
    private Address _jphAddress;
    private string _jphEventType;

    public Event(string jph_title, string jph_description, string jph_date, string jph_time, Address jph_address, string jph_eventType)
    {
        _jphTitle = jph_title;
        _jphDescription = jph_description;
        _jphDate = jph_date;
        _jphTime = jph_time;
        _jphAddress = jph_address;
        _jphEventType = jph_eventType;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_jphTitle}\nDescription: {_jphDescription}\nDate: {_jphDate}\nTime: {_jphTime}\nLocation: {_jphAddress.GetFormattedAddress()}";
    }

    public string GetShortDescription()
    {
        return $"Type: {_jphEventType} | Title: {_jphTitle} | Date: {_jphDate}";
    }

    public abstract string GetFullDetails();

    public string GetEventType()
    {
        return _jphEventType;
    }
}