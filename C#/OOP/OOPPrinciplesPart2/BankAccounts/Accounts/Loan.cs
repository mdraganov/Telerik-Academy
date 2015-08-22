namespace BankAccounts.Accounts
{
    using BankAccounts.Customers;

    class Loan : BankAccount
    {
        public override decimal CalculateInterest(int months)
        {
            if (this.Client is Individual)
            {
                if (months <= 3)
                {
                    return 0;
                }
                else
                {
                    months -= 3;
                }
            }
            else
            {
                if (months <= 2)
                {
                    return 0;
                }
                else
                {
                    months -= 3;
                }
            }

            return base.CalculateInterest(months);
        }
    }
}
