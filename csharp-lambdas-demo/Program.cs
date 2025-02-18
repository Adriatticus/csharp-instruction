using ConsoleLibrary;
using System.Runtime.InteropServices;

namespace csharp_lambdas_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintL("Hello!? LambDUH!");

            
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            DisplayListAsString(numbers, "Original List:");

            List<int> squares1 = new List<int>();
            foreach (int value in numbers)
            {
                squares1.Add(Square(value));
            }
            DisplayListAsString(squares1, "Squared List (1):");
            //^

            // do this again, using a method as a parameter
            List<int> squares2 = numbers.Select(Square).ToList();
            DisplayListAsString(squares2, "Squared List (2) using method as parameter");
           
            //do this again, using a lambda expression
            List<int> squares3 = numbers.Select(x => x * x).ToList();
            DisplayListAsString(squares3, "Squared List (3) using method as parameter");



            List<int> divThree1 = new List<int>();
            foreach (int value in squares1)
            {
                if (IsDivisbleByThree(value))
                {
                    divThree1.Add(value);
                }
            }
            DisplayListAsString(divThree1, "Divisible by 3 (1)");

            List<int> divThree2 = numbers.FindAll(IsDivisbleByThree).ToList();
            DisplayListAsString(divThree2, "Divisible by 3 (2)");

            List<int> divThree3 = numbers.FindAll( x => (x % 3 == 0)).ToList();
            DisplayListAsString(divThree3, "Divisible by 3 (3)");




            MyConsole.PrintL("\nBye lambies");
        }

        private static void DisplayListAsString(List<int> numbers, string header)
        {
            string result = "========================================\n";
            result += header + "\n";
            result += "========================================\n";
            foreach (var value in numbers)
            {
                result += value.ToString() + " ";
            }
            result += "\n";
            MyConsole.PrintL(result);
        }

        private static int Square(int nbr)
        {
            return nbr * nbr;
        }

        private static bool IsDivisbleByThree(int x)
        {
            return x % 3 == 0;
        }
    }
}
