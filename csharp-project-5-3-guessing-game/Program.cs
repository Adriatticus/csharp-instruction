using Microsoft.VisualBasic;

namespace csharp_project_5_3_guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print("Hello!? I said, 'Is your number 108?!'");

            Print("\nWelcome to the Guess the Number Game");
            Print("++++++++++++++++++++++++++++++++++++\n");

            string choice = "y";
            while (choice.ToLower() == "y")
            {


                Print("I'm thinking of a number from 1 to 100.\nTry to guess it.");
                Random ranNum = new Random();
                Console.Write(ranNum.Next(0, 100));
                bool successvalidguess = false;
                while (!successvalidguess)
                {
                    Print("\nEnter number: ");
                    int guess = Int32.Parse(Console.ReadLine());
                    if (guess < 1 || guess > 100)
                    {
                        Console.Write("\nInvalid guess. Try again: ");
                    }
                    else
                    {
                        successvalidguess = true;
                    }
                }

            Console.Write("\nTry again? (y/n): ");
            choice = Console.ReadLine();
            Print(" ");
            }



            Print("\nNope! My turn!");
        }

        private static void Print(string msg)
        {
            Console.WriteLine(msg);

        }
    }
}
