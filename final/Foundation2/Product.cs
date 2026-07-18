using System;
/*
Name: Jacob Hutson
Date: 7/11/2026
Class: CSE 210
Description: This class handles all individual product information.
Sources:
1. Gemini Code Advice
2. In Class Notes
*/

public class Product
{
    private string _jphName;
    private string _jphProductId;
    private double _jphPrice;
    private int _jphQuantity;

    public Product(string jph_name, string jph_productId, double jph_price, int jph_quantity)
    {
        _jphName = jph_name;
        _jphProductId = jph_productId;
        _jphPrice = jph_price;
        _jphQuantity = jph_quantity;
    }

    public string GetName()
    {
        return _jphName;
    }

    public string GetProductId()
    {
        return _jphProductId;
    }

    public double CalculateTotal()
    {
        return _jphPrice * _jphQuantity;
    }
}