using System;

class Program
{
    static void Main(string[] args)
    {
        Organism o1 = new Organism();
        Organism o2 = new Mammal();
        Organism o3 = new Whale();
        Mammal o4 = new Mammal();
        Whale o6 = new Whale();

        o1.Name();
        o2.Name();
        o3.Name();
        o4.Name();
        o6.Name();
    }
}