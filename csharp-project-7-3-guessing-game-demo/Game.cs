using ConsoleLibrary;

namespace csharp_project_7_3_guessing_game_demo
{
    public class Game
    {
        public int Count { get; set; }
        public int Diff {  get; set; }

        public void DisplayGuessMessage()
        {
            if (Diff == 0)
            {
                DisplayWinnerMessage();
            }
            else if (Diff < -10)
            {
                MyConsole.Print("Way too low! Guess again.");
            }
            else if (Diff < 0)
            {
                MyConsole.Print("Too low! Guess again.");
            }
            else if (Diff > 10)
            {
                MyConsole.Print("Way too high! Guess again.");
            }
            else if (Diff > 0)
            {
                MyConsole.Print("Too high! Guess again.");
            }
        }

        void DisplayWinnerMessage()
        {
            MyConsole.Print("You got it in " + Count + "tries.");
            if (Count <= 3)
            {
                MyConsole.Print("Great work! You are smarty pants");
            }
            else if (Count < 8)
            {
                MyConsole.Print("Silly goose! I think you  may need a new strategy!");
            }
            else
            {
                MyConsole.Print("There really may be no hope for you...");
            }
        }
    }
}
