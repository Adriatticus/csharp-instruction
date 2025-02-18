using System.Security.Cryptography.X509Certificates;

namespace ConsoleLibrary
{
    public class MyConsole
    {
        public static int PromptInt(string prompt)
        {
            int result = 0;
            bool success = false;
            while (!success)
            {
                Print(prompt);
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    success = true;
                }
                else
                {
                    PrintL("Error - invalid int.");
                }
            }
            return result;

        }

        public static string PromptString(string prompt)
        {
            Print(prompt);
            return Console.ReadLine();
        }

        public static void Print(string msg)
        {
            Console.Write(msg);
        }

        public static void PrintL(string msg = "")
        {
            Console.WriteLine(msg);
        }

        public static int PromptIntInRange(string prompt, int min, int max)
        {
            int result = 0;
            bool succes = false;
            while (!succes)
            {
                Console.Write(prompt);
                if (!int.TryParse(Console.ReadLine(), out result))
                {
                    Console.WriteLine("\nError - invalid whole number. Try again\n");
                    continue;
                }
                if (result < min || result > max)
                {
                    Console.WriteLine($"\nError - input must be within the range {min}, {max}\n");
                }
                else
                {
                    succes = true;
                }
            }
            return result;
        }

        public static string PromptStrInRange(string prompt, string val1, string val2) // Example: yes, no validation
        {
            string str = "";
            bool succes = false;
            while (!succes)
            {
                Console.Write(prompt);
                str = Console.ReadLine().ToLower().Trim();
                if (str == "")
                {
                    Print("Error - entry is required.");
                }
                else if (str != val1.ToLower() && str != val2.ToLower())
                {
                    Print($"Error - entry must be either {val1} or {val2}");
                }
                else
                {
                    succes = true;
                }
            }
            return str;

        }
        public static double PromptDouble(string prompt)
        {
            double result = 0;
            bool isValid = false;
            while (!isValid)
            {
                Print(prompt);
                if (Double.TryParse(Console.ReadLine(), out result))
                {
                    isValid = true;
                }
                else
                {
                    PrintL("Error - invalid double.");
                }
            }

            return result;


        }

        public static decimal PromptDecimal(string prompt)
        {
            decimal result = 0m;
            bool isValid = false;
            while (!isValid)
            {
                Print(prompt);
                if (Decimal.TryParse(Console.ReadLine(), out result))
                {
                    isValid = true;
                }
                else
                {
                    PrintL("Error - invalid decimal.");
                }
            }

            return result;
        }
    }
}
