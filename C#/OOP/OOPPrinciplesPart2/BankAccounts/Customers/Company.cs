namespace BankAccounts.Customers
{
    class Company : Customer
    {
        public string industrySector { get; set; }

        public bool sisterCompany { get; set; }

        public Company(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }
    }
}
