namespace csharp_make_chocolate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chocolate Time!!");


            Console.Write("makeChocolate(4, 1, 9) -> ");
            Console.WriteLine(makeChocolate(4, 1, 9).ToString());

            Console.Write("makeChocolate(4, 1, 9) -> ");
            Console.WriteLine(makeChocolate(4, 1, 10).ToString());

            Console.Write("makeChocolate(4, 1, 9) -> ");
            Console.WriteLine(makeChocolate(4, 1, 7).ToString());



            Console.WriteLine("Yum!");
        }
        public static int makeChocolate(int small, int big, int goal)
        {
            int remaining = goal % 5;
            if ((goal > (big * 5 + small)) || (remaining > small)) 
            {
                return -1;
            }
            else
            {
                return remaining;
            }
            return 0;

        }

    }
}
