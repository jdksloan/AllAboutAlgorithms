using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceAllIntValuesWithAnother
{
    class Program
    {
        static void Main(string[] args)
        {
            int test1 = 102;
            int test2 = 1020;
            Console.WriteLine("Test1 {0}", ReplaceIntValues(test1));
            Console.WriteLine("Test2 {0}", ReplaceIntValues(test2));

            Console.ReadLine();
        }

        public static int ReplaceIntValues(int num)
        {
            if (num == 0)
                return 5;
            else return ReplaceIntValuesRec(num);
        }

        public static int ReplaceIntValuesRec(int num)
        {
            if(num==0)
                return 0;

            int digit = num % 10;
            if (digit == 0)
                digit = 5;

            return ReplaceIntValuesRec(num/10) * 10 + digit;
        }
    }
}
