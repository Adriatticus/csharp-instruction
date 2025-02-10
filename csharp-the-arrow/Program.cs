using System.Runtime.InteropServices;

namespace csharp_the_arrow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simons bow Outfitters\n");

            int size = 0;
            Console.Write("How many arrows will you need for todays hunt? ");
            bool success = int.TryParse(Console.ReadLine(), out size);
            Console.WriteLine("");
            if (!success)
            {
                Console.WriteLine("Wrong!");
            }
            else
            {
                printArrowHead(size);
            }


            Console.WriteLine("\nHappy hunting!");
        }
        public static void printArrowHead(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(">");
                }
                Console.WriteLine();


            }
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(">");
                }
                Console.WriteLine();
            }
        }

    }
}
