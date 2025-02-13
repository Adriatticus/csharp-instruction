using System.Security.Cryptography;
using ConsoleLibrary;

namespace csharp_project_7_3_guessing_game
{
    internal class Program
    {
        const int MIN_VAL = 1;
        const int MAX_VAL = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello again...GUESSING GAME!!!!\n");

            Console.WriteLine("Welcome to the Guess the Number Game!");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");

            //int count = 0;
            string choice = "y";
            while (choice == "y")
            {
                Game gg = new Game();
                Console.WriteLine("\nI'm thinking of a n umber from 1 to 100.\nTry to guess it.\n");
                while (!gg.IsGameOver)
                {
                    Console.WriteLine(gg.CheckGuess());
                }

                choice = MyConsole.PromptStrInRange(("\nTry again? (y/n): "), "y", "n");
            }

            MyConsole.PrintL("Guess again....NERD!");
        }
    }
}
