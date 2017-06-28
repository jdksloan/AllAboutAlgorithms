using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7};
            
            int d = 2;
            int n = 7;
            Console.WriteLine(String.Join(",", RotateLeft(array,d ,n)));
            Console.ReadLine();
        }

        public static int [] RotateLeft(int[] arr, int d, int n)
        {
            if (d == 0 | n == 0)
                return arr;
            //d = number to move
            //n = length of array
            int i, j, k, temp;
            for (i = 0; i < GetGCD(d, n); i++)
            {
                temp = arr[i];
                j = i;
                while (true)
                {

                    k = j + d;
                    if (k >= n)
                        k = k - n;
                    if (k == i)
                        break;
                    arr[j] = arr[k];
                    j = k;
                }
                arr[j] = temp;
            }
            return arr;
        }


        public static int GetGCD(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return GetGCD(b, a % b);
        }
    }
}
