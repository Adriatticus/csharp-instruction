
namespace csharp_project_11_2_account_balance_calculator_demo.Model
{
    internal class Account : IDepositable, IWithdrawable, IBalancable
    {
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
}
