using System;

public class Organism
{
    public virtual void Name()
    {
        Console.Write("Organism: ");
        BreathingType();
    }
    public virtual void BreathingType()
    {
        Console.Write("Generic");
    }
}