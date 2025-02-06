namespace csharp_project_demo_tip_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Tips!");

            string choice = "y";
            while (choice == "y")
            {
                // prompt costOfMeal: decimal
                Console.Write("Cost of meal: ");
                // skipping validation
                decimal costOfMeal = Decimal.Parse(Console.ReadLine());
                // biz logic:
                // calculate and display topAmt: decimal and totalAmt: decimal for .15, .20 and .25
                // for decimal d = .15m; d <= .25m; d +=.05
                for (decimal d = .15m; d <= .25m; d += .05m)
                {
                    decimal tipAmt = costOfMeal * d;
                    decimal totalAmt = costOfMeal + tipAmt;
                    Console.WriteLine(d.ToString("p0"));
                    Console.WriteLine("Tip Amount: "+tipAmt.ToString("c"));
                    Console.WriteLine("Total Amount: "+totalAmt.ToString("c"));
                }
                    



                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine().ToLower();
            }




        }
    }
}
