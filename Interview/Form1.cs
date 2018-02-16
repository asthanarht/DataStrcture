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
using Interview.StringProblem;
using Interview.Moderate;
using Interview.Games;
using Interview.Games.Backtracking;

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
            list.InsertNodeAtBegining(2);
            list.InsertNodeAtBegining(3);
            list.InsertNodeAtBegining(4);
            list.InsertNodeAtBegining(5);

			SingleLinkList list1 = new SingleLinkList();
			list1.InsertNodeAtBegining(1);
			list1.InsertNodeAtBegining(0);
			list1.InsertNodeAtBegining(2);
			list1.InsertNodeAtBegining(1);
			list1.InsertNodeAtBegining(0);
			list1.InsertNodeAtBegining(2);
			list1.InsertNodeAtBegining(1);
			list1.InsertNodeAtBegining(0);
            /*list.InsertNodeBefore(2, 3);

            //list.DeleteNode(3);
            */
           // list.CombinationOfNodes(list.header, new StringBuilder());
           // list.CombinationOfNodesForAGivenSum(list.header, 5, new List<Node>());

			list.DeleteNodeOne (list.Find(1));
			var head = list.PairwiseRecurseSwap (list.header);


			var listss = list.ReverseAlternateKNode (list1.header, 3);
			list.UnionList (list.header, list1.header);
            //list.Traverse();
            //list.TraverseBackward();
            //list.ReverseLinkList(list.header);
			list1.Sort012List (list1.header);

            //Make list circular
           
            //node.link = second;

            //list.IsListCircular();
			list.AddOperationList (list.header, list1.header);


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
            tree.Insert(101);
            tree.Insert(140);
            tree.Insert(22);
            tree.InOrder();
            Console.WriteLine("Min value");
            tree.FindMin();
            Console.WriteLine("Max value");
            tree.FindMax();
            
            BinaryTreeNode node = tree.Find(2);
            Console.WriteLine("Found Node 22: " + (node != null));

            Console.WriteLine("Delete Node 3.");
            tree.Delete(3);

            tree.InOrder();
            tree.PrintTreeInDecendingOrder(tree.root);
            tree.PreOrder();
            tree.PostOrder();

            tree.LowestCommonAncesstor(37, 99);

            tree.IsBalanceTree();
        }

        private void RotateMatrix_Click(object sender, EventArgs e)
        {
            int[,] array = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 }};
            PrintArray(array);

            Matrix matrix = new Matrix();
            matrix.rotateMatrix(array, 4);

            PrintArray(array);



        }

        
        private void SpiralMatrix_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 }, { 17, 18, 19, 20 } };
            Matrix.printMatrixInSpiralForm(matrix);
        }

        static void PrintArray(int[,] w)
        {
            // Display the array elements:
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write(w[i, j] + "\t");

                Console.WriteLine("");
            }
        }

        private void StringFunctions_Click(object sender, EventArgs e)
        {
            StringProblems functions = new StringProblems();


            functions.permutation("abcd".ToCharArray(), 0);
            char[] arr = new char[4];
            functions.combination("abc".ToCharArray(), 3, 0, new StringBuilder());

            functions.reverseWord("This is a book.");

            StringProblem.StringProblems.DeleteBandACfromString("bcabcacabca".ToCharArray());
            StringProblem.StringProblems.countWords("this is a book.");
            StringProblem.StringProblems.compressString();
            StringProblem.StringProblems.deCompressString();
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            Console.WriteLine("#### Factorial of 4: " +  IntProblem.factorial(4));
        }

        private void PrintPrime_Click(object sender, EventArgs e)
        {
            IntProblem.PrintAllPrimeNumbers(20);
        }

        private void MaxOfTwo_Click(object sender, EventArgs e)
        {
            IntProblem.getMaxValue(10, 5);
        }

        private void IsUniqueCharacter_Click(object sender, EventArgs e)
        {
			//StringProblem.StringProblems.MaxOccurenceCharacter ();
			StringProblem.StringProblems.RemoveDupeStr ();
            StringProblem.StringProblems.IsUniqueCharacter("abcede".ToCharArray());
        }

        private void TelephoneGame_Click(object sender, EventArgs e)
        {
            Telephone.TelephoneKeyCombination("425");
          //  char[] result = new char[4];
           // Telephone.DoPrintTelephoneWords("42".ToCharArray(), 0, result);
        }

        private void TicTacToe_Click(object sender, EventArgs e)
        {
            tictactoe game = new tictactoe();
            game.checkGameWinner(game.getBoard());
        }

        private void FindNumberInSortedMatrix_Click(object sender, EventArgs e)
        {
            int[,] array = new int[,] { { 1, 8, 12, 19 }, { 22, 25, 29, 31 }, { 33, 36, 39, 42 }, { 44, 56, 73, 82 } };
            IntProblem.findValueInSortedMatrix(array, 73, 4, 4);
			//ArrayProblems.TraverseMatrix (array, 1, 1, 3, 1);
        }

        private void MergeTwoSortedArray_Click(object sender, EventArgs e)
        {
            int[] array1 = new int[16];
            array1[0] = 1;
            array1[1] = 9;
            array1[2] = 8;
            array1[3] = 12;
            array1[4] = 19;
            array1[5] = 22;
            array1[6] = 25;
            array1[7] = 29;
            array1[8] = 31;
            array1[9] = 73;
            array1[10] = 82;

            int[] array2 = new int[] { 3, 33, 36, 39, 42, 44};

            IntProblem.mergeTwoSortedArray(array1, array2, 11, 5);
        }

        private void Shuffle_Click(object sender, EventArgs e)
        {
            AudioShuffle.GenerateShuffleNumbersWithTempArray(10);
        }

        private void findSubMatrixWithLargestPossibleSum_Click(object sender, EventArgs e)
        {
            int[,] array = new int[,] { { 1, -2, -5, 4 }, { 3, 6, 2, 7 }, { -9, 1, 6, 3 }, { 4, -6, 3, 1 } };

            Matrix.findSubMatrixWithLargestPossibleSum(array);
        }

        private void findSubMatrixWithBorderHavingOneValue_Click(object sender, EventArgs e)
        {
            int[,] array = new int[,] { { 1, 1, 0, 0 }, { 1, 1, 1, 1 }, { 0, 1, 0, 1 }, { 0, 1, 1, 1 } };
            
            Matrix.findSubMatrixWithBorderHavingOneValue(array, 4, 4);
        }

        private void QuickSort_Click(object sender, EventArgs e)
        {
            int[] array = {10,5,7,3,9,7,2,34,44,0,22};
            Sorting.Sorting.quickSort(array, 0, 10);
            Sorting.Sorting.print(array);

        }

        private void InsertionSort_Click(object sender, EventArgs e)
        {
            int[] array = { 10, 5, 7, 3, 9, 7, 2, 34, 44, 0, 22 };
            Sorting.Sorting.insertSort(array);
            Sorting.Sorting.print(array);
        }

        private void MergeSort_Click(object sender, EventArgs e)
        {
            int[] array = { 10, 5, 7, 3, 9, 7, 2, 34, 44, 0, 22 };
            Sorting.Sorting.mergeSort(array, 0, 10);
            Sorting.Sorting.print(array);
        }

        private void Stack_Click(object sender, EventArgs e)
        {
            Interview.DataStructure.Stack<int> stack = new Interview.DataStructure.Stack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            GenericNode<int> node = stack.Pop();
        }

        private void Queue_Click(object sender, EventArgs e)
        {
            Interview.DataStructure.Queue<int> queue = new Interview.DataStructure.Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(40);
            queue.Enqueue(30);

            GenericNode<int> node = queue.Dequeue();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] array = { 10, 12, 17, -10, 9, 11, 2, 14, 22, 11, 22 };
            IntProblem.getSequenceOfIncreasingOrderNumber(array);
        }

        private void RemoveDuplicate_Click(object sender, EventArgs e)
        {
            StringProblems.removeDuplicate("abcdefgabhil".ToCharArray());
        }

        private void Fibonacci_Click(object sender, EventArgs e)
        {
            IntProblem.FibonacciSeries(10);
        }

        private void FibonacciBetweenRange_Click(object sender, EventArgs e)
        {
            IntProblem.FibonacciSeriesBetweenRange(3, 55);
        }

        private void Palindrome_Click(object sender, EventArgs e)
        {
            StringProblem.StringProblems.CheckPalindrome("abba".ToCharArray());
            StringProblem.StringProblems.CheckPalindrome("ababa".ToCharArray());
            StringProblem.StringProblems.CheckPalindrome("abda".ToCharArray());
        }

        private void LongestPalindrome_Click(object sender, EventArgs e)
        {
			StringProblems.LongestPalindromeInString("mahaahbhaadke");
        }

        private void DesignPatterns_Click(object sender, EventArgs e)
        {
            (new DesignPatterns()).Show();
        }

        private void FindMazeRoute_Click(object sender, EventArgs e)
        {
            new Maze_Route().solveMazeRoute();
        }

        private void nthFibonacci_Click(object sender, EventArgs e)
        {
            Console.WriteLine(new IntProblem().NthFibonacciNumber(10));
        }

        private void PatternMatch_Click(object sender, EventArgs e)
        {
            StringProblems functions = new StringProblems();
            functions.patternMatch("abbcabbasabacbbabbac".ToCharArray(), "abba".ToCharArray());
        }

        private void WordsFromMatrix_Click(object sender, EventArgs e)
        {
            char[,] array = new char[,] { { 'a', 'c', 'x', 'd' }, { 'g', 'b', 't', 'r' }, { 'e', 'w', 'o', 'p' }, { 'k', 'j', 'g', 'm' } };
            Matrix.findCombinationFromMatrix(array);
        }

        private void CoinProblem_Click(object sender, EventArgs e)
        {
            Coin_Combination.GetCoinCombination();
        }

        private void MatchWildCard_Click(object sender, EventArgs e)
        {
            string first = "ge*";
            string second = "geek";

            bool match = StringProblem.StringProblems.matchStringWithWildCard(first.ToCharArray(), second.ToCharArray(), 0, 0, first.Length, second.Length);
        }

        private void PrintParenthesis_Click(object sender, EventArgs e)
        {
            StringProblem.StringProblems.printParenthesis(2);
        }

        private void MaxSubSequence_Click(object sender, EventArgs e)
        {
            DynamicProgramming.DP.MaximumSubSequenceStringInTwoString();
        }

        private void DPFabonacci_Click(object sender, EventArgs e)
        {
            Console.WriteLine(DynamicProgramming.DP.FabonicciNumber(6, new Dictionary<int,int>()));
        }

        private void SudokuSolver_Click(object sender, EventArgs e)
        {
            Interview.Games.Backtracking.Sudoku.Solve();
        }


        private void CombinationOfSum_Click(object sender, EventArgs e)
        {
            int[] values = { 5, 4, 3, 2, -1, -2};// {3, 4,6,7,2,10,21,29,8, 5, 1};
            IntProblem.subset_Sum(values, new int[6], 6, 0, 5, 0);
        }

        private void CombinationOfSizeR_Click(object sender, EventArgs e)
        {
            int[] values = { 1, 2, 3 };
            IntProblem.combinationOfSizeR(values, new int[3], 0, 3, 0, 2);
            Console.WriteLine("Another approach-----------");
            IntProblem.combinationOfSizeR_AnotherApproach(values, new int[3], 0, 3, 0, 2);
        }

        private void ConvertToRoman_Click(object sender, EventArgs e)
        {
            ConvertIntegersToRoman.GetRomanValue(4000);
            ConvertIntegersToRoman.GetRomanValue(4400);
            ConvertIntegersToRoman.GetRomanValue(2900);
            ConvertIntegersToRoman.GetRomanValue(900);
            ConvertIntegersToRoman.GetRomanValue(1900);
            ConvertIntegersToRoman.GetRomanValue(1500);
            ConvertIntegersToRoman.GetRomanValue(1700);
            ConvertIntegersToRoman.GetRomanValue(1400);
            ConvertIntegersToRoman.GetRomanValue(400); 
            ConvertIntegersToRoman.GetRomanValue(300);
        }

        private void ReverseArray_Click(object sender, EventArgs e)
        {
            ArrayProblems.reverseArray();
			int[] arr = { 0,1, 2, 3, 6, 7, 8, 10 };
				//ArrayProblems.FindMinMissingNoInConsuctiveArray(arr);
			int[] arr2 = { 1, 2, 3, 2, 3, 1, 3 };
			ArrayProblems.GetOddOcuurence (arr2);

			int [] arr3 = { 0, 1, 2, 6, 9 };
			ArrayProblems.FindFirstMissingNo (arr3, 0, arr.Length - 1);

			ArrayProblems.PrintRepatedNo (arr2);
			ArrayProblems.SortRGBfromDucthFlag ();
			ArrayProblems.SortRGB ();
        }

        private void ReverseKthElement_Click(object sender, EventArgs e)
        {
            ArrayProblems.reverseKthElementInArray();
        }

        private void RotateArrayAtKth_Click(object sender, EventArgs e)
        {
            ArrayProblems.RotateArrayAtKthElement();
        }

        private void subarray_sum_Click(object sender, EventArgs e)
        {
            int[] arr = {1,2,3};
            IntProblem.combinationRecursive(arr);
            IntProblem.subArraySum(arr, 33);

        }

        private void FindMaxElementInRotatedArray_Click(object sender, EventArgs e)
        {
            int[] arr = {8, 10, 20, 80, 100, 200, 400, 500, 3, 2, 1};
            ArrayProblems.findMaximumElementInRotatedArray(arr, 0, 11);

            int[] arr1 = {1, 3, 50, 10, 9, 7, 6};
            ArrayProblems.findMaximumElementInRotatedArray(arr1, 0, 7);

            int[] arr2 = { 10, 20, 30, 40, 50 };
            ArrayProblems.findMaximumElementInRotatedArray(arr2, 0, 5);

            int[] arr3 = { 120, 100, 80, 20, 0 };
            ArrayProblems.findMaximumElementInRotatedArray(arr3, 0, 5);
        }

        private void BitCount_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Bit_Manupulation.BitProblems.GetBitCount(-2147483647));
        }

        private void BitCountToMaxInt_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Bit_Manupulation.BitProblems.GetMaxIntergerValueFromBitCount(3));
        }

        private void PrintBinaryRepresentationOfANumber_Click(object sender, EventArgs e)
        {
            Bit_Manupulation.BitProblems.PrintBinaryRepresentationOfANumber(10);
        }

        private void MinLenToFormPalindrome_Click(object sender, EventArgs e)
        {
            Console.WriteLine(StringProblems.MinimumInsertionToFormPalindrome("abcd", 0, 3));
        }

        private void MaxSubstring_Click(object sender, EventArgs e)
        {
            DynamicProgramming.DP.LongestCommonSubString();
        }

        private void PrintDecimalToBinary_Click(object sender, EventArgs e)
        {
            Bit_Manupulation.BitProblems.PrintDecimalToBinary();
        }

        private void MaxPhoneAreaCode_Click(object sender, EventArgs e)
        {
            ArrayProblems.printMaxAreaCode();
        }

        private void replaceString_Click(object sender, EventArgs e)
        {
            StringProblems.remoneAandAC();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IntProblem.getMaxSumInASequenceNegetive();
        }

        private void ClassDemo_Click(object sender, EventArgs e)
        {
           
            
        }

        private void intProblem_Click(object sender, EventArgs e)
        {
            IntProblem.sumOfTwoEqualK();
            IntProblem.sumOfTwoEqualKDict();
            IntProblem.sumOfThreeEqualK();
        }


    }
}
