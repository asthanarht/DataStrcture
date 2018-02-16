using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.Classes
{
    class BinaryTreeNode
    {
        public BinaryTreeNode left;
        public BinaryTreeNode right;
        public int data;

        public BinaryTreeNode()
        {
            left = null;
            right = null;
        }

        public BinaryTreeNode(int value)
        {
            left = null;
            right = null;
            data = value;
        }

        public void displayData()
        {
            Console.WriteLine(data);
        }
    }
}
