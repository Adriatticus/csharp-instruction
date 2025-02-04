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
                double length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter width: ");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.Write("Area: " + (width * length));
                Console.Write("\nPerimeter: " + ((2 * width) + (2 * length)));

                Console.Write("\n\nContinue? (y/n): ");
                choice = Console.ReadLine();
            }
            Console.WriteLine("\nCalculations complete.");

            //create and area variable
            // double area = length * width;
            // double perimeter = 2 * length + 2 * width;
            // Console.writeline = "Area: "+ Area ( then do the same for perimiter)
        }
    }
}
