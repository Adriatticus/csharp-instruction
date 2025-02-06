using System.Reflection.Metadata.Ecma335;

namespace csharp_project_4_1_table_of_powers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Table of Powers, this is a list of super powers!");
            Empty();
            string choice = "y";
            while (choice.ToLower() == "y")
            {
                int IntE = 0;
                Print("\nEnter an integer: ");
                
                bool success = Int32.TryParse(Console.ReadLine(), out IntE);
                if (!success)
                {
                    PrintL("\nWhy no int? Try again.\n");
                }
                else
                {
                    PrintL("\nWe did the int? " + IntE);
                    PrintL("\nNumber\tSquared\tCubed");
                    PrintL("======\t=======\t=====");
                    for (int i = 1; i<=IntE; i++ )
                    {
                        PrintPowers(i); 
                    }
                }
                Print("\nContinue? (y/n): ");
                choice = Console.ReadLine();
                






            }

            Console.WriteLine("My the table of powers grant you strength");
        }

        private static void PrintPowers(int IntE)
        {
            PrintL(IntE + "\t" + GetSquared(IntE) + "\t" + GetCubed(IntE));
        }

        static void PrintL(string msg)
        {
            Console.WriteLine(msg);
        }
        static void Print(string msg) 
        {
            Console.Write(msg);
        }
        static void Empty()
        {
            Console.WriteLine("");
        }
        static int GetSquared(int num)
        {
            num = num * num;
            return num;
        }
        static int GetCubed(int num3p)
        {
            return num3p * num3p * num3p;   
        }

    }
}