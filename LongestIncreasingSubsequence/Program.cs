using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 3, 10, 2, 1, 20 };
            Console.WriteLine("Length of LIS = {0}", LIS(arr1));
            //Output: Length of LIS = 3
            //The longest increasing subsequence is 3, 10, 20


            int[] arr2 = { 3, 2 };
            Console.WriteLine("Length of LIS = {0}", LIS(arr2));
            //Output: Length of LIS = 1
            //The longest increasing subsequences are { 3} and { 2}

            int[] arr3 = { 50, 3, 10, 7, 40, 80 };
            Console.WriteLine("Length of LIS = {0}", LIS(arr3));
            //Output: Length of LIS = 4
            //The longest increasing subsequence is { 3, 7, 40, 80}

            Console.ReadLine();
        }

        public static int LIS(int[] arr)
        {
            if (arr.Length == 1)
                return 1;

            int i, j, max = 0; ;

            int[] lis = new int[arr.Length];
            for (i = 0; i < arr.Length; i++)
                lis[i] = 1;

            for (i = 1; i < arr.Length; i++)
                for (j = 0; j < i; j++)
                    if (arr[i] > arr[j] && lis[i] < lis[j] + 1)
                        lis[i] = lis[j] + 1;

            for (i = 0; i < arr.Length; i++)
                if (max < lis[i])
                    max = lis[i];

            return max;
        }
    }
}
