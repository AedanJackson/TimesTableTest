using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesTableTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+   Welcome to the times table test!   +");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++\n");
            Console.Write("What is your name? ");

            string Name = Console.ReadLine();
            Console.Write($"\nHi {Name}! ");
            bool ContinuePlaying = true;
            Random RNG = new Random();
            while (ContinuePlaying)
            {
                int NumberSelection = 0;
                bool ValidSelection = false;
                do
                {
                    Console.Write("Which times tables would\nyou like to test? You can choose from\n2 to 12: ");
                    try
                    {
                        NumberSelection = int.Parse(Console.ReadLine());
                        if (NumberSelection >= 12 && NumberSelection < 2)
                        {
                            ValidSelection = true;
                        }
                        else
                        {
                            Console.WriteLine("That is not between 2 or 12. Try again!");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("That's not even a number!Don't be a\nsilly billy, try again!");
                    }
                } while (!ValidSelection);
                Console.WriteLine($"Woohoo! You have chosen to do the\n{NumberSelection} times tables. 10 questions coming up!");
                int QuestionsToAsk = 10;
                int points = 0;
                for (int attempt = 0; attempt <= QuestionsToAsk; attempt++) 
                {

                }
            }
        }
    }
}
