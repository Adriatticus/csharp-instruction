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

            Print("\nNope! My turn!");
        }

        private static void Print(string msg)
        {
            Console.WriteLine(msg);

        }
    }
}
