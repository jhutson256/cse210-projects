using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction jph_fraction1 = new Fraction();
        Console.WriteLine(jph_fraction1.FractionString());
        Console.WriteLine(jph_fraction1.GetDecimal());

        Fraction jph_fraction2 = new Fraction(5);
        Console.WriteLine(jph_fraction2.FractionString());
        Console.WriteLine(jph_fraction2.GetDecimal());

        Fraction jph_fraction3 = new Fraction(3, 4);
        Console.WriteLine(jph_fraction3.FractionString());
        Console.WriteLine(jph_fraction3.GetDecimal());

        Fraction jph_fraction4 = new Fraction(1, 3);
        Console.WriteLine(jph_fraction4.FractionString());
        Console.WriteLine(jph_fraction4.GetDecimal());

        Random jph_randomNumber = new Random();
        Fraction jph_fraction5 = new Fraction();
        
        for (int i = 0; i < 20; i++)
        {
            int jph_numeratorValue = jph_randomNumber.Next(1, 11);
            int jph_denominatorValue = jph_randomNumber.Next(1, 11);
            jph_fraction5.SetNumerator(jph_numeratorValue);
            jph_fraction5.SetDenominator(jph_denominatorValue);
            Console.Write($"Fraction {i + 1}: ");
            Console.Write($"string: {jph_fraction5.FractionString()}");
            Console.WriteLine($" Number: {jph_fraction5.GetDecimal()}");
        }
    }
}