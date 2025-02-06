namespace csharp_project_4_3_tip_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to Dinner Palace! Please tip your server!!");

            PrintL("Tip your server Calculator");

            string choice = "y";
            while (choice == "y")
            {
                int MealC = 0;
                Print("Cost of meal: ");
                bool success = Int32.TryParse(Console.ReadLine(), out MealC);
                if (!success)
                {
                    PrintL("Tip your server in money. Try using an integer.");
                }
                else
                {
                    int onefivetip = 
                    Print("15%\n");
                    Print("Tip amount: " + onefivetip);
                    Print("20%\n");
                    Print("25%\n");



                }


                Print("Continue? (y/n): ");
                choice = Console.ReadLine();
            }
            Console.WriteLine("If you didn't already go back apologize and tip your server!");
        }
        static void PrintL(string msg)
        {
            Console.WriteLine(msg);
        }
        static void Print(string msg2)
        {
            Console.Write(msg2);
        }


    }
}
