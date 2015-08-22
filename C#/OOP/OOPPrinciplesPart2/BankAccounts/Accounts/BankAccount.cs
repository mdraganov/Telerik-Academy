namespace BankAccounts.Accounts
{
    using System;
    using BankAccounts.Customers;

    public abstract class BankAccount
    {
        public IClient Client { get; set; }

        public decimal Balance { get; set; }

        public decimal InterestRate { get; set; }

        public DateTime AccountStartDate { get; set; }

        public virtual decimal CalculateInterest(int months)
        {
            return this.InterestRate * months;
        }

        public void DepositMoney(decimal sum)
        {
            this.Balance += sum;
        }
    }
}
