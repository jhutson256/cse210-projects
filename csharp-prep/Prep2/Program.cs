using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string jph_value = Console.ReadLine();
        int jph_percent = int.Parse(jph_value);

        string jph_letterGrade = "";

        if (jph_percent >= 90)
        {
            jph_letterGrade = "A";
        }
        else if (jph_percent >= 80)
        {
            jph_letterGrade = "B";
        }
        else if (jph_percent >= 70)
        {
            jph_letterGrade = "C";
        }
        else if (jph_percent >= 60)
        {
            jph_letterGrade = "D";
        }
        else
        {
            jph_letterGrade = "F";
        }

        string jph_letterSign = "";
        int jph_remainder = jph_percent % 10;

        if (jph_letterGrade != "A" && jph_letterGrade != "F")
        {
            if (jph_remainder >= 7)
            {
                jph_letterSign = "+";
            }
            else if (jph_remainder <= 3)
            {
                jph_letterSign = "-";
            }
        }
        else if (jph_letterGrade == "A")
        {
            if (jph_remainder <= 3)
            {
                jph_letterSign = "-";
            }
        }

        Console.WriteLine($"Your grade is: {jph_letterGrade}{jph_letterSign}");

        if (jph_percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}