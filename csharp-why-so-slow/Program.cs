using ConsoleLibrary;

namespace csharp_why_so_slow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int one = 11;
            int two = 22;

            int sum = GetSum(one, two);
            MyConsole.PrintL(sum.ToString());



            MyConsole.PrintL("See ya!");
        }

        public static int GetSum(int value1,int value2)
        {
            int sum = value1 + value2;
            return sum;
        }
    }
}
