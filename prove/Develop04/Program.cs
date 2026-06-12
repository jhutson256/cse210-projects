using System;
/*
Name: Jacob Hutson
Date: 6/12/2026
Class: CSE 310
Description: The main function of the program meant to execute the rest of the classes, their methods, 
and run the menu for the program. For the stretch to make this program my own, I created a fourth activity called 
the positive affirmation activity and implemented it into the program.
Sources:
1. Assignment Code Advice https://byui-cse.github.io/cse210-course-2023/unit04/develop.html
2. Gemini Code Advice
3. In Class Notes
*/

class Program
{
    static void Main(string[] args)
    {
        bool jph_flag = true;

        while (jph_flag == true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflection activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Start positive affirmation activity");
            Console.WriteLine(" 5. Quit");
            Console.Write("Select a choice from the menu: ");
            string jph_userInput = Console.ReadLine();

            Messages selectedActivity = null; // 2. Gemini came up with this idea and the implementation of this idea

            if (jph_userInput == "1")
            {
                selectedActivity = new Breathing(); // 2.
            } 

            else if (jph_userInput == "2")
            {
                selectedActivity = new Reflection(); // 2.
            } 

            else if (jph_userInput == "3")
            {
                selectedActivity = new Listing(); // 2.
            } 

            else if (jph_userInput == "4")
            {
                selectedActivity = new Affirmation(); // 2.
            } 
            
            else
            {
                jph_flag = false;
            }

            if (selectedActivity != null) // 2.
            {
                selectedActivity.Run(); // 2.
                Console.Clear();
            }
        }
    }
}