namespace csharp_project_8_1_batting_statistics_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey! This is the demo of the demo of the demo\n");

            string choice = "y";
            while (choice.ToLower() == "y")
            {
                // prompt user => nbrAtBat: int
                int nbrAtBat = PromptInt("Enter number of times at bat: ", 1, 30);
                // create array => atBat: int[nbrAtBat]
                int[] atBat = new int[nbrAtBat];
                int countAtBat = 0;
                int sumAtBat = 0;
                for (int i = 0; i < nbrAtBat; i++)
                {
                    //prompt user => result: int (result for atBat)
                    int result = PromptInt("Enter number of times at bat " + (i + 1) + ": ", 0, 4);
                    atBat[i] = result;
                    if (result > 0)
                    {
                        countAtBat++;
                    }
                    sumAtBat++;
                    double battingAvg = countAtBat / nbrAtBat;
                    double sluggingPct = sumAtBat / nbrAtBat;
                    Console.WriteLine(battingAvg.ToString("f3"));
                    Console.WriteLine(sluggingPct.ToString("f3"));
                }
                Console.Write("Another player? (y/n): ");
                choice = Console.ReadLine();

                Print("Home run!");
            }
            static void Print(string msg)
            {
                Console.WriteLine(msg);
            }

            static int PromptInt(string prompt, int min, int max)
            {
                int result = 0;
                bool success = false;
                while (!success)
                {
                    // get a valid int - TryParse?
                    Console.Write(prompt);
                    if (Int32.TryParse(Console.ReadLine(), out result))
                    {
                        // if valid - validate in range
                        if (result >= min && result <= max)
                        {
                            success = true;
                        }
                        else
                        {
                            Print("Error - must be within range.");
                        }
                    }
                    else
                    {
                        // if not valid - display a message
                        Print("Error - entry must be an integer.");
                    }
                }
                return result;



            }

        }
    }
}
