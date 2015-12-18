using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void MockInput()
        {
            var input = @"word
worldfullwithwordsandwords";
            Console.SetIn(new StringReader(input));
        }

        static void Main()
        {
            MockInput();

            var word = Console.ReadLine();
            var text = Console.ReadLine();
            var prefixesValues = new HashSet<ulong>();
            var suffixesValues = new HashSet<ulong>();
            var prefixesHitCounts = new Dictionary<int, ulong>();
            var suffixesHitCounts = new Dictionary<int, ulong>();
            ulong combinations = 0;

            var wordHash = new Hash(word);

            for (int i = 1; i < word.Length; i++)
            {
                var prefix = word.Substring(0, i);
                var suffix = word.Substring(i, word.Length - i);

                var prefixHash = new Hash(prefix);
                var suffixHash = new Hash(suffix);

                prefixesValues.Add(prefixHash.Value1);
                prefixesValues.Add(prefixHash.Value2);
                suffixesValues.Add(suffixHash.Value1);
                suffixesValues.Add(suffixHash.Value2);
            }

            Hash.ComputePowers(word.Length);
            for (int length = 1; length <= word.Length; length++)
            {
                var textHash = new Hash(text.Substring(0, length));

                for (int j = 0; j < text.Length - length; j++)
                {
                    if (length == word.Length)
                    {
                        if (textHash.Value1 == wordHash.Value1 &&
                            textHash.Value2 == wordHash.Value2)
                        {
                            combinations++;
                            //Console.WriteLine(text.Substring(j, i));
                        }

                        textHash.Add(text[j + length]);
                        textHash.Remove(text[j], length);

                        continue;
                    }

                    if (prefixesValues.Contains(textHash.Value1) && prefixesValues.Contains(textHash.Value2))
                    {
                        //Console.WriteLine(text.Substring(j, i));
                        if (!prefixesHitCounts.ContainsKey(length))
                        {
                            prefixesHitCounts[length] = 0;
                        }
                        prefixesHitCounts[length]++;
                    }

                    if (suffixesValues.Contains(textHash.Value1) && suffixesValues.Contains(textHash.Value2))
                    {
                        //Console.WriteLine(text.Substring(j, i));
                        if (!suffixesHitCounts.ContainsKey(length))
                        {
                            suffixesHitCounts[length] = 0;
                        }
                        suffixesHitCounts[length]++;
                    }

                    textHash.Add(text[j + length]);
                    textHash.Remove(text[j], length);
                }
            }

            foreach (var count in prefixesHitCounts)
            {
                combinations += count.Value * suffixesHitCounts[word.Length - count.Key];
                //Console.WriteLine(combinations);
            }

            //Console.ReadLine();
            Console.WriteLine(combinations);
        }
    }

    class Hash
    {
        private const ulong BASE1 = 257;
        private const ulong MOD = 1000000033;
        private const ulong BASE2 = 307;

        private static ulong[] powers1;
        private static ulong[] powers2;

        public static void ComputePowers(int n)
        {
            powers1 = new ulong[n + 1];
            powers2 = new ulong[n + 1];
            powers1[0] = 1;
            powers2[0] = 1;

            for (int i = 0; i < n; i++)
            {
                powers1[i + 1] = powers1[i] * BASE1 % MOD;
                powers2[i + 1] = powers2[i] * BASE2 % MOD;
            }
        }

        public ulong Value1 { get; private set; }

        public ulong Value2 { get; private set; }

        public Hash(string str)
        {
            this.Value1 = 0;
            this.Value2 = 0;

            foreach (char c in str)
            {
                this.Add(c);
            }
        }

        public void Add(char c)
        {
            this.Value1 = (this.Value1 * BASE1 + c) % MOD;
            this.Value2 = (this.Value2 * BASE2 + c) % MOD;
        }

        public void Remove(char c, int n)
        {
            this.Value1 = (MOD + this.Value1 - powers1[n] * c % MOD) % MOD;
            this.Value2 = (MOD + this.Value2 - powers2[n] * c % MOD) % MOD;
        }
    }
}
