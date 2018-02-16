using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.ArrayMatrix
{
    class Matrix
    {
        public static void findSubMatrixWithLargestPossibleSum(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            int maxSum = 0;
            int temp = 0;
            int rowStart = 0, rowEnd = 0, colStart = 0, colEnd = 0;

            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    for (int m = i; m < row; m++)
                        for (int n = j; n < col; n++)
                        {
                            temp = 0;

                            for (int p = i; p <= m; p++)
                                for (int q = j; q <= n; q++)
                                {
                                    temp += matrix[p, q];
                                }

                            if (temp > maxSum)
                            {
                                maxSum = temp;
                                rowStart = i;
                                rowEnd = m;
                                colStart = j;
                                colEnd = n;
                            }
                        }

            Console.WriteLine("Largest value is: " + maxSum);
            while (rowStart <= rowEnd)
            {
                int colTemp = colStart;
                while (colTemp <= colEnd)
                {
                    Console.Write("\t\t" + matrix[rowStart, colTemp++]);
                }

                rowStart += 1;
                Console.WriteLine("");
            }
        }

        public static void findSubMatrixWithBorderHavingOneValue(int[,] matrix, int row, int col)
        {
            int first = 0;
            int second = 0;
            int[][] subMatrix = new int[5][];
            bool valid = true;
            int count = 0;

            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    for (int m = i; m < row; m++)
                        for (int n = j; n < col; n++)
                        {
                            valid = true;

                            first = i;
                            second = m;

                            for (int q = j; q <= n; q++)
                            {
                                if (!(matrix[first, q] == 1 && matrix[second, q] == 1))
                                {
                                    valid = false;
                                    break;
                                }
                            }

                            first = j;
                            second = n;

                            for (int q = i; q <= m; q++)
                            {
                                if (!(matrix[q, first] == 1 && matrix[n, second] == 1))
                                {
                                    valid = false;
                                    break;
                                }
                            }

                            if (valid && i!=m && j!=n)
                            {
                                subMatrix[count++] = new int[4] { i, m, j, n };
                            }
                        }

            Console.WriteLine("Sub Matrix with row and col 1: " + subMatrix.Length);

            foreach (int[] value in subMatrix)
            {
                if (value == null)
                    break;

                int colTemp = value[2];
                int rowTemp = value[0];
                while (rowTemp <= value[1])
                {
                    colTemp = value[2];
                    while (colTemp <= value[3])
                    {
                        Console.Write("\t\t" + matrix[rowTemp, colTemp++]);
                    }

                    rowTemp += 1;
                    Console.WriteLine("");
                }
            }
        }

       //Given a matrix represented as int[n][n], 
       //rotate it 90 degrees clockwise in-place. 
       //(In-place means minimal extra memory to be used, 
       //i.e. don't make a new array to copy into). 
       //Rotate clockwise means top-row becomes right-column, 
       //right column becomes bottom-row etc.

       public void rotateMatrix(int[,] matrix, int length)
        {
            for (int layer = 0; layer < length / 2; layer++)
            {
                int end = length - layer - 1;
                int buffer = 0;

                for (int i = layer; i < end; i++)
                {
                    int temp = matrix[layer, i];
                    matrix[layer, i] = matrix[end - buffer, layer];
                    matrix[end - buffer, layer] = matrix[end, end - buffer];
                    matrix[end, end - buffer] = matrix[layer + buffer, end];
                    matrix[layer + buffer, end] = temp;

                    buffer++;
                }
                
                //for (int i = layer; i < end; i++)
                //{
                //    int temp = matrix[layer, i];
                //    matrix[layer, i] = matrix[end - layer, layer];
                //    matrix[end - layer, layer] = matrix[end, end - layer];
                //    matrix[end, end - layer] = matrix[layer + layer, end];
                //    matrix[layer + layer, end] = temp;
                   
                //}
            }
        }

//        Input:
//        1    2   3   4
//        5    6   7   8
//        9   10  11  12
//        13  14  15  16
//        17  18  19  20 
//Output: 
//1 2 3 4 8 12 16 15 14 13 9 5 6 7 11 10 
       public static void printMatrixInSpiralForm(int[,] matrix)
       {
           int row = matrix.GetLength(0);
           int col = matrix.GetLength(1);

           for (int i = 0; i < row/2; i++)
           {
               int rend = row - i - 1;
               int cend = col - i - 1;

               // Top left to right
               for (int j = i; j <= cend; j++)
               {
                   Console.Write(matrix[i, j] + "\t");
               }

               // Right top to bottom
               for (int j = i + 1; j <= rend; j++)
               {
                   Console.Write(matrix[j, cend] + "\t");
               }

               // Bottom right to left
               for (int j = cend - i - 1; j >= i; j--)
               {
                   Console.Write(matrix[rend - i, j] + "\t");
               }

               // Left bottom to top
				for (int j = rend; j > i; j--)
               {
                   Console.Write(matrix[j, i] + "\t");
               }
           }
       }

       private static List<String> words = null;
       public static void findCombinationFromMatrix(char[,] matrix)
       {
           words = new List<string>();

           for (int rowPos = 0; rowPos < 4; rowPos++)
               for (int colPos = 0; colPos < 4; colPos++)
               {
                   combinationFromMatrix(matrix, rowPos, colPos, string.Empty);
               }
       }

       private static void combinationFromMatrix(char[,] board, int rowPos, int colPos, string current)
       {
           // Try to drill into to neighboring tiles (if it's worth the hassle)
            char originalValue = board[rowPos, colPos];
            string newChain = current + originalValue;

            if (newChain.Length >= 3)
            {
                words.Add(newChain);
            }

            for (int vert = -1; vert <= 1; vert++)
                for (int horiz = -1; horiz <= 1; horiz++)
                {
                    if (rowPos + vert >= 0 && rowPos + vert < 4 &&
                        colPos + horiz >= 0 && colPos + horiz < 4 &&
                        !(vert == 0 && horiz == 0) &&
                        board[rowPos + vert, colPos + horiz] != '~')
                    {
                        board[rowPos, colPos] = '~';
                        combinationFromMatrix(board, rowPos + vert, colPos + horiz, newChain);
                        board[rowPos, colPos] = originalValue;
                    }
                }
       }

       public static bool SudokuCheck()
       {
           int[,] board = {
                               {0,0,0,0,0,0,0,0,0},
                               {0,0,0,0,0,0,0,0,0},
                               {0,0,0,0,0,0,0,0,0},
                               {0,0,0,0,0,0,0,0,0},
                               {0,0,0,0,0,0,0,0,0},
                               {0,0,0,0,0,0,0,0,0},
                               {0,0,0,0,0,0,0,0,0},
                               {0,0,0,0,0,0,0,0,0},
                               {0,0,0,0,0,0,0,0,0}
                           };
           bool[] check = new bool[9];

           for (int i = 1; i <= 3; i++)
           {
               for (int j = 0; j < 3; j++)
               {
                   for (int k = 0; k < 3; k++)
                   {
                       int num = board[j * i, k];

                       if(num > 9)
                           return false;

                       check[num] = true;
                   }

                   if (!checkAllTrue(check))
                       return false;
               }

               for (int j = 0; j < 3; j++)
               {
                   for (int k = 0; k < 3; k++)
                   {
                       int num = board[k, i * j];

                       if (num > 9)
                           return false;

                       check[num] = true;
                   }

                   if (!checkAllTrue(check))
                       return false;
               }
           }

           return true;
       }

       private static bool checkAllTrue(bool[] check)
       {
           bool valid = true;
           for(int i = 0; i < 9; i++)
           {
               if (!check[i])
                   valid = false;

               check[i] = false;
           }

           return valid;
       }

		private static void MaxSubArray(int[] arr)
		{
			int maxsofar = arr [0];


		}

		/// <summary>
		/// white an algorithm such that if an element in an MXN matrix is 0, its entire row and column are set to 0
		/// </summary>
		/// <param name="input"></param>
		public static int[,] ChechStatus(int[,] input)
		{ 
			bool[] rows = new bool[input.GetLength(0)];
			bool[] columns = new bool[input.GetLength(1)];
			for (int i = 0; i < input.GetLength(0); i++)
				for (int j = 0; j < input.GetLength(1); j++)
					if (input[i, j] == 0)
					{
						rows[i] = true;
						columns[j] = true;
					}
			for (int i = 0; i < input.GetLength(0); i++)
				for (int j = 0; j < input.GetLength(1); j++)
					if (rows[i] || columns[j])
						input[i, j] = 0;
			return input;
		}

    }
}
