using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxElementInAscThenDescArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 120, 100, 80, 20, 0 };
            Console.WriteLine("Max {0}", MaxFromArray(arr, 0, arr.Length - 1));
            Console.ReadLine();
        }

        public static int MaxFromArray(int[] arr, int low, int high)
        {
            if (low == high)
                return arr[low];

            if ((high == low + 1) && arr[low] >= arr[high])
                return arr[low];

            if ((high == low + 1) && arr[low] < arr[high])
                return arr[high];

            int mid = (low + high) / 2;

            if (arr[mid] > arr[mid + 1] && arr[mid] > arr[mid - 1])
                return arr[mid];

            if (arr[mid] > arr[mid + 1] && arr[mid] < arr[mid - 1])
                return MaxFromArray(arr, low, mid-1);
            else
                return MaxFromArray(arr, mid +1, high);
        }
    }
}
