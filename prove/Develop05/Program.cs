using System;
/*
Name: Jacob Hutson
Date: 6/26/2026
Class: CSE 210
Description: The class containing the main functions of the program. This class handles all console 
related code. For the stretch to make this program my own, I added ranks to the program based on the 
amount of points earned. The code for this can be found starting on line 68.
Sources:
1. Assignment Code Advice https://byui-cse.github.io/cse210-course-2023/unit05/develop.html
2. Gemini Code Advice
3. In Class Notes
*/

class Program
{
    private static int _jphScore = 0;
    private static List<Goal> _jphGoals = new List<Goal>();

    public static void Main(string[] args)
    {
        bool jph_flag = true;

        while (jph_flag == true)
        {
            DisplayPlayerStatus();
            DisplayMenu();
            
            Console.Write("Select a choice from the menu: ");
            string jph_choice = Console.ReadLine();
            Console.WriteLine();

            switch (jph_choice)
            {
                case "1":
                    DisplayGoalMenu();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordGoalEventMenu();
                    break;
                case "6":
                    Console.WriteLine("Thank you for using Eternal Quest. Goodbye!");
                    jph_flag = false;
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please choose an option from 1 to 6.");
                    break;
            }

            if (jph_flag == true)
            {
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }

    private static void DisplayPlayerStatus()
    {
        Console.WriteLine($"--- Eternal Quest Status ---");
        Console.WriteLine($"Current Score: {_jphScore} points");
        
        string jph_rank = "Novice Adventurer";
        if (_jphScore >= 10000) jph_rank = "His Majesty, King of the Goals";
        else if (_jphScore >= 5000) jph_rank = "Sir Completer, Knight of the Goals";
        else if (_jphScore >= 2500) jph_rank = "Goals Squire";
        else if (_jphScore >= 1000) jph_rank = "Goals Crusher";

        Console.WriteLine($"Current Rank: {jph_rank}");
        Console.WriteLine("----------------------------\n");
    }

    private static void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
    }

    private static void DisplayGoalMenu()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string jph_choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string jph_name = Console.ReadLine();
        Console.Write("Write a short description of it. ");
        string jph_description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        
        if (!int.TryParse(Console.ReadLine(), out int points)) points = 0; // 2.

        switch (jph_choice)
        {
            case "1":
                _jphGoals.Add(new SimpleGoal(jph_name, jph_description, points));
                Console.WriteLine("Simple goal added successfully!");
                break;

            case "2":
                _jphGoals.Add(new EternalGoal(jph_name, jph_description, points));
                Console.WriteLine("Eternal goal added successfully!");
                break;

            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                if (!int.TryParse(Console.ReadLine(), out int target)) target = 1; // 2.
                
                Console.Write("What is the bonus for accomplishing it that many times? ");
                if (!int.TryParse(Console.ReadLine(), out int bonus)) bonus = 0; // 2.

                _jphGoals.Add(new ChecklistGoal(jph_name, jph_description, points, target, bonus));
                Console.WriteLine("Checklist goal added successfully!");
                break;

            default:
                Console.WriteLine("Invalid goal selection type. Operation aborted.");
                break;
        }
    }

    private static void ListGoals()
    {
        Console.WriteLine("The goals are:");
        if (_jphGoals.Count == 0)
        {
            Console.WriteLine("No goals created yet. Choose option 1 to start your quest!");
            return;
        }

        for (int jph_i = 0; jph_i < _jphGoals.Count; jph_i++)
        {
            Console.WriteLine($"{jph_i + 1}. {_jphGoals[jph_i].GetDetailsString()}");
        }
    }

    private static void RecordGoalEventMenu()
    {
        if (_jphGoals.Count == 0)
        {
            Console.WriteLine("You do not have any goals tracked yet.");
            return;
        }

        Console.WriteLine("The goals are:");
        for (int i = 0; i < _jphGoals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_jphGoals[i].GetName()}");
        }

        Console.Write("Which goal did you accomplish? ");
        if (int.TryParse(Console.ReadLine(), out int choiceIndex) && choiceIndex > 0 && choiceIndex <= _jphGoals.Count) // 2.
        {
            Goal jph_selectedGoal = _jphGoals[choiceIndex - 1];
            
            if (jph_selectedGoal.IsComplete())
            {
                Console.WriteLine("This goal has already been completed.");
                return;
            }

            int jph_pointsEarned = jph_selectedGoal.RecordEvent();
            _jphScore += jph_pointsEarned;

            Console.WriteLine($"Congratulations! You earned {jph_pointsEarned} points!");
            Console.WriteLine($"New Total Score: {_jphScore}");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    private static void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine(); // 1.

        try // 3.
        {
            using (StreamWriter outputFile = new StreamWriter(filename)) // 1.
            {
                outputFile.WriteLine(_jphScore);
                
                foreach (Goal jph_goal in _jphGoals)
                {
                    outputFile.WriteLine(jph_goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals successfully stored to the save file.");
        }
        catch (Exception ex) // 3.
        {
            Console.WriteLine($"Error occurred saving goals: {ex.Message}");
        }
    }

    private static void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine(); // 1.

        if (!File.Exists(filename)) // 2.
        {
            Console.WriteLine("Target file not found. Please verify standard working directory paths.");
            return;
        }

        try // 3.
        {
            string[] lines = File.ReadAllLines(filename); // 1.
            if (lines.Length == 0) return; // 2.

            _jphScore = int.Parse(lines[0]);
            _jphGoals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i]; // 1.
                if (string.IsNullOrWhiteSpace(line)) continue; // 2.

                string[] jph_typeParts = line.Split(':'); // 1.
                string jph_goalType = jph_typeParts[0]; // 1.
                string[] jph_fields = jph_typeParts[1].Split(','); // 1.

                switch (jph_goalType)
                {
                    case "SimpleGoal":
                        _jphGoals.Add(new SimpleGoal(jph_fields[0], jph_fields[1], int.Parse(jph_fields[2]), bool.Parse(jph_fields[3]))); // 2.
                        break;

                    case "EternalGoal":
                        _jphGoals.Add(new EternalGoal(jph_fields[0], jph_fields[1], int.Parse(jph_fields[2]))); // 2.
                        break;

                    case "ChecklistGoal":
                        _jphGoals.Add(new ChecklistGoal(jph_fields[0], jph_fields[1], int.Parse(jph_fields[2]), int.Parse(jph_fields[3]), int.Parse(jph_fields[4]), int.Parse(jph_fields[5]))); // 2.
                        break;
                }
            }
            Console.WriteLine("Goals were retrieved!");
        }
        catch (Exception ex) // 3.
        {
            Console.WriteLine($"Error occurred retrieving goals: {ex.Message}");
        }
    }
}