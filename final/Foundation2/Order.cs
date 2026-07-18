using System;
using System.Collections.Generic; // 1.
using System.Text; // 1.
/*
Name: Jacob Hutson
Date: 7/11/2026
Class: CSE 210
Description: This class handles all order information.
Sources:
1. Gemini Code Advice
2. In Class Notes
*/

public class Order
{
    private List<Product> _jphProducts;
    private Customer _jphCustomer;

    public Order(Customer jph_customer)
    {
        _jphCustomer = jph_customer;
        _jphProducts = new List<Product>();
    }

    public void AddProduct(Product jph_product)
    {
        _jphProducts.Add(jph_product);
    }

    public double CalculateSubtotal()
    {
        double jph_subtotal = 0;
        foreach (Product jph_product in _jphProducts)
        {
            jph_subtotal += jph_product.CalculateTotal();
        }

        // Standard rules: $5 for domestic, $35 for international
        double jph_shippingCost = _jphCustomer.LivesInUsa() ? 5.00 : 35.00;

        return jph_subtotal + jph_shippingCost;
    }

    public string GeneratePackingLabel()
    {
        StringBuilder sb = new StringBuilder(); // 1.
        sb.AppendLine("============ PACKING LABEL ============"); // 1.
        foreach (Product jph_product in _jphProducts)
        {
            sb.AppendLine($"Product: {jph_product.GetName()} (ID: {jph_product.GetProductId()})"); // 1.
        }
        sb.AppendLine("======================================="); // 1.
        return sb.ToString(); // 1.
    }

    public string GenerateShippingLabel()
    {
        StringBuilder sb = new StringBuilder(); // 1.
        sb.AppendLine("=========== SHIPPING LABEL ============"); // 1.
        sb.AppendLine(_jphCustomer.GetName()); // 1.
        sb.AppendLine(_jphCustomer.GetAddress().ToString()); // 1.
        sb.AppendLine("======================================="); // 1.
        return sb.ToString(); // 1.
    }
}