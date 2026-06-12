using System;
/*
Name: Jacob Hutson
Date: 6/12/2026
Class: CSE 310
Description: The class to run the reflection activity.
Sources:
1. Assignment Code Advice https://byui-cse.github.io/cse210-course-2023/unit04/develop.html
2. Gemini Code Advice
3. In Class Notes
*/

public class Reflection : Messages
{
    private List<string> _jphPrompts = new List<string>();
    private List<string> _jphQuestions = new List<string>();

    public Reflection() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") // 3.
    {
        _jphPrompts = [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        ];

        _jphQuestions = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];
    }

    public string GetRandomPrompt()
    {
        Random jph_randomGenerator = new Random();
        int jph_INDEX = jph_randomGenerator.Next(0, 3);
        string jph_prompt = _jphPrompts[jph_INDEX];

        return jph_prompt;
    }

    public string GetRandomQuestion()
    {
        Random jph_randomGenerator = new Random();
        int jph_INDEX = jph_randomGenerator.Next(0, 8);
        string jph_question = _jphQuestions[jph_INDEX];

        return jph_question;
    }

    public override void Run() // 2.
    {
        BeginMessage();

        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} --- \n");
        Console.WriteLine();
        Console.Write("When you have something in mind, press ENTER to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now; // 1.
        DateTime endTime = startTime.AddSeconds(GetDuration()); // 1.

        while (DateTime.Now < endTime) // 1.
        {
            string jph_question = GetRandomQuestion();
            Console.Write($"> {jph_question} ");
            ShowAnimation(10); 
            Console.WriteLine();
        }

        EndMessage();
    }
}