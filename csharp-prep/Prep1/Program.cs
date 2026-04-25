using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string jph_firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string jhp_lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {jhp_lastName}, {jph_firstName} {jhp_lastName}.");
    }
}