using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeIsBST
{
    class Program
    {
        static void Main(string[] args)
        {
            Node test = new Node() { value = 20, left = new Node() { value = 10 }, right = new Node() { value = 30 } };
            Console.WriteLine("#1 Check for BST {0}", isValid(test));

            Node test2 = new Node() { value = 10, left = new Node() { value = 20 }, right = new Node() { value = 30 } };
            Console.WriteLine("#2 Check for BST {0}", isValid(test2));
            Console.ReadLine();
        }

        public static bool isValid(Node root)
        {
            return isValidBST(root, int.MinValue,
                 int.MaxValue);
        }
        private static bool isValidBST(Node node, int MIN, int MAX)
        {
            if (node == null)
                return true;
            if (node.value > MIN
                && node.value < MAX
                && isValidBST(node.left, MIN, node.value)
                && isValidBST(node.right, node.value, MAX))
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
