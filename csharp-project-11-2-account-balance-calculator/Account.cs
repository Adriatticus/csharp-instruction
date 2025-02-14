namespace csharp_project_11_2_account_balance_calculator
{
    public abstract class Account : IDepositable, IWithdrawable, IBalanceable
    {
        public decimal Balance { get; set; }
        
        public Account (decimal balance)
        {
            this.Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            throw new NotImplementedException();
        }

        public decimal GetBalance()
        {
            return Balance;
        }

        public void setBalance(decimal amount)
        {
            Balance = Balance;
            //throw new NotImplementedException();
        }

        public void Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
