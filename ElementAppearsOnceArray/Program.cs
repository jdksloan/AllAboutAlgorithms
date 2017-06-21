using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementAppearsOnceArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] a = { 12, 1, 12, 3, 12, 1, 1, 2, 3, 2, 2, 3, 7 };
            int[] a = { 12, 1, 12, 3, 12, 1, 1, 2, 3, 3 };
            int s = SingularOfThree(a);
            Console.WriteLine("Singular of three Value that appears once is {0}.", s);

            a = new int[] { 1, 4, 2, 1, 3, 4, 2 };
            s = SingularOfTwo(a);
            Console.WriteLine("Singular of two value that appears once is {0}.", s);

            Console.ReadLine();
        }

        //For an array that has 3 of eveything else;
        static int SingularOfThree(int[] array)
        {
            int a = 0;
            int b = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int a1 = (a & ~array[i]) | (b & array[i]);
                b = (b & ~array[i]) | (~a & ~b & array[i]);
                a = a1;
            }
            return a | b;
        }

        //For an array that has 2 of everything else
        public static int SingularOfTwo(int[] a)
        {
            int value = 0;
            for (int i = 0; i < a.Length; i++)
                value = value ^ a[i];
            return value;
        }
    }

}
