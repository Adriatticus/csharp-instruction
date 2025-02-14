using ConsoleLibrary;

namespace csharp_project_11_2_account_balance_calculator
{
    internal class AccountBalanceApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gold bag!\n");

            CheckingAccount ca = new CheckingAccount(1m, 1000m);
            SavingsAccount sa = new SavingsAccount(1000m, .01);


            MyConsole.PrintL("\nMore gold for gold bad?");
        }
    }
}
