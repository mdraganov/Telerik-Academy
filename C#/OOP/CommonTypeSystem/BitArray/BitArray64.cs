namespace BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    class BitArray : IEnumerable<int>, IComparable
    {
        private ulong bits;

        public BitArray(ulong number)
        {
            this.Bits = number;
        }

        public ulong Bits
        {
            get { return bits; }
            set { bits = value; }
        }

        public int this[int pos]
        {
            get
            {
                if (pos < 0 || pos >= 64)
                {
                    throw new IndexOutOfRangeException("Invalid position.");
                }

                return ((int)(this.Bits >> pos) & 1);
            }
            set
            {
                if (pos < 0 || pos >= 64)
                {
                    throw new IndexOutOfRangeException("Invalid position.");
                }

                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Invalid bit value.");
                }

                if (((int)(this.Bits >> pos) & 1) != value)
                {
                    this.Bits ^= (1ul << pos);
                }
            }
        }

        public static bool operator ==(BitArray ba1, BitArray ba2)
        {
            return (ba1.Equals(ba2));
        }

        public static bool operator !=(BitArray ba1, BitArray ba2)
        {
            return !(ba1.Equals(ba2));
        }



        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int pos = 0; pos < 64; pos++)
            {
                result.Insert(0, ((this.Bits >> pos) & 1));
            }

            return result.ToString();
        }

        public override int GetHashCode()
        {
            return this.Bits.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.Bits.Equals((obj as BitArray).Bits);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int pos = 0; pos < 64; pos++)
            {
                yield return this[pos];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int CompareTo(object obj)
        {
            return this.Bits.CompareTo((obj as BitArray).Bits);
        }
    }
}
