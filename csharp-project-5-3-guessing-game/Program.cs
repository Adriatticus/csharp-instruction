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

                Random ranNum = new Random();
                Console.WriteLine(ranNum.Next(0, 100));
                Print("I'm thinking of a number from 1 to 100.\nTry to guess it.");
                bool successvalidguess = false;
                while (!successvalidguess)
                {
                    Print("\nEnter number: ");
                    int guess = Int32.Parse(Console.ReadLine());
                    if (guess < 1 || guess > 100)
                    {
                        Console.Write("\nInvalid number. Try again: ");
                    }
                    else
                    {
                        successvalidguess = true;
                    }
                    // maybe do a while loop where ranNum == guess...so false until proven true?
                    bool youGuessedIt = false;
                    while (!youGuessedIt)
                    {
                        if (guess == ranNum)
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
