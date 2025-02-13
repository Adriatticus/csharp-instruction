using ConsoleLibrary;

namespace csharp_pig_dice_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!!!! Little piggies!!!!");

            Random rand = new Random();
            string choice = "y";
            while (choice == "y")
            {
                int nbrGames = MyConsole.PromptInt("Number of games to play?: ");
                int highScore = 0;
                int highScoreNumRolls = 0;
                for (int i = 0; i < nbrGames; i++)
                {
                    int roll = 0;
                    int score = 0;
                    int rollCount = 0;
                    while (roll != 1)
                    {
                        rollCount++;
                        roll = rand.Next(1, 7);
                        if (roll != 1)
                        {
                            score += roll;
                        }
                    }
                    if (score > highScore)
                    {
                        highScore = score;
                        highScoreNumRolls = rollCount;
                    }
                    //highScore = (score > highScore) ? score : highScore; // to review page 151 ternary statement

                // play game
                    // roll: int = 0
                    // score: int = 0
                    // while roll != 1
                        // roll = rand(1-6)
                        // if roll != 1
                            // score += roll

                // store score, compare to highScore

                }
                MyConsole.PrintL($"High score was: {highScore}");
                MyConsole.PrintL($"High number of rolls was: {highScoreNumRolls}");
                choice = MyConsole.PromptStrInRange(("Again? (y/n): "), "y", "n");
        }
            // display high score
            // prompt again?
                    
            MyConsole.PrintL("Ham bone skillet");
        }
    }
}
