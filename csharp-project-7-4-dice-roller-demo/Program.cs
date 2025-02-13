using ConsoleLibrary;
namespace csharp_project_7_4_dice_roller_demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, public!\n");

            MyConsole.PrintL("Welcome to the Dice Roller Game!\n");

            // initialize choice w/ prompt Roll the dice? (y/n)
            string choice = MyConsole.PromptString("Roll the dice? (y/n): ").ToLower();
                                // while choice == y
            while (choice == "y")
            {
                Dice dice = new Dice();
                dice.Roll();
                MyConsole.Print(dice.GetRollResults());
                choice = MyConsole.PromptString("\nRoll again? (y/n): ").ToLower().Trim();
                                    // roll die1, die2

            }

                                    // display total and specialMsg
                                    //promt continue?







            MyConsole.PrintL("Bey");
        }
    }
}
