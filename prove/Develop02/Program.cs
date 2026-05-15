using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your Journal!");
        bool jph_Flag = true;
        jph_Journal _jphNewJournal = new jph_Journal();

        while (jph_Flag == true)
        {
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string jph_userInput = Console.ReadLine();
            int jph_userOption = int.Parse(jph_userInput);
            Console.WriteLine("");

            if (jph_userOption == 1)
            {
                _jphNewJournal.AddEntry();
            }
            else if(jph_userOption == 2)
            {
                _jphNewJournal.DisplayEntries();
            }
            else if(jph_userOption == 3)
            {
                _jphNewJournal.LoadJournal();
            }
            else if(jph_userOption == 4)
            {
                _jphNewJournal.SaveJournal();
            }
            else if(jph_userOption == 5)
            {
                Console.WriteLine("Great job writing in your journal today!");
                jph_Flag = false;
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 and 5.");
            }
        }
    }
}