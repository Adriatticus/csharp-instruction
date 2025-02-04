namespace csharp_project_5_1_dice_roller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Feeling lucky?\n");

            Print("Dice Roller!");
            Print("");

            // Roll the dice?
            Console.Write("Roll the dice? (y/n) ");
            string choice = Console.ReadLine().ToLower();
            Print("");
            Random rand = new Random();
            while (choice == "y")
            {
                // while choice == y or Y
                // roll die 1
                int die1 = RollDie(rand);
                // roll die 2
                int die2 = RollDie(rand);
                // display total AND message, if necessary (total 2 or 12)
                int total = die1 + die2;
                DisplayResult(die1, die2, total);
                // promt roll again?
                Print("");
                Console.Write("Roll again? (y/n): ");
                choice = Console.ReadLine().ToLower();



            }
            Console.WriteLine("Are these loaded dice you cheat?!");
        }

        private static int RollDie(Random rand)
        {
            return rand.Next(1, 7);
        }

        private static void DisplayResult(int die1, int die2, int total)
        {
            Print("Die 1: "+die1);
            Print("Die 2: "+die2);
            Print("Total: "+total);
            if (total == 2)
            {
                Print("Snake eyes!");
            }
            else if (total == 12)
            {
                Print("Box cars!");
            }
        }

        private static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
