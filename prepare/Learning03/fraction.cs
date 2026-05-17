using System;

public class Fraction
{
    private int _jphNumerator;
    private int _jphDenominator;

    public Fraction()
    {
        _jphNumerator = 1;
        _jphDenominator = 1;
    }

    public Fraction(int jph_wholeNumber)
    {
        _jphNumerator = jph_wholeNumber;
        _jphDenominator = 1;
    }

    public Fraction(int jph_topNumber, int jph_bottomNumber)
    {
        _jphNumerator = jph_topNumber;
        SetDenominator(jph_bottomNumber);
    }

    public void SetDenominator(int jph_bottomNumber)
    {
        if (jph_bottomNumber != 0)
        {
            _jphDenominator = jph_bottomNumber;
        }
        else
        {
            _jphDenominator = 1;
        }
    }

    public void SetNumerator(int jph_topNumber)
    {
        _jphNumerator = jph_topNumber;
    }

    public int GetNumerator()
    {
        return _jphNumerator;
    }

    public int GetDenominator()
    {
        return _jphDenominator;
    }

    public string FractionString()
    {
        return $"{_jphNumerator}/{_jphDenominator}";
    }

    public double GetDecimal()
    {
        return (double)_jphNumerator / (double)_jphDenominator;
    }
}