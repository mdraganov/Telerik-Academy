using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwords
{
    class Program
    {
        static int passLength;
        static string keyPresses;
        static int k;
        static int count;
        static int[] pass;
        static int smaller;
        static int bigger;
        static int level;

        static void MockInput()
        {
            var input = @"7
<=>>=<
23";
            Console.SetIn(new StringReader(input));
        }

        static void Main()
        {
            MockInput();

            passLength = int.Parse(Console.ReadLine());
            keyPresses = Console.ReadLine();
            k = int.Parse(Console.ReadLine());
            count = 0;


            pass = new int[passLength];

            smaller = 0;
            bigger = 0;
            level = 0;
            Magic(0);


            GetPass(0, 0, 0);
        }

        public static void Magic(int index)
        {
            if (index >= keyPresses.Length)
            {
                return;
            }

            if (keyPresses[index] == '<')
            {
                //if (level == 0)
                //{
                //    smaller++;
                //}
                //else 
                if (level > 0)
                {
                    smaller++;
                    level++;
                }
                else
                {
                    bigger--;
                    level++;
                }
            }

            if (keyPresses[index] == '>')
            {
                //if (level == 0)
                //{
                //    bigger++;
                //}
                //else 
                if (level > 0)
                {
                    smaller++;
                    level--;
                }
                else
                {
                    bigger++;
                    level--;
                }
            }            

            Magic(index + 1);
        }

        public static void GetPass(int index, int min, int max)
        {
            if (count >= k)
            {
                return;
            }

            if (index >= pass.Length)
            {
                count++;

                if (k == count)
                {
                    Console.WriteLine(string.Join("", pass));
                }

                return;
            }

            for (int i = min; i <= max; i++)
            {
                if (i == 10)
                {
                    pass[index] = 0;
                }
                else
                {
                    pass[index] = i;
                }

                var nextDir = keyPresses[index + 1];
                var nextMin = min;
                var nextMax = max;
                if (nextDir == '>')
                {
                    nextMax++;
                }
                else if (nextDir == '<')
                {
                    nextMax--;
                }

                GetPass(index + 1, nextMin, nextMax);
            }
        }
    }
}
