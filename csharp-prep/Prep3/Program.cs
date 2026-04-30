using System;

class Program
{
    static void Main(string[] args)
    {
        Random jph_randomGenerator = new Random();
        int jph_randomNumber = jph_randomGenerator.Next(1, 101);

        bool jph_flag = true;

        while (jph_flag == true)
        {
            Console.Write("What is your guess? ");
            string jph_userInput = Console.ReadLine();
            int jph_guess = int.Parse(jph_userInput);

            if (jph_randomNumber > jph_guess)
            {
                Console.WriteLine("Higher");
            }
            else if (jph_randomNumber < jph_guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                jph_flag = false;
            }
        }
    }
}