using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfSubsequences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Subsequences {0}", CountSubsequences("abbc"));
            Console.WriteLine("Subsequences {0}", CountSubsequences("abcabc"));
            Console.WriteLine("Subsequences {0}", CountSubsequences("abcabcabc"));
            
            Console.ReadLine();
        }

        public static int CountSubsequences(string s)
        {
            int aCount = 0;

            int bCount = 0;

            int cCount = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                    aCount = (1 + 2 * aCount);
                else if (s[i] == 'b')
                    bCount = (aCount + 2 * bCount);
                else if (s[i] == 'c')
                    cCount = (bCount + 2 * cCount);
            }

            return cCount;
        }
    }
}
