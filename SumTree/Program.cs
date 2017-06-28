using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node test = new Node()
            {
                value = 26,
                left = new Node()
                {
                    value = 10, left = new Node() { value = 4 }, right = new Node() { value = 6 }
                },
                right = new Node()
                {
                    value = 3, left = new Node() { value = 1 }, right = new Node() { value=2 }
                }
            };

            Console.WriteLine("Check is SumTree {0}", IsSumTree(test));
            Console.ReadLine();
        }


        public static int sum(Node root)
        {
            if (root == null)
                return 0;
            return sum(root.left) + root.value + sum(root.right);
        }

        public static bool IsSumTree(Node node)
        {
            if (node == null || (node.left == null & node.right == null))
                return true;
            int ls = sum(node.left);
            int rs = sum(node.right);

            if (node.value == ls + rs && IsSumTree(node.left) && IsSumTree(node.right))
                return true;
            else
                return false;
        }
    }

    public class Node
    {
        public int value { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }
    }
}
