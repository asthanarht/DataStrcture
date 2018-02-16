using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Interview.DataStructure;
using Interview.Classes;
using Interview.ArrayMatrix;
using Interview.String;
using Interview.Moderate;

namespace Interview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void singlelinklist_Click(object sender, EventArgs e)
        {
            SingleLinkList list = new SingleLinkList();
            list.InsertNodeAtBegining(1);
            list.InsertNodeAfter(3, 1);
            list.InsertNodeBefore(2, 3);
            list.InsertNodeAtEnd(4);
            list.InsertNodeAtEnd(5);
            list.InsertNodeAfter(6, 5);
            list.DeleteNode(3);

            list.Traverse();
            list.TraverseBackward();

            //Make list circular
            SingleLinkListNode second = list.Find(2);
            SingleLinkListNode node = list.Find(6);
            node.link = second;

            list.IsListCircular();
        }

        private void doublelinklist_Click(object sender, EventArgs e)
        {
            DoubleLinkList list = new DoubleLinkList();
            list.InsertNodeAtBegining(1);
            list.InsertNodeAfter(3, 1);
            list.InsertNodeBefore(2, 3);
            list.InsertNodeAtEnd(4);
            list.InsertNodeAtEnd(5);
            list.InsertNodeAfter(6, 5);
            list.DeleteNode(3);

            list.Traverse();
            list.TraverseBackward();

            //Make list circular
            DoubleLinkListNode second = list.Find(2);
            DoubleLinkListNode node = list.Find(6);
            node.next = second;

            list.IsListCircular();
        }

        private void binarytree_Click(object sender, EventArgs e)
        {
            BinaryTree tree = new BinaryTree();
            tree.Insert(23);
            tree.Insert(45);
            tree.Insert(16);
            tree.Insert(37);
            tree.Insert(3);
            tree.Insert(99);
            tree.Insert(22);

            Console.WriteLine("Min value");
            tree.FindMin();
            Console.WriteLine("Max value");
            tree.FindMax();
            
            BinaryTreeNode node = tree.Find(2);
            Console.WriteLine("Found Node 22: " + (node != null));

            Console.WriteLine("Delete Node 3.");
            tree.Delete(3);

            tree.InOrder();
            tree.PreOrder();
            tree.PostOrder();

            tree.LowestCommonAncesstor(37, 99);
        }

        private void RotateMatrix_Click(object sender, EventArgs e)
        {
            int[,] array = new int[,] { { 1, 2, 3, 4 , 5, 6}, {7, 8, 9, 10, 11, 12 }, {13, 14, 15, 16, 17, 18 }, { 19, 20, 21, 22, 23, 24 }, {25, 26, 27, 28, 29, 30}, {31, 32, 33, 34, 35, 36} };
            PrintArray(array);

            Matrix matrix = new Matrix();
            matrix.rotateMatrix(array, 6);

            PrintArray(array);
        }

        static void PrintArray(int[,] w)
        {
            // Display the array elements:
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                    Console.Write(w[i, j] + "\t");

                Console.WriteLine("");
            }
        }

        private void StringFunctions_Click(object sender, EventArgs e)
        {
            StringProblems functions = new StringProblems();
            //functions.permutation("abcd".ToCharArray(), 0);

            functions.reverseWord("This is a book");
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            Console.WriteLine("#### Factorial of 4: " +  IntProblem.factorial(4));
        }

        private void PrintPrime_Click(object sender, EventArgs e)
        {
            IntProblem.PrintAllPrimeNumbers(10);
        }
    }
}
