namespace BankAccounts.Accounts 
{
    public class Deposit : BankAccount
    {
        public void WithdrawMoney(decimal sum)
        {
            this.Balance -= sum;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }

            return base.CalculateInterest(months);
        }
    }
}
