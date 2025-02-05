namespace csharp_project_4_1_table_of_powers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Table of Powers, this is a list of super powers");

            string choice = "y";
            while (choice == "y")
            {
                Print("Enter an integer: ");
                int IntE = Int32.Parse(Console.ReadLine());
                

            }

            Console.WriteLine("My the table of powers grant you strength");
        }

        static void PrintL(string msg)
        {
            Console.WriteLine(msg);
        }
        static void Print(string msg) 
        {
            Console.Write(msg);
        }
        static void Empty(string msg)
        {
            Console.WriteLine("");
        }

    }
}