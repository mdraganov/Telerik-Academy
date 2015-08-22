namespace BankAccounts.Customers
{
    public abstract class Customer : IClient
    {
        public string Name { get; set; }

        public string Address { get; set; }
    }
}
