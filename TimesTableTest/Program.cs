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
            // Intro message
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+   Welcome to the times table test!   +");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++\n");
            Console.Write("What is your name? ");

            // Gets name and greets the user
            string Name = Console.ReadLine();
            Console.Write($"\nHi {Name}! ");
            // Initiates variables for RNG (used later on in the program) and also whether to repeat the program when it is finished
            bool ContinuePlaying = true;
            Random RNG = new Random();
            while (ContinuePlaying)
            {
                int NumberSelection = 0;
                bool ValidSelection = false;
                // Validation, checks whether the input is a number and between 2 and 12 (inclusive)
                do
                {
                    Console.Write("Which times tables would\nyou like to test? You can choose from\n2 to 12: ");
                    try
                    {
                        NumberSelection = int.Parse(Console.ReadLine());
                        if (NumberSelection <= 12 && NumberSelection >= 2)
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
                        Console.WriteLine("That's not even a number! Don't be a\nsilly billy, try again!");
                    }
                } while (!ValidSelection);

                // Intro message to the test
                Console.WriteLine($"Woohoo! You have chosen to do the\n{NumberSelection} times tables. 10 questions coming up!");
                int QuestionsToAsk = 10;
                int Points = 0;
                // For loop to ask the user questions
                for (int attempt = 1; attempt <= QuestionsToAsk; attempt++)
                {
                    int thisQ = RNG.Next(1, 13);
                    int Answer = 0;
                    Console.Write($"*{attempt}) What is {thisQ} x {NumberSelection}? ");
                    // Validates user input (checks if it is a number) and converts it to int
                    bool ValidAnswer = false;
                    do
                    {
                        string AnswerString = Console.ReadLine();
                        try
                        {
                            Answer = int.Parse(AnswerString);
                            ValidAnswer = true;
                        }
                        catch
                        {
                            Console.WriteLine("That is not a number! Try again.");
                        }
                    } while (!ValidAnswer);
                    // Adds one to the user's point score if they got the answer correct
                    if (Answer == (thisQ * NumberSelection))
                    {
                        Points++;
                    }
                }
                // Prints a little message to tell the user how well they have done in the test
                if ((Convert.ToDouble(Points) / Convert.ToDouble(QuestionsToAsk)) > 0.7)
                {
                    Console.WriteLine($"You scored {Points}/{QuestionsToAsk}. Great job!");
                }
                else if ((Convert.ToDouble(Points) / Convert.ToDouble(QuestionsToAsk)) > 0.3)
                {
                    Console.WriteLine($"You scored {Points}/{QuestionsToAsk}. Not bad!");
                }
                else
                {
                    Console.WriteLine($"You scored {Points}/{QuestionsToAsk}. Maybe you need a little more practice.");
                }
                // Asks the user if they would like to play again and then makes sure the answer is either "yes" or "no" and acting accordingly (changing the ToPlayAgain variable
                // initiated at the start of the program
                bool PlayAgainValid = false;
                do
                {
                    Console.Write("Would you like to play again? ");
                    string ToPlayAgain = Console.ReadLine();
                    if (ToPlayAgain.ToLower() == "yes")
                    {
                        ContinuePlaying = true;
                        PlayAgainValid = true;
                    }
                    else if (ToPlayAgain.ToLower() == "no")
                    {
                        ContinuePlaying = false;
                        PlayAgainValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter yes or no.");
                    }
                } while (!PlayAgainValid);


            }
        }
    }
}