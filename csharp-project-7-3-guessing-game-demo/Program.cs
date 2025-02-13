using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using ConsoleLibrary;

namespace csharp_project_7_3_guessing_game_demo
{
    internal class Program
    {
        // constants
        const int MIN_VAL = 1;
        const int MAX_VAL = 100;
        static void Main(string[] args)

        {
            Console.WriteLine("This is the demo to the guessing game\n");

            Print("Welcome to the Guessing Game");
            Print("++++++++++++++++++++++++++++\n");

            
            string choice = "y";
            Random rand = new Random();
            while (choice == "y")
            {
                int theNumber = rand.Next(MIN_VAL, MAX_VAL + 1);
                int count = 0;
                int guess = 0;
                MyConsole.PrintL("I'm thinking of a number from 1 to 100.\nTry to guess it.\n");
                while (guess != theNumber)
                {
                    guess = GetNumber("Enter Number: ");
                    count++;
                    int diff = guess - theNumber;
                    Game game = new Game();
                    game.Diff = diff;
                    game.Count = count;
                    game.DisplayGuessMessage();
                }
                Print("");
                choice = GetRequiredString("Try again? (y/n) ", "y", "n");
            }
            Console.WriteLine("Nice try buddy. Practice this. Project 5-2 could be a good start");
        }

        //private static void DisplayGuessMessage(int count, int diff)
        //{
        //    if (diff == 0)
        //    {
        //        DisplayWinnerMessage(count);
        //    }
        //    else if (diff < -10)
        //    {
        //        Print("Way too low! Guess again.");
        //    }
        //    else if (diff < 0)
        //    {
        //        Print("Too low! Guess again.");
        //    }
        //    else if (diff > 10)
        //    {
        //        Print("Way too high! Guess again.");
        //    }
        //    else if (diff > 0)
        //    {
        //        Print("Too high! Guess again.");
        //    }
        //}

        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }

        static string GetRequiredString(string prompt, string val1, string val2)
        {
            string str = "";
            // while true - on purpose!!!!
            while (true)
            {
                Console.Write(prompt);
                str = Console.ReadLine().Trim();
                if (str == "")
                {
                    Print("Error - entry is required.");
                }
                else if (str != val1 && str != val2)
                {
                    Print("Error - entry must be either " + val1 + "or " + val2);
                }
                else
                {
                    break;
                }
            }
            return str;
        }

        

        static int GetNumber(string prompt)
        {
            int nbr = 0;
            bool success = false;
            while (!success)
            {
                Console.Write(prompt);
                // was user entry a whole number
                try
                {
                    nbr = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Print("Error - entry must be a whole number");
                    Console.Error.WriteLine(" e.Message: " + e.Message);
                    Console.Error.WriteLine("e.ToString() " + e.ToString);
                    continue;
                }
                //catch 
                //{
                //Print("Error - entry must be a whole number");
                //continue;
                //}
                if (nbr >= MIN_VAL && nbr <= MAX_VAL)
                {
                    success = true;
                }
                else
                {
                    Print("Error - entry must be between 1 and 100");
                }
            }
            return nbr;
        }
    }
}

