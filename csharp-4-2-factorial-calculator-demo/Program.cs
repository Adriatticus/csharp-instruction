using System.ComponentModel.Design;

namespace csharp_4_2_factorial_calculator_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! We're going to follow along with Demo for exercise");

            Console.WriteLine("Welcome to the Factorial Calculator");

            string choice = "y";
            while (choice.ToLower() == "y")
            {
                long LongE = GetLong("Enter an integer that's greater than 0 and less than 1000: ", 1, 1000);
                //get input IntE: long
                // for i = 1, i <= IntE, i++ => factorial =factorial * 1
                long theFactorial = 1;
                for (int i = 1; i <= LongE; i++)
                {
                    //theFactorial = theFactorial * i;
                    theFactorial *= i;
                }
                Console.WriteLine("The factorial of " + LongE + " is " + theFactorial + ".");

                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine().ToLower();
            }
            // 0 < IntE < 10
            //compute the factorial w/ for loop: long


            Console.WriteLine("Felling any faster?");
        }
        private static long GetLong(string prompt, long min, long max)
        {
            long result = 0;
            bool success = false;
            while (!success)
            {
                Console.Write(prompt);
                if (!long.TryParse(Console.ReadLine(), out result))
                {
                    Console.WriteLine("Error - invalid whole number. Try again");
                    continue;
                }
                if (result < min || result > max)
                {
                    Console.WriteLine("Error - input must be within the range (" + min + " " + max + ").");
                }
                else
                {
                    success = true;
                }

            }

            return result;
        }

    }
}
