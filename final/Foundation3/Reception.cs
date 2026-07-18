using System;
/*
Name: Jacob Hutson
Date: 7/18/2026
Class: CSE 210
Description: This class handles all of the reception information.
Sources: 
1. Gemini Code Advice
2. In Class Notes
*/

public class Reception : Event
{
    private string _jphRSVP;

    public Reception(string jph_title, string jph_description, string jph_date, string jph_time, Address jph_address, string jph_RSVP) : base(jph_title, jph_description, jph_date, jph_time, jph_address, "Reception")
    {
        _jphRSVP = jph_RSVP;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: {GetEventType()}\nRSVP Registration Email: {_jphRSVP}";
    }
}