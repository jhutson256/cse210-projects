using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.CompilerServices;
// 1. Prove Assignment Instructions, Code Helps Section, https://byui-cse.github.io/cse210-course-2023/unit03/develop.html
// 2. Previous Prove Assignment page, Code Helps Section, https://byui-cse.github.io/cse210-course-2023/unit02/develop.html
// 3. Gemini code advice

class Program
{
    static void Main(string[] args)
    {
        string[] jph_randomScripture = GetScripture();
        Scripture jph_scripture = ParseScripture(jph_randomScripture);
        bool jph_flag = true;

        while (jph_flag == true)
        {
            Console.Clear(); // 1.
            Display(jph_scripture);
            Console.Write("\nPress Enter to hide words, or type 'quit' to exit. ");
            string jph_input = Console.ReadLine();

            if (jph_input.ToLower() == "quit")
            {
                jph_flag = false;
            }

            jph_scripture.HideWords(3);
        }
    }

    static void Display(Scripture jph_scripture)
    {
        jph_scripture.ToString();
        Console.WriteLine(jph_scripture);
    }

    // Stretch - I decided to store a collection of scriptures in a CSV file to then read to the rest of 
    // the program as the way I would make this program my own.
    static string[] GetScripture() 
    {
        Random jph_randomGenerator = new Random();
        int jph_INDEX = jph_randomGenerator.Next(0, 11);
        string filename = "scriptures.csv"; // 2.
        string jph_targetLine = System.IO.File.ReadLines(filename).Skip(jph_INDEX).FirstOrDefault(); // 3.

        string[] parts = jph_targetLine.Split(" || "); // 2.

        return parts;
    }

    // Stretch - Because I had to read the scriptures from a CSV file, I also had to parse everything
    // and properly store each part of the scripture in the correct class.
    static Scripture ParseScripture(string [] parts)
    {
        string[] jph_parts = parts[0].Split(" ");
        string jph_book = jph_parts[0];
        string[] jph_chapterAndVerse = jph_parts[1].Split(":");
        int jph_chapter = int.Parse(jph_chapterAndVerse[0]);
        string jph_verse = jph_chapterAndVerse[1];
        Reference jph_reference; // 3.

        if (jph_verse.Contains("-")) // 3.
        {
            string[] jph_verseParts = jph_verse.Split('-');
            int jph_startVerse = int.Parse(jph_verseParts[0]);
            int jph_endVerse = int.Parse(jph_verseParts[1]);
            jph_reference = new Reference(jph_book, jph_chapter, jph_startVerse, jph_endVerse);
        }
        else
        {
            int jph_startVerse = int.Parse(jph_verse);
            jph_reference = new Reference(jph_book, jph_chapter, jph_startVerse);
        }

        string jph_parts2 = parts[1];
        List<string> jph_wordsList = jph_parts2.Split(' ').ToList(); // 3.
        Passage jph_passage = new Passage();
        
        foreach (string jph_word in jph_wordsList)
        {
            Word jph_newWord = new Word(jph_word);
            jph_passage.AddWord(jph_newWord);
        }

        Scripture jph_scripture = new Scripture(jph_reference, jph_passage);

        return jph_scripture;
    }
}