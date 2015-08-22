using System;

class ReplaceTags
{
    static void Main()
    {
        string html = Console.ReadLine();
        string replaced = html.Replace(@"<a href=""", "[URL=").Replace("\">", "]").Replace("</a>", "[/URL]");

        Console.WriteLine(replaced);
    }
}
