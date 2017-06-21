using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythagoreanTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 3, 1, 4, 6, 5, 10, 4, 6, 12};
            int[] arr2 = { 10, 4, 6, 12, 5 };

            Console.WriteLine("Array1 {0}", isTriplet(arr1, arr1.Length));

            Console.WriteLine("Array2 {0}",  isTriplet(arr2, arr2.Length));

            Console.ReadLine();
        }

        public static bool isTriplet(int [] items, int length)
        {
            for (int i = 0; i < length; i++)
            {
                items[i] = items[i] * items[i];
            }

            Array.Sort(items);

            for (int i = length -1; i >= 2; i--)
            {
                int l = 0;
                int r = i - l;
                while (l < r)
                {
                    if (items[l] + items[r] == items[i])
                    {
                        return true;
                    }
                    else
                    {
                        var test = items[l] + items[r] < items[i] ? l++ : r--;
                    }
                }
            }

            return false;
        }
    }
}
