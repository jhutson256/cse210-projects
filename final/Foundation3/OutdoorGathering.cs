using System;
/*
Name: Jacob Hutson
Date: 7/18/2026
Class: CSE 210
Description: This class handles all of the outdoor gathering information.
Sources:
1. Gemini Code Advice
2. In Class Notes
*/

public class OutdoorGathering : Event
{
    private string _jphWeather;
    
    public OutdoorGathering(string jph_title, string jph_description, string jph_date, string jph_time, Address jph_address, string jph_weather) : base(jph_title, jph_description, jph_date, jph_time, jph_address, "Outdoor Gathering")
    {
        _jphWeather = jph_weather;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: {GetEventType()}\nWeather Forecast: {_jphWeather}";
    }
}