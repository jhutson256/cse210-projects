using System;
/*
Name: Jacob Hutson
Date: 7/11/2026
Class: CSE 210
Description: This class handles all individual customer information.
Sources:
1. Gemini Code Advice
2. In Class Notes
*/

public class Customer
{
    private string _jphName;
    private Address _jphAddress;

    public Customer(string jph_name, Address jph_address)
    {
        _jphName = jph_name;
        _jphAddress = jph_address;
    }

    public string GetName()
    {
        return _jphName;
    }

    public Address GetAddress()
    {
        return _jphAddress;
    }

    public bool LivesInUsa()
    {
        return _jphAddress.IsInUsa();
    }
}