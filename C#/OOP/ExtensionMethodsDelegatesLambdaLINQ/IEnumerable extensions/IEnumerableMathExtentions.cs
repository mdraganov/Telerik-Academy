using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{
    public class IEnumerableMathExtentions
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            dynamic sum = 0;

            foreach (var item in collection)
            {
                sum += item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            dynamic product = 1;

            foreach (var item in collection)
            {
                product *= item;
            }
            
            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection)
            where T : IComparable<T>
        {
            T result = collection.First();

            foreach (var item in collection)
            {
                if (item.CompareTo(result) < 0)
                {
                    result = item;
                }
            }

            return result;
        }

        public static T Max<T>(this IEnumerable<T> collection)
            where T : IComparable<T>
        {
            T result = collection.First();

            foreach (var item in collection)
            {
                if (item.CompareTo(result) > 0)
                {
                    result = item;
                }
            }

            return result;
        }

        public static T Average<T>(this IEnumerable<T> collection)
        {
            dynamic product = 1;

            foreach (var item in collection)
            {
                product *= item;
            }

            return product / collection.Count();
        }

        static void Main()
        {


        }
    }
}
