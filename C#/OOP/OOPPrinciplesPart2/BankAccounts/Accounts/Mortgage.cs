namespace BankAccounts.Accounts
{
    using BankAccounts.Customers;

    class Mortgage : BankAccount
    {
        public override decimal CalculateInterest(int months)
        {
            if (this.Client is Individual)
            {
                if (months <= 6)
                {
                    return 0;
                }
                else
                {
                    months -= 6;                    
                }
            }
            else
            {
                if (months <= 12)
                {
                    return base.CalculateInterest(months) / 2;
                }
                else
                {
                    return base.CalculateInterest(12) / 2 + base.CalculateInterest(months - 12);
                }
            }

            return base.CalculateInterest(months);
        }
    }
}