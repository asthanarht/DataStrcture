using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interview.Classes;
using System.Collections;

namespace Interview.DataStructure
{
    class BinaryTree
    {
        public BinaryTreeNode root;

        public BinaryTree()
        {
            root = null;
        }

        public void Insert1(int value)
        {
            BinaryTreeNode node = new BinaryTreeNode(value);

            if (root == null)
            {
                root = node;
            }
            else
            {
                BinaryTreeNode current = root;
                BinaryTreeNode parent;

                while (true)
                {
                    parent = current;

                    if (value < current.data)
                    {
                        current = current.left;

                        if (current == null)
                        {
                            parent.left = node;
                            break;
                        }
                    }
                    else
                    {
                        current = current.right;

                        if (current == null)
                        {
                            parent.right = node;
                            break;
                        }
                    }
                }
            }
        }

        public void Insert(int value)
        {
            BinaryTreeNode node = new BinaryTreeNode(value);

            if (root == null)
            {
                root = node;
            }
            else
            {
                BinaryTreeNode current = root;

                while (true)
                {
                    if (value < current.data)
                    {
                        if (current.left != null)
                        { 
                            current = current.left; 
                        }
                        else
                        {
                            current.left = node;
                            break;
                        }
                    }
                    else
                    {
                        if (current.right != null)
                        {
                            current = current.right;
                        }
                        else
                        {
                            current.right = node;
                            break;
                        }
                    }
                }
            }
        }

        public void FindMin()
        {
            BinaryTreeNode current = root;

            if (current == null)
            {
                Console.WriteLine("");
                return;
            }

            while (current.left != null)
            {
                current = current.left;
            }

            Console.WriteLine(current.data);
        }

        public void FindMax()
        {
            BinaryTreeNode current = root;

            if (current == null)
            {
                Console.WriteLine("");
                return;
            }
            
            while (current.right != null)
            {
                current = current.right;
            }

            Console.WriteLine(current.data);
        }

        public BinaryTreeNode FindMax(BinaryTreeNode head)
        {
            BinaryTreeNode current = head;

            if (current == null)
            {
                Console.WriteLine("");
                return null;
            }

            while (current.right.right != null)
            {
                current = current.right.right;
            }

            Console.WriteLine(current.data);
            BinaryTreeNode temp = current.right.right;
            current.right = null;
            return temp;
        }

        public BinaryTreeNode Find(int value)
        {
            BinaryTreeNode current = root;

            if (current == null)
                return null;
            else
            {
                while (current.data != value)
                {
                    if (value < current.data)
                    {
                        current = current.left;
                    }
                    else
                    {
                        current = current.right;
                    }

                    if (current == null)
                        return null;
                }

                return current;
            }
        }

        public void Delete(int value)
        {
            BinaryTreeNode current = root;
            BinaryTreeNode parent = root;
            bool isLeftChild = true;

            if (current != null)
            {
                // Find the node
                while (current.data != value)
                {
                    parent = current;

                    if (value < current.data)
                    {
                        current = current.left;
                        isLeftChild = true;
                    }
                    else
                    {
                        current = current.right;
                        isLeftChild = false;
                    }
                }

                if (current.left == null && current.right == null)
                {
                    if (current == root)
                        root = null;
                    else if (isLeftChild)
                        parent.left = null;
                    else
                        parent.right = null;
                }
            }
        }

        public void DeleteNew(int value)
        {
            BinaryTreeNode current = root;
            BinaryTreeNode parent = root;
            bool isLeftChild = true;

            if (current != null)
            {
                // Find the node
                while (current.data != value)
                {
                    parent = current;

                    if (value < current.data)
                    {
                        current = current.left;
                        isLeftChild = true;
                    }
                    else
                    {
                        current = current.right;
                        isLeftChild = false;
                    }
                }

                if (current.left == null && current.right == null)
                {
                    if (current == root)
                        root = null;
                    else if (isLeftChild)
                        parent.left = null;
                    else
                        parent.right = null;
                }
                else
                {
                    BinaryTreeNode temp = FindMax(current.left);

                    parent.left = temp;
                }
            }
        }

        // print ascending order
        public void InOrder()
        {
            Console.WriteLine("######### Traverse Inorder #########");
            InOrder(root);
        }

        public void PrintTreeInDecendingOrder(BinaryTreeNode root)
        {
            if (root != null)
            {
                PrintTreeInDecendingOrder(root.right);
                Console.WriteLine(root.data);
                PrintTreeInDecendingOrder(root.left);
            }
        }

        public void PreOrder()
        {
            Console.WriteLine("######### Traverse PreOrder #########");
            PreOrder(root);
        }

        public void PreOrderWithoutRecursion()
        {
            // 1. Create stack
            // 2. Push root node
            // 3. While Pop node and place it in current
            // 4. Display data from curr node
            // 5. Push curr node.right
            // 6. Push curr node.left
        }

        public void PostOrder()
        {
            Console.WriteLine("######### Traverse PostOrder #########");
            PostOrder(root);
        }

        private void InOrder(BinaryTreeNode node)
        {
            if (node != null)
            {
                InOrder(node.left);
                node.displayData();
                InOrder(node.right);
            }
        }

        private void PreOrder(BinaryTreeNode node)
        {
            if (node != null)
            {
                node.displayData();
                PreOrder(node.left);
                PreOrder(node.right);
            }
        }

        private void PostOrder(BinaryTreeNode node)
        {
            if (node != null)
            {
                PostOrder(node.left);
                PostOrder(node.right);
                node.displayData();
            }
        }

        public void LowestCommonAncesstor(int first, int second)
        {
            BinaryTreeNode current = root;
            if (current != null)
            {
                while (current != null)
                {
                    if (first < current.data && second < current.data)
                    {
                        current = current.left;
                    }
                    else if (first > current.data && second > current.data)
                    {
                        current = current.right;
                    }
                    else
                    {
                        Console.WriteLine("Lowest common ancesstor for " + first + " & " + second + " is: " + current.data);
                        break;
                    }
                }
            }
        }

        public BinaryTreeNode CommonAncestorForUnsortedBinaryTree(BinaryTreeNode node, int p, int q)
        {
            if (node == null)
                return node;

            if (covers(root.left, p) && covers(root.left, q))
                CommonAncestorForUnsortedBinaryTree(root.left, p, q);
            else if (covers(root.right, p) && covers(root.right, q))
                CommonAncestorForUnsortedBinaryTree(root.right, p, q);

            return root;
        }

        private bool covers(BinaryTreeNode node, int p)
        {
            if (node == null)
                return false;
            else if (node.data == p)
                return true;

            return covers(node.left, p) || covers(node.right, p);
        }

        public void IsBalanceTree()
        {
            if (maxDepth(root) - minDepth(root) <= 1)
            {
                Console.WriteLine("############# The tree is balanced tree");
            }
            else
            {
                Console.WriteLine("############# The tree is not balanced tree");
            }
        }

        public int maxDepth(BinaryTreeNode root)
        {
            if (root == null)
                return 0;

            return 1 + Math.Max(maxDepth(root.left), maxDepth(root.right));
        }

        public int minDepth(BinaryTreeNode root)
        {
            if (root == null)
                return 0;

            return 1 + Math.Min(minDepth(root.left), minDepth(root.right));
        }

        public BinaryTreeNode CreateTreeWithSortedArray(int[] array, int start, int end)
        {
            if(start < end)
                return null;

            int mid = (start + end) / 2;

            BinaryTreeNode node = new BinaryTreeNode(array[mid]);
            node.left = CreateTreeWithSortedArray(array, 0, mid - 1);
            node.right = CreateTreeWithSortedArray(array, mid + 1, end);

            return node;    
        }


    }
}
