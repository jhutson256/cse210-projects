using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment jph_assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(jph_assignment1.GetSummary());

        MathAssignment jph_assignment2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(jph_assignment2.GetSummary());
        Console.WriteLine(jph_assignment2.GetHomeworkList());

        WritingAssignment jph_assignment3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(jph_assignment3.GetSummary());
        Console.WriteLine(jph_assignment3.GetWritingInformation());
    }
}