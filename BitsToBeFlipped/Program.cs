using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsToBeFlipped
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateBits(7, 10));
            Console.ReadLine();
        }

        public static int CalculateBits(int a, int b)
        {
            int c = a ^ b;
            int count = 0;
            while (c != 0)
            {
                c &= (c - 1);
                count++;
            }
            return count;
        }

    }
}
