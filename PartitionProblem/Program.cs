using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartitionProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] item = { 1, 2, 3, 5, 7, 8, 9 };
            Console.WriteLine("Test {0}", SplitArray(item));
            Console.ReadLine();
        }

        public static bool SplitArray(int[] item)
        {
            int sum = 0;
            foreach (int n in item)
            {
                sum += n;
            }

            int left = item[0];
            int right = 0;

            for (int i = 0; i < item.Length; i++)
            {
                right = sum - left - item[i];
                if (right == left)
                    return true;
                left += item[i];
            }
            return false;
        }
    }
}
