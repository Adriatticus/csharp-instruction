using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;

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
                int BatsE = 1;
                Print("\nEnter number of times at bat: ");
                bool successInput1 = Int32.TryParse(Console.ReadLine(), out BatsE);
                if (!successInput1)
                {
                    Print("\nError - enter INTEGER between 1 and 30");
                    continue;
                }
                else if (BatsE <= 0 || BatsE >= 31)
                {
                    Print("\nError - enter integer BETWEEN 1 and 30");
                    continue;
                }
                else
                {
                    PrintL("\n0 = out, 1 = single, 2 = double, 3 = triple, 4 = home run");
                    //Print("Result for at-bat (number that I have to generate somehow in a : ")
                    double slugsum = 0;
                    double bases = 0;
                    int[] HitsA = new int[BatsE];
                    for (int i = 0; i < BatsE; i++)
                    {
                        //Console.Write("Result for at-bat " + rat++ + ": ");
                        Console.Write("Result for at-bat " + (i + 1) + ": ");
                        bool successInput2 = Int32.TryParse(Console.ReadLine(), out HitsA[i]);
                        if (!successInput2)
                        {
                            Print("\nError - enter 0, 1, 2, 3, or 4");
                            i--;
                            continue;
                        }
                        else if (HitsA[i] < 0 || HitsA[i] > 4)
                        {
                            Print("\nError - enter 0, 1, 2, 3, or 4");
                            i--;
                            continue;
                        }
                        else
                        {
                            slugsum += HitsA[i];
                            if (HitsA[i] > 0)
                            {
                                bases++;
                            }


                        }

                    }
                    double BatAvg = bases / BatsE;
                    double SlugPer = slugsum / BatsE;
                    Console.WriteLine("\nBatting average: " + BatAvg.ToString("f3"));
                    Console.WriteLine("Slugging percentage: " + SlugPer.ToString("f3"));

                    //sum of hits A (sum of hitsa length /BatsE is slugging percentage slugsum/ batse
                    //how many of HitsA aren't 0 (bases) / batse


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
