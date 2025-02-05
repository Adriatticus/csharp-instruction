using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace csharp_project_5_3_guessing_game_demo
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

            // while - choice = "y"
            string choice = "y";
            Random rand = new Random();
            while (choice == "y")
            {
                // play game
                int theNumber = rand.Next(MIN_VAL, MAX_VAL+1);
                //Print(" ** DEBUGG " +theNumber);
                int count = 0;
                int guess = 0;
                Print("I'm thinking of a number from 1 to 100.\nTry to guess it.\n");
                //play game untill guess == theNumber
                while (guess != theNumber)
                {
                    guess = GetNumber("Enter Number: ");
                    // get random number (theNumber: int)
                    // get user guess (guess: int) & increment count
                    count++;
                    // count: int = 0
                    int diff = guess - theNumber;
                    if (diff == 0)
                    {
                        DisplayWinnerMessage(count); 
                    }
                    else if (diff < -10)
                    {
                        Print("Way too low! Guess again.");
                    }
                    else if (diff < 0)
                    {
                        Print("Too low! Guess again.");
                    }
                    else if (diff > 10)
                    {
                        Print("Way too high! Guess again.");
                    }
                    else if (diff > 0)
                    {
                        Print("Too high! Guess again.");
                    }


                    // compare guess vs theNumber (define the diff: int = guess - theNumber)
                    //  & display message:
                    // diff == 0 => win! + specialMsg
                    // specialMsg: count <= 3, <= 7, else...
                    // diff == < -10 => way too low
                    // diff < 0 => too low
                    // diff > 10 => way too high
                    // diff > 0 => too high
                    //prompt choice

                }
                Print("");
                choice = GetRequiredString("Try again? (y/n) ", "y", "n");
            }






            Console.WriteLine("Nice try buddy. Practice this. Project 5-2 could be a good start");
        }
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

        static void DisplayWinnerMessage(int count)
        {
            Print("You got it in " + count + "tries.");
            if (count <= 3)
            {
                Print("Great work! You are smarty pants");
            }
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
