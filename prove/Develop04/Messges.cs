using System;
/*
Name: Jacob Hutson
Date: 6/12/2026
Class: CSE 310
Description: The parent class for all of the other classes. Meant to create the beginning and ending messages, 
show the animation, the countdown, and creates the run function that the subclasses will overwrite.
Sources:
1. Assignment Code Advice https://byui-cse.github.io/cse210-course-2023/unit04/develop.html
2. Gemini Code Advice
3. In Class Notes
*/

public abstract class Messages // 2.
{
    private string _jphName;
    private string _jphDescription;
    private int _jphDuration;

    public Messages()
    {
        _jphName = "";
        _jphDescription = "";
        _jphDuration = 0;
    }

    public Messages(string jph_name, string jph_description)
    {
        _jphName = jph_name;
        _jphDescription = jph_description;
    }

    protected int GetDuration()
    {
        return _jphDuration;
    }

    protected string GetName()
    {
        return _jphName;
    }

    public void BeginMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_jphName}.\n");
        Console.WriteLine();
        Console.WriteLine($"{_jphDescription}\n");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _jphDuration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowAnimation(3);
        Console.WriteLine();
    }

    public void EndMessage()
    {
        Console.WriteLine("\nGood job!");
        ShowAnimation(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_jphDuration} seconds of the {_jphName}.");
        ShowAnimation(3);
    }

    public void ShowAnimation(int jph_seconds)
    {
        List <string> jph_animations = ["|", "/", "-", "\\"]; // 3.

        DateTime startTime = DateTime.Now; // 1.
        DateTime endTime = startTime.AddSeconds(jph_seconds); // 1.
        
        int jph_INDEX = 0;
        
        while (DateTime.Now < endTime) // 1.
        {
            string jph_frame = jph_animations[jph_INDEX];
            Console.Write(jph_frame);
            Thread.Sleep(250); // 1.
            Console.Write("\b \b"); // 1.
            jph_INDEX++;

            if (jph_INDEX >= jph_animations.Count) // 2.
            {
                jph_INDEX = 0; // 2.
            }
        }
    }

    public void ShowCountDown(int jph_seconds)
    {
        for (int i = jph_seconds; i > 0; i--) // 2.
        {
            Console.Write(i);
            Thread.Sleep(1000); // 1.
            
            string backspaces = new string('\b', i.ToString().Length); // 2.
            string spaces = new string(' ', i.ToString().Length); // 2.
            Console.Write(backspaces + spaces + backspaces); // 2.
        }
    }

    public abstract void Run(); // 2. Gemini came up with this idea and the implementation of this idea
}