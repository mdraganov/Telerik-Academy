namespace Person
{
    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }

        public double? Age { get; set; }

        public string  Name { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1}", this.Name, (object)this.Age ?? "N/A, no age entered");
        }
    }
}
