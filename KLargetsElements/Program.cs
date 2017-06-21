using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLargetsElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 3;
            int[] numbers = { 1, 23, 12, 9, 30, 2, 50 };
            Console.WriteLine("Largest {0} numbers {1}", k, string.Join(",", LargestNumbers(numbers, k)));
            Console.ReadLine();
        }


        public static int[] LargestNumbers(int [] numbers, int k)
        {
            return numbers.OrderByDescending(c => c).Take(k).ToArray();
        }
    }
}
