using System;
/*
Name: Jacob Hutson
Date: 7/18/2026
Class: CSE 210
Description: This class handles all of the lecture information.
Sources:
1. Gemini Code Advice
2. In Class Notes
*/

public class Lecture : Event
{
    private string _jphSpeaker;
    private int _jphCapacity;

    public Lecture(string jph_title, string jph_description, string jph_date, string jph_time, Address jph_address, string jph_speaker, int jph_capacity) : base(jph_title, jph_description, jph_date, jph_time, jph_address, "Lecture")
    {
        _jphSpeaker = jph_speaker;
        _jphCapacity = jph_capacity;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: {GetEventType()}\nSpeaker: {_jphSpeaker}\nMax Capacity: {_jphCapacity} attendees";
    }
}