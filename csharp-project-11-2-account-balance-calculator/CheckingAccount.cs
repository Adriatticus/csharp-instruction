namespace csharp_project_11_2_account_balance_calculator
{
    public class CheckingAccount : Account
    {
        decimal MonthlyFee { get; set; }


        public CheckingAccount(decimal monlthyFee, decimal balance) :
            base(balance)
        {
            this.MonthlyFee = monlthyFee;  
        }

    }

}   

