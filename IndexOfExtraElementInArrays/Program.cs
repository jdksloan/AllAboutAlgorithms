using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfExtraElementInArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 2, 4, 6, 8, 9, 10, 12};
            int[] arr2 = { 2, 4, 6, 8, 10, 12};
            Console.WriteLine("First Test {0}", FindExtra(arr1, arr2));
            Console.WriteLine("First B Test {0}", FindExtraBinarySearch(arr1, arr2));

            arr1 = new int[] { 3, 5, 7, 9, 11, 13}; 
            arr2 = new int[] { 3, 5, 7, 11, 13};
            Console.WriteLine("Second Test {0}", FindExtra(arr1, arr2));
            Console.WriteLine("Second B Test {0}", FindExtraBinarySearch(arr1, arr2));

            arr1 = new int[] { 3, 5, 7, 11, 13, 15};
            arr2 = new int[] { 3, 5, 7, 11, 13 };
            Console.WriteLine("Third Test {0}", FindExtra(arr1, arr2));
            Console.WriteLine("Third B Test {0}", FindExtraBinarySearch(arr1, arr2));

            arr1 = new int[] { 3, 5, 7, 11, 13,};
            arr2 = new int[] { 1, 3, 5, 7, 11, 13 };
            Console.WriteLine("Fourth Test {0}", FindExtra(arr1, arr2));
            Console.WriteLine("Fourth B Test {0}", FindExtraBinarySearch(arr1, arr2));
            Console.ReadLine();
        }

        public static int FindExtra(int[] arr1, int[] arr2)
        {
            if (arr1.Length == arr2.Length)
                return 0;

            int minsize = arr1.Length < arr2.Length ? arr1.Length : arr2.Length;
            int ans = 0;

            for (int i = 0; i < minsize; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    ans = i;
                    break;
                }

                if(i == minsize -1)
                {
                    ans = ++i;
                    break;                
                }
                
            }
            return ans;
        }

        public static int FindExtraBinarySearch(int[] arr1, int[] arr2)
        {
            int left = 0, right;
            if (arr1.Length == arr2.Length)
                return 0;
            right = arr1.Length < arr2.Length ? arr1.Length - 1: arr2.Length - 1;
            int ans = 0;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr2[mid] == arr1[mid])
                { 
                    left = mid + 1;
                    if (left == right)
                    {
                        ans = left + 1;
                    }
                }
                else
                {
                    ans = mid;
                    right = mid - 1;
                }
            }
            return ans;
            
        }
    }
}
