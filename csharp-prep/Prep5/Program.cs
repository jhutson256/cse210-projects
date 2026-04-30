using System;

class Program
{
    static void Main(string[] args)
    {
        jph_displayWelcome();

        string jph_userName = jph_promptUserName();
        int jph_userNumber = jph_promptUserNumber();

        int jph_squaredNumber = jph_squareNumber(jph_userNumber);

        int jph_birthYear;
        jph_promptUserBirthYear(out jph_birthYear);

        jph_displayResult(jph_userName, jph_squaredNumber, jph_birthYear);
    }

    static void jph_displayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string jph_promptUserName()
    {
        Console.Write("Please enter your name: ");
        string jph_name = Console.ReadLine();

        return jph_name;
    }

    static int jph_promptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        string jph_userInput = Console.ReadLine();
        int jph_userNumber = int.Parse(jph_userInput);

        return jph_userNumber;
    }

    static void jph_promptUserBirthYear(out int jph_birthYear)
    {
        Console.WriteLine("Please enter the year you were born: ");
        string jph_userInput = Console.ReadLine();
        jph_birthYear = int.Parse(jph_userInput);
    }

    static int jph_squareNumber(int jph_number)
    {
        int jph_square = jph_number * jph_number;
        return jph_square;
    }

    static void jph_displayResult(string jph_name, int jph_square, int jph_birthYear)
    {
        int jph_currentAge = 2026 - jph_birthYear;
        Console.WriteLine($"{jph_name}, the square of your number is {jph_square}.");
        Console.WriteLine($"{jph_name}, you will turn {jph_currentAge} years old this year.");
    }
}