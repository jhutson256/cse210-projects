using System;
/*
Name: Jacob Hutson
Date: 6/12/2026
Class: CSE 210
Description: The class to run the positive affirmation activity. This is what I decided to create to make this 
program my own. This class is supposed to randomly display a positive affirmation every 5 seconds until the time 
reaches the duration.
Sources:
1. Assignment Code Advice https://byui-cse.github.io/cse210-course-2023/unit04/develop.html
2. Gemini Code Advice
3. In Class Notes
*/

public class Affirmation : Messages
{
    private List<string> _jphAffirmations = new List<string>();

    public Affirmation() : base("Positive Affirmations Activity", "This activity will help you center your thoughts by presenting you with encouraging affirmations. Relax and simply focus on the words on the screen.") // 3.
    {
        // 2. I had Gemini generate each of these affirmations, but I wrote all of the code putting them into the program. I also had Gemini generate the description for the class.

        _jphAffirmations = [
            "I am in control of my breath, my thoughts, and my reactions.",
            "I choose to let go of things I cannot control right now.",
            "I am capable of handling whatever challenges today brings.",
            "My past mistakes do not define my future potential.",
            "I give myself permission to slow down, rest, and reset.",
            "I am worthy of respect, kindness, and peace of mind.",
            "With every exhale, I release the tension built up in my body.",
            "I am doing the best I can with what I have, and that is enough.",
            "I focus my energy on the present moment and the next step ahead.",
            "I am resilient, and I have survived 100% of my hardest days."
        ];
    }

    public string GetRandomAffirmation()
    {
        Random jph_randomGenerator = new Random();
        int jph_INDEX = jph_randomGenerator.Next(0, 9);
        string jph_affirmation = _jphAffirmations[jph_INDEX];

        return jph_affirmation;
    }

    public override void Run() // 2.
    {
        BeginMessage();

        DateTime startTime = DateTime.Now; // 1.
        DateTime endTime = startTime.AddSeconds(GetDuration()); // 1.

        while (DateTime.Now < endTime) // 1.
        {
            Console.WriteLine("\nFocus on this thought:");
            Console.WriteLine($"--- {GetRandomAffirmation()} ---");
            ShowCountDown(5);
            Console.WriteLine();
        }

        EndMessage();
        Console.Clear();
    }
}