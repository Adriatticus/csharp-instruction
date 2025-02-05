namespace csharp_chapter7_demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int nbr1 = 0;
            while (true)
            {
                Console.WriteLine("Enter an integer: ");
                if (!Int32.TryParse(Console.ReadLine(), out nbr1))
                {
                    Console.WriteLine("Error - enter whole number");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("You entered: " + nbr1);

            Console.WriteLine("Beye!");
        }
    }
}
