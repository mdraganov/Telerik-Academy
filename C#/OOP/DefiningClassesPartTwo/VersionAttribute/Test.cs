namespace VersionAttribute
{
    using System;

    [VersionAttribute("2.10")]
    class Test
    {
        static void Main()
        {
            Type type = typeof(Test);

            var attribute = type.GetCustomAttributes(false);

            foreach (VersionAttribute item in attribute)
            {
                Console.WriteLine(item.GetType().Name);
                Console.WriteLine("Version[{0}.{1}]", item.Major, item.Minor);
            }
        }
    }
}
