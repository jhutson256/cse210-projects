using System;
/*
Name: Jacob Hutson
Date: 6/12/2026
Class: CSE 310
Description: The class to run the listing activity.
Sources:
1. Assignment Code Advice https://byui-cse.github.io/cse210-course-2023/unit04/develop.html
2. Gemini Code Advice
3. In Class Notes
*/

public class Listing : Messages
{
    private int _jphCount;
    private List<string> _jphPrompts = new List<string>();

    public Listing() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") // 3.
    {
        _jphCount = 0;

        _jphPrompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];
    }

    public string GetRandomPrompt()
    {
        Random jph_randomGenerator = new Random();
        int jph_INDEX = jph_randomGenerator.Next(0, 4);
        string jph_prompt = _jphPrompts[jph_INDEX];

        return jph_prompt;
    }

    public override void Run() // 2.
    {
        BeginMessage();

        Console.WriteLine("List as many things as you can in response to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");

        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now; // 1.
        DateTime endTime = startTime.AddSeconds(GetDuration()); // 1.

        while (DateTime.Now < endTime) // 1.
        {
            Console.Write("> ");
            Console.ReadLine();
            _jphCount++;
        }

        Console.WriteLine($"\nYou listed {_jphCount} items!");
        EndMessage();
    }
}