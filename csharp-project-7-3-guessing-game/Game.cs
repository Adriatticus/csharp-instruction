using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using ConsoleLibrary;

namespace csharp_project_7_3_guessing_game
{
    public class Game
    {
        const int MIN_VAL = 1;
        const int MAX_VAL = 100;

        public int Count { get; set; }
        public bool IsGameOver { get; set; }
        public int TheNumber;
        



        public Game()
        {
            Count = 0;
            IsGameOver = false;
            TheNumber = new Random().Next(MIN_VAL, MAX_VAL);
        }



        public string CheckGuess()
        {
            int guess = MyConsole.PromptIntInRange($"\nEnter number:  ", MIN_VAL, MAX_VAL);
            Count ++;
            int dif = guess - TheNumber;
            Console.WriteLine(dif);
            Console.WriteLine(TheNumber);
            Console.WriteLine(guess);
            if (dif == 0)
            {
                IsGameOver = true;
                return GoodJob();
            }
            else if (dif > 10)
            {
                return ("Way too high! Guess again.");
            }
            else if (dif > 0)
            {
                return ("Too high! Guess again.");
            }
            else if (dif < -10)
            {
                return ("Way too low! Guess again.");
            }
            else
            {
                return ("Too low! Guess again.");
            }

        }


        public string GoodJob()
        {
            string gj = ($"Good job! You got it in {Count} tries\n");
            if (Count <= 3)
            {
                gj += ("Impressive! Are you some kind of Wizard!?");
            }
            else if (Count < 8)
            {
                gj += ("Not too bad, Traveler!");
            }
            else
            {
                gj += ("You empty headed Barbarian! That took way too long!");
            }
            return gj;
            
        }
        
        
    }
}
