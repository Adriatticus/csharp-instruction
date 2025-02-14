namespace csharp_project_11_2_account_balance_calculator
{
    public class SavingsAccount : Account
    {
        public decimal InterestRate { get; set; }
        public decimal InterestPayment {  get; set; }

        public SavingsAccount (decimal balance, decimal interestRate) :
            base(balance)
        {
            this.InterestRate = interestRate;
        }

        public decimal CalcIntPayment()
        {
            return Balance * InterestRate;
        }

        public void AddPayment()
        {

        }






    }
}
