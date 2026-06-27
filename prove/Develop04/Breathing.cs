using System;
/*
Name: Jacob Hutson
Date: 6/12/2026
Class: CSE 210
Description: The class to run the breathing activity. No attributes were needed, but this class did need a 
method to run the activity.
Sources:
1. Assignment Code Advice https://byui-cse.github.io/cse210-course-2023/unit04/develop.html
2. Gemini Code Advice
3. In Class Notes
*/

public class Breathing : Messages
{
    public Breathing() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.") // 3.
    {}

    public override void Run() // 2.
    {
        BeginMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration()); // 1.

        while (DateTime.Now < endTime) // 1.
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(5);
            Console.Write("\nBreathe out...");
            ShowCountDown(5);
            Console.WriteLine();
        }

        EndMessage();
    }
}