using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> jph_numbers = new List<int>();

        bool jph_flag = true;

        while (jph_flag == true)
        {
            Console.Write("Enter a number (0 to quit): ");
            string jph_userInput = Console.ReadLine();
            int jph_userNumber = int.Parse(jph_userInput);
            
            // Only add the number to the list if it is not 0
            if (jph_userNumber == 0)
            {
                jph_flag = false;
            }
            else
            {
                jph_numbers.Add(jph_userNumber);
            }
        }

        float jph_sum = 0;
        foreach (int jph_number in jph_numbers)
        {
            jph_sum += jph_number;
        }

        Console.WriteLine($"The sum is {jph_sum}");

        float jph_average = jph_sum / jph_numbers.Count;
        Console.WriteLine($"The average is {jph_average}");

        int jph_max = 0;

        foreach (int jph_number in jph_numbers)
        {
            if (jph_number > jph_max)
            {
                jph_max = jph_number;
            }
        }

        Console.WriteLine($"The max is {jph_max}");
    }
}