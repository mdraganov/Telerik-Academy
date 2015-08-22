namespace BankAccounts.Customers
{
    public class Individual : Customer
    {
        public float Age { get; set; }

        public string Occupation { get; set; }

        public decimal Salary { get; set; }

        public Individual(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }
    }
}
