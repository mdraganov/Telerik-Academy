namespace Person
{
    class TestPerson
    {
        static void Main()
        {
            Person someone = new Person("Pesho") { Age = 25};
            System.Console.WriteLine(someone);
            Person anotherone = new Person("Gosho");
            System.Console.WriteLine(anotherone);
        }
    }
}
