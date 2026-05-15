using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;
// 1. Assignment page, code helps section, https://byui-cse.github.io/cse210-course-2023/unit02/develop.html
// 2. Gemini code advice

public class jph_Journal
{
    public List<jph_Entry> _jphEntriesList = new List<jph_Entry>();

    public void AddEntry()
    {
        jph_Entry _jphNewEntry = new jph_Entry();
        _jphNewEntry.DisplayPrompt();
        _jphNewEntry.ToCSV();
        _jphEntriesList.Add(_jphNewEntry);
    }

    public void DisplayEntries()
    {
        foreach (var jph_displayEntry in _jphEntriesList)
        {
            Console.WriteLine(jph_displayEntry.ToString());
            Console.WriteLine($"{jph_displayEntry.CalculateDaysSinceEntry()}");
        }
    }

    public void SaveJournal()
    {
        Console.Write("What is the file name? ");
        string filename = Console.ReadLine(); // 1. Parts of the code after this comes from the assignment

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var jph_saveEntry in _jphEntriesList)
            {
                outputFile.WriteLine(jph_saveEntry.ToCSV());
            }
        }
        
        Console.WriteLine("Entries saved.");
        _jphEntriesList.Clear(); // 2. I learned about clearing the list to avoid repeated entries
    }

    public void LoadJournal()
    {
        Console.Write("What is the file name? ");
        string filename = Console.ReadLine(); // 1. Parts of the code after this comes from the assignment
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            jph_Entry _jphNewEntry = new jph_Entry();
            string[] parts = line.Split(" || ");

            string jph_currentTime = parts[0];
            DateTime jph_csvTime = DateTime.Parse(jph_currentTime);
            string jph_entryPrompt = parts[1];
            string jph_response = parts[2];

            _jphNewEntry.FromCSV(jph_csvTime, jph_entryPrompt, jph_response);
            _jphEntriesList.Add(_jphNewEntry);
        }

        Console.WriteLine("Journal loaded.");
    }
}