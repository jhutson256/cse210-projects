using System;
/*
Name: Jacob Hutson
Date: 7/11/2026
Class: CSE 210
Description: This class handles all of the individual comment information.
Sources:
1. Gemini Code Advice
2. In Class Notes
*/

public class Comment
{
    public string _jphName;
    public string _jphText;

    public Comment(string jph_name, string jph_text)
    {
        _jphName = jph_name;
        _jphText = jph_text;
    }
}