using System;
/*
Name: Jacob Hutson
Date: 7/18/2026
Class: CSE 210
Description: This class handles all of the address information for the program.
Sources:
1. Gemini Code Advice
2. In Class Notes
*/

public class Address
{
    private string _jphStreetAddress;
    private string _jphCity;
    private string _jphStateProvince;
    private string _jphCountry;

    public Address(string jph_streetAddress, string jph_city, string jph_stateProvince, string jph_country)
    {
        _jphStreetAddress = jph_streetAddress;
        _jphCity = jph_city;
        _jphStateProvince = jph_stateProvince;
        _jphCountry = jph_country;
    }

    public string GetFormattedAddress()
    {
        return $"{_jphStreetAddress}, {_jphCity}, {_jphStateProvince}, {_jphCountry}";
    }
}