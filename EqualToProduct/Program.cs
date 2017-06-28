using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualToProduct
{
    class Program
    {
        static void Main(string[] args)
        {
        
            int[] arr = { 10, 20, 9, 40 };
            int x = 400;
            Console.WriteLine("Answer = {0}", TestArr(arr, x, arr.Length));
            int[] arr1 = { 10, 20, 9, 40 };
            x = 190;
            Console.WriteLine("Answer1 = {0}", TestArr(arr1, x, arr1.Length));
            int[] arr2 = { -10, 20, 9, -40 };
            x = 400;
            Console.WriteLine("Answer2 = {0}", TestArr(arr2, x, arr2.Length));
            int[] arr3 = { -10, 20, 9, 40 };
            x = -400;
            Console.WriteLine("Answer3 = {0}", TestArr(arr3, x, arr3.Length));
            int[] arr4 = { 0, 20, 9, 40 };
            x = 0;
            Console.WriteLine("Answer4 = {0}", TestArr(arr4, x, arr4.Length));
            Console.ReadLine();
        }

        public static bool TestArr(int[] arr, int x, int n)
        {
            if (n < 2)
                return false;
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == 0)
                {
                    if (x == 0)
                        return true;
                    else
                        continue;
                }
                if (x % arr[i] == 0)
                {
                    if (set.Contains(x/arr[i]) )
                    {
                        return true;
                    }
                    set.Add(arr[i]);
                }
            }
            return false;
        }
    }
}
