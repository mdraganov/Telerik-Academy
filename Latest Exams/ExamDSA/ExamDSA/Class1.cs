//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1
//{
//    class Program
//    {
//        static void MockInput()
//        {
//            var input = @"word
//worldfullwithwordsandwords";
//            Console.SetIn(new StringReader(input));
//        }

//        static void Main()
//        {
//            //MockInput();

//            var word = Console.ReadLine();
//            var text = Console.ReadLine();
//            var prefixesValues = new HashSet<ulong>();
//            var suffixesValues = new HashSet<ulong>();
//            var prefixesHitCounts = new Dictionary<int, int>();
//            var suffixesHitCounts = new Dictionary<int, int>();
//            var combinations = 0;

//            var wordHash = new Hash(word);

//            for (int i = 1; i < word.Length; i++)
//            {
//                var prefix = word.Substring(0, i);
//                var suffix = word.Substring(i, word.Length - i);

//                var prefixHash = new Hash(prefix);
//                var suffixHash = new Hash(suffix);

//                prefixesValues.Add(prefixHash.Value1);
//                prefixesValues.Add(prefixHash.Value2);
//                suffixesValues.Add(suffixHash.Value1);
//                suffixesValues.Add(suffixHash.Value2);
//            }


//            for (int i = 1; i <= word.Length; i++)
//            {
//                for (int j = 0; j <= text.Length - i; j++)
//                {
//                    var substring = text.Substring(j, i);
//                    var textHash = new Hash(substring);

//                    if (i == word.Length)
//                    {
//                        if (textHash.Value1 == wordHash.Value1 &&
//                            textHash.Value2 == wordHash.Value2)
//                        {
//                            combinations++;
//                            //Console.WriteLine(substring);
//                        }

//                        continue;
//                    }

//                    if (prefixesValues.Contains(textHash.Value1) && prefixesValues.Contains(textHash.Value2))
//                    {
//                        //Console.WriteLine(substring);
//                        if (!prefixesHitCounts.ContainsKey(i))
//                        {
//                            prefixesHitCounts[i] = 0;
//                        }
//                        prefixesHitCounts[i]++;
//                    }

//                    if (suffixesValues.Contains(textHash.Value1) && suffixesValues.Contains(textHash.Value2))
//                    {
//                        //Console.WriteLine(substring);
//                        if (!suffixesHitCounts.ContainsKey(i))
//                        {
//                            suffixesHitCounts[i] = 0;
//                        }
//                        suffixesHitCounts[i]++;
//                    }
//                }
//            }

//            foreach (var count in prefixesHitCounts)
//            {
//                combinations += count.Value * suffixesHitCounts[word.Length - count.Key];
//                //Console.WriteLine(combinations);
//            }

//            //Console.ReadLine();
//            Console.WriteLine(combinations);
//        }
//    }

//    class Hash
//    {
//        private const ulong BASE1 = 31;
//        private const ulong MOD1 = 1000000033;
//        private const ulong BASE2 = 37;
//        private const ulong MOD2 = 1000000007;

//        private static ulong[] powers1;
//        private static ulong[] powers2;

//        public static void ComputePowers(int n)
//        {
//            powers1 = new ulong[n + 1];
//            powers2 = new ulong[n + 1];
//            powers1[0] = 1;
//            powers2[0] = 1;

//            for (int i = 0; i < n; i++)
//            {
//                powers1[i + 1] = powers1[i] * BASE1 % MOD1;
//                powers2[i + 1] = powers2[i] * BASE2 % MOD2;
//            }
//        }

//        public ulong Value1 { get; private set; }

//        public ulong Value2 { get; private set; }

//        public Hash(string str)
//        {
//            this.Value1 = 0;
//            this.Value2 = 0;

//            foreach (char c in str)
//            {
//                this.Add(c);
//            }
//        }

//        public void Add(char c)
//        {
//            this.Value1 = (this.Value1 * BASE1 + c) % MOD1;
//            this.Value2 = (this.Value2 * BASE2 + c) % MOD2;
//        }

//        public void Remove(char c, int n)
//        {
//            this.Value1 = (MOD1 + this.Value1 - powers1[n] * c % MOD1) % MOD1;
//            this.Value2 = (MOD2 + this.Value2 - powers2[n] * c % MOD2) % MOD2;
//        }
//    }
//}
