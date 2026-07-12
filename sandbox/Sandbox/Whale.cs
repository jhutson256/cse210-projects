using System;

public class Whale : Organism
{
    public override void Name()
    {
        Console.Write("Whale: ");
        BreathingType();
    }
    public override void BreathingType()
    {
        Console.Write("Blowhole");
    }
}