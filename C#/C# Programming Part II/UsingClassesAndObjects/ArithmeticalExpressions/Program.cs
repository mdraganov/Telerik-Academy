using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticalExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1.33f;
            double b = 1f;
            double c = 0.33f;
            

            bool check = a == b + c;

            Console.Write("1.33 = {0}\n 1 = {1}\n 0.33= {2}\n", a, b, c);
        }
    }
}
