﻿namespace csharp_project_11_2_account_balance_calculator_demo.Model
{
    internal class SavingsAccount : Account
    {
        public decimal MonthlyInterestRate { get; set; }
        public decimal MonthlyInterestPayment {  get; set; }
        
       
        public SavingsAccount(decimal monthlyInterestRate)
        {
            this.MonthlyInterestRate = monthlyInterestRate;
        }

        public void ApplyInterestPaymentToBalance()
        {
            MonthlyInterestPayment = Balance * MonthlyInterestRate;
            Balance += MonthlyInterestPayment;
        }







    }
}