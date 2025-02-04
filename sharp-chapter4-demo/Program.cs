using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Ch04DemoNumbersStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Numbers and Strings Demo!");
            int dayOfWeek = 5;
            decimal price = 11.99m;
            int quantity = 3;
            char letter = 'A';
            bool isValid = false;
            double interestRate = .0367;
            
           

            // constants Pascal for naming constants - Like Title case

            const int DaysInWeek = 7;
            const int DaysInNovember = 30;
            const int DAYS_IN_YEAR = 365;

            // arithmatic operators

            decimal lineItemTotal = price * quantity;
            int count = 0;
            Console.WriteLine("count =" +count);
            count = count + 1;
            Console.WriteLine("count = " + count);
            count++;
            Console.WriteLine("count = " + count);

            int a = 9;
            int b = 2; 
            int quotient = 9 / 2;
            int remainder = 9 % 2;
            Console.WriteLine("quotient = " + quotient);
            Console.WriteLine("remainder = " +remainder);

            double result = a / b;
            double c = 9.0;
            double d = 2.0;
            result = c / d;
            Console.WriteLine("result =" +result);

            

            //Assignment operations
            int counter = count + 1;
            count++;
            count += 1;
            Console.WriteLine("counter = "+counter);

            // add 5 to counter
            counter = counter + 5;
            counter += 5;

            // subtract 2 from counter
            counter -= 2;

            // casting

            int e = 5;
            double f = e;

            double g = 6.7;
            int h = (int)g;
            Console.WriteLine("h = "+h); // h is 6

            //Math class

            interestRate = .0347825;
            Console.WriteLine("interestRate = " + interestRate);

            // rounded to 4 decimal places

            interestRate = Math.Round(interestRate, 4);

            // Random class

            Random rand = new Random();
            int r1 = rand.Next();
            Console.WriteLine("r1 = "+r1);
            int dieRoll = rand.Next(1, 7);
            Console.WriteLine("dieRoll ="+dieRoll);

            // Strings
            string firstName = "Bob";
            string lastName = "Marley";
            // string fullName = firstName + " " + lastName;
            string fullName = firstName;
            fullName += " ";
            fullName += lastName;

            // escape sequences - tab, newLine, backslash
            string sentence = "abc\tdef\nghi";
            string reposFolder = "c\\repos";
            Console.WriteLine(sentence);

            string rawMessage = """
            hell there
            how are you?

            I'm fine, how are you??
                Time to go home???
            """;
            Console.WriteLine(rawMessage);

            //get input fromt the console
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            // basic while loop:
            // execute the 2 numbers and sum until user is done

            string choice = "y";
            while (choice == "y")
            {
                Console.WriteLine("Enter 2 whole number: ");
                try
                {
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("sum =" + (n1 + n2));
                    Console.WriteLine("Continue? (y/n): ");
                }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }
                choice = Console.ReadLine();
            }

            // if statement
            // discount %:
            // if about > 1000, discPct = .10
            // else if amount > 800, discPct = .08
            // else if amount > 500, discPct = .05
            // otherwise discPct = .00

            double amount = 900;
            double discPct = 0.0;
            if (amount >= 1000)
            {
                discPct = .1;
            }
            else if (amount >= 800)
            {
                discPct = .8;
            }
            else if (amount >= 500)
            {
                discPct = .5;
            }
            else
            {
                discPct = 0.0;
                //do we need and else if  amount < 500 discPct 0?
                Console.WriteLine("Bye");
            }


        }
    }
}
