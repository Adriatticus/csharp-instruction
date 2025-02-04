using System.Xml.Serialization;

namespace csharp_project_3_3_interest_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Good luck affording a house in this economy!\n");

            Console.WriteLine("Welcome to the Interest Calculator\n");

            string choice = "y";
            while (choice.ToLower() == "y")
            {


                Console.Write("\nEnter loan amount:\t");
                double loanA = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter interest rate:\t");
                double interestR = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nLoan amount:\t\t" + loanA.ToString("c"));
                Console.WriteLine("Interest rate:\t\t" + interestR.ToString("p3"));
                double interestA = loanA * interestR;
                Console.WriteLine("Interest:\t\t" + interestA.ToString("c"));

                Console.Write("\nContinue? (y/n) ");
                choice = Console.ReadLine();
            }

            Console.WriteLine("Open house baby!");




        }
    }
}
