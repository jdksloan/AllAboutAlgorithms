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
        }

        public bool isValid(Node root)
        {
            return isValidBST(root, Integer.MIN_VALUE,
                 Integer.MAX_VALUE);
        }
        private boolean isValidBST(Node node, int MIN, int MAX)
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
}
