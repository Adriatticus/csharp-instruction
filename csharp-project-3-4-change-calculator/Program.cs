namespace csharp_project_3_4_change_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Keep the change! Ya filthy animal!!!");

            Console.WriteLine("\nWelcome to the Change Calculator");

            string choice = "y";
            while (choice.ToLower() == "y")
            {
                Console.Write("\nEnter number of cents (0-99): ");
                int noc = Convert.ToInt32(Console.ReadLine());
                int q = noc / 25;
                int d = (noc % 25) / 10;
                int n = ((noc % 25) % 10) / 5;
                int p = ((noc % 25) % 10) % 5;
                Console.WriteLine("\nQuarters: " + q);
                Console.WriteLine("Dimes:\t  " + d);
                Console.WriteLine("Nickels:  " + n);
                Console.WriteLine("Pennies:  " + p);

                Console.Write("\nContinue? (y/n): ");
                choice = Console.ReadLine();

            }

            Console.WriteLine("That's a Home Alone reference");
        }
    }
}
