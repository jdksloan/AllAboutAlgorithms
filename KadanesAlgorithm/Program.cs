using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KadanesAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -2, -3, 4, -1, -2, 1, 5, -3 };
            Console.WriteLine("Answer = {0}", LongestContiguous(arr, arr.Length));
            Console.ReadLine();
        }

        public static int LongestContiguous(int[] arr, int n)
        {
            int max_end = arr[0], max_so_far = arr[0];

            for (int i = 1; i < n; i++)
            {
                max_end = Math.Max(arr[i], max_end + arr[i]);
                max_so_far = Math.Max(max_so_far, max_end);
            }

            return max_so_far;
        }
    }
}
