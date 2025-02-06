namespace csharp_project_8_1_batting_statistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Louisville Sluggers are bats and therefore have wings.");

            string choice = "y";
            while (choice.ToLower() == "y")
            {
                int BatE = 1;
                Print("\nEnter number of times at bat: ");
                bool success = Int32.TryParse(Console.ReadLine(), out BatE);
                if (!success)
                {
                    Print("\nError - enter INTEGER between 1 and 30");
                    continue;
                }
                else if (BatE <= 0 || BatE >=31)
                {
                    Print("\nError - enter integer BETWEEN 1 and 30");
                    continue;
                }
                else
                {
                    PrintL("\n0 = out, 1 = single, 2 = double, 3 = triple, 4 = home run");
                    int[] BatsN = new int[BatE];
                    PrintL(BatsN.ToString);//how do I print this bitch to check it? Do I need to establish the columns???






                }
                Print("\n\nContinue (y/n): ");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Since...you know. A bat scientist and baseball enthusiast named a bat");
        }

        private static void PrintL(string msg)
        {
            Console.WriteLine(msg);
        }
        private static void Print(string msg)
        {
            Console.Write(msg);
        }

    }
}
