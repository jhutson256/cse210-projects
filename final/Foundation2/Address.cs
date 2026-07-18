using System;
/*
Name: Jacob Hutson
Date: 7/11/2026
Class: CSE 210
Description: This class handles all address information, including checking if the address is domestic or 
international.
Sources:
1. Gemini Code Advice
2. In Class Notes
*/

public class Address
{
    private string _jphAddress;
    private string _jphCity;
    private string _jphStateProvince;
    private string _jphCountry;

    public Address(string jph_address, string jph_city, string jph_stateProvince, string jph_country)
    {
        _jphAddress = jph_address;
        _jphCity = jph_city;
        _jphStateProvince = jph_stateProvince;
        _jphCountry = jph_country;
    }

    public bool IsInUsa()
    {
        return _jphCountry.Trim().Equals("USA", StringComparison.OrdinalIgnoreCase) || 
                _jphCountry.Trim().Equals("United States", StringComparison.OrdinalIgnoreCase);
    }

    public override string ToString()
    {
        return $"{_jphAddress}\n{_jphCity}, {_jphStateProvince}\n{_jphCountry}";
    }
}