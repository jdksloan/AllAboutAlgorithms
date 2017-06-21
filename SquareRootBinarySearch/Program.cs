using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRootBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 36;
            Console.WriteLine("SQRT or lowest of {0} = {1}", number, SquareRoot(number));
            Console.ReadLine();
        }

        public static int SquareRoot(int num)
        {
            if (num == 0 | num == 1)
                return num;

            int x = 0;
            int end = num/2;
            int start = 0;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (mid * mid == num)
                {
                    return mid;
                }
                else if((long)mid *mid < num)
                {
                    start = mid + 1;
                    x = mid;
                }else
                {
                    end = mid - 1;
                }
                
            }
            return x; 
        }
    }
}
