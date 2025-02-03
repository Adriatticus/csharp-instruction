using System.Diagnostics.CodeAnalysis;

namespace csharp_project_2_3_rectanglue_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello ya bunch a lame squares!");

            Console.WriteLine("\nWelcome to the Area and Perimeter Calculator");

            string choice = "y";
            while (choice == "y" || choice == "Y") // || means 'or'
            {
                Console.Write("\nEnter length: ");
                decimal length = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter width: ");
                decimal width = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Area: " + (width * length));
                Console.Write("\nPerimeter: " + ((2 * width) + (2 * length)));

                Console.Write("\n\nContinue? (y/n): ");
                choice = Console.ReadLine();
            }
            Console.WriteLine("\nCalculations complete.");
        }
    }
}
