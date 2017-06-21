using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinDifferenceInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 19, -4, 31, 38, 25, 100 };
            Console.WriteLine("Min Difference {0}", FindMinDifference(arr));
            Console.ReadLine();
        }

        public static int FindMinDifference(int[] arr)
        {
            Array.Sort(arr);
            int diff = Int32.MaxValue;
            for (int i = 0; i < arr.Length -1; i++)
            {
                if (arr[i + 1] - arr[i] < diff)
                    diff = arr[i + 1] - arr[i];
            }
            return diff;
        }
    }
}
