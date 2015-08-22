namespace StringBuilderSubstring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class SubstringExtention
    {
        static StringBuilder Substring(this StringBuilder value, int startIndex, int length)
        {
            string result = value.ToString(startIndex, length);
            
            return new StringBuilder(result);
        }

        static void Main()
        {
            string str = "Test of extention.";

            StringBuilder sb = new StringBuilder(str);

            sb = sb.Substring(1, 10);

            Console.WriteLine(sb);
        }
    }
}
