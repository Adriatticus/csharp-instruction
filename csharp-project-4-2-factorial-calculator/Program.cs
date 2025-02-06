namespace csharp_project_4_2_factorial_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial caluculator!? More like Falsetorial caluculator!");

            PrintL("\nWelcome to the Factorial Calculator");

            string choice = "y";
            while (choice.ToLower() == "y")
            {
                Print("Enter an integer that's greater than 0 and less than 10: ");
                int IntE = 0;
                bool success = Int32.TryParse(Console.ReadLine(), out IntE);
                if (!success)
                {
                    Print("Error - Try again.");
                }
                else if (!(IntE > 0 && IntE < 10))
                {
                    Print("NOT!");
                }
                else
                {
                    int result = 1;
                    for (int i = 1; i <= IntE; i++)
                    {
                        result = result * i;
                    }
                    PrintL("The factorial of " + IntE + " is "+ result);

                    //loop from 1 to IntE 


                }







                Print("Continue? (y/n): ");
                choice = Console.ReadLine();
            }


            Console.WriteLine("See what I did there?");
        }
        static void PrintL(string msg)
        {
            Console.WriteLine(msg);
        }
        static void Print(string msg)
        {
            Console.Write(msg);
        }

    }

}
