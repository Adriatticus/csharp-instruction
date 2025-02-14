using ConsoleLibrary;
using csharp_project_11_2_account_balance_calculator_demo.Model;

namespace csharp_project_11_2_account_balance_calculator_demo.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Gold demo!\n");

            MyConsole.PrintL("Welcome to the Account Application\n");

            MyConsole.PrintL("Starting Balances: ");
            // Initialize checkingAccount, savingsAccount
            CheckingAccount ca = new CheckingAccount(1.0m);
            ca.Balance = 1000.00m;
            SavingsAccount sa = new SavingsAccount(.01);
            sa.Balance = 1000.00m;
            DisplayBalances(ca, sa);
            // Display Starting Balances

            MyConsole.PrintL("\nEnter the transactions for the month\n");

            // while choice == "y"
            string choice = "y";
            while (choice == "y")
            {
                Account a;
                // prompt action: string (w/d)
                string action = MyConsole.PromptStrInRange("Withdraw or Deposit? (w/d): ", "w", "d");
                // prompt account: string (c/s)
                string account = MyConsole.PromptStrInRange("Checking or Saving? (c/s) ", "c", "s");
                // prompt amount: decimal
                decimal amount = MyConsole.PromptDecimal("Amount? ");
                // processTransaction
                if (account == "c")
                {
                    a = ca;
                }else
                {
                    a = sa;
                }
                if (action == "w")
                {
                    a.Withdraw(amount);
                }
                else
                {
                    a.Deposit(amount);  
                }

                // prompt continue
                choice = MyConsole.PromptStrInRange("Continue? (y/n): ", "y", "n");
            }

            sa.ApplyInterestPaymentToBalance();
            ca.SubtractFeeFromBalance();
            // processEndOfMonth - interest and fees
            MyConsole.PrintL("\nMonthly Payments and Fees:");
            // ca => subtract fee from balance
            MyConsole.PrintL("Checking Fee:                " + ca.MonthlyFee.ToString("c"));
            // sa => calc int pmt and add to balance
            MyConsole.PrintL("Saving Interest Payment: " + sa.MonthlyInterestPayment.ToString("c"));
            // Display Final Balances
            MyConsole.PrintL("\nFinal Balances");
            DisplayBalaces(ca, sa);


            MyConsole.PrintL("\nGoodbye gold!");
        }

        static void DisplayBalances(CheckingAccount ca, SavingsAccount sa)
        {
            MyConsole.PrintL("Checking: "+ca.Balance.ToString("c"));
            MyConsole.PrintL("Saving: "+sa.Balance.ToString("c"));
        }
    }
}
