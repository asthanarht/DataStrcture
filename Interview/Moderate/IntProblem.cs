using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.Moderate
{
    public class IntProblem
    {
        public static int factorial(int number)
        {
            if (number > 1)
            {
                return factorial(number - 1) * number;
            }

            return number;
        }

        public static void PrintAllPrimeNumbers(int number)
        {
            Console.WriteLine("###### Print all prime number from 1 to " + number);
            bool isPrime = true;
            for (int i = 1; i <= number; i++)
            {
                isPrime = true;
                //for (int j = i - 1; j > 1; j--)
                for (int j = 2; j<=Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    Console.WriteLine(i);
            }
        }

        public int NthFibonacciNumber(int n)
        {
            if (n <= 2)
                return 1;

            return (NthFibonacciNumber(n - 1) + NthFibonacciNumber(n - 2));
        }


        public static void FibonacciSeries(int num)
        {
            Console.WriteLine("####### Fibonacci Series for " + num);

            int current = 1, previous = 0, next = 1;
            Console.WriteLine(previous);
            Console.WriteLine(current);

            for (int i = 1; i < num - 1; i++)
            {
                next = current + previous;
                previous = current;
                current = next;
                Console.WriteLine(next);
            }
        }

        public static void FibonacciSeriesBetweenRange(int a, int b)
        {
            Console.WriteLine("####### Fibonacci Series between " + a + " and " + b);

            int current = a, previous = a;
            Console.WriteLine(a);

            while (current + previous <= b)
            {
                a = current + previous;
                current = previous;
                previous = a;
                Console.WriteLine(a);
            }
        }

        public static void getMaxValue(int a, int b)
        {
            int c = a - b;
            int k = (c >> 31) & 0x1;
            int max = a - k * c;
            Console.WriteLine("Max of " + a + " and " + b + " = " + max);
        }

        public static void findValueInSortedMatrix(int[,] matrix, int number, int totalRow, int totalColumn)
        {
            int row = 0;
            int col = totalColumn - 1;

            while (row < totalRow && col >= 0)
            {
                if (matrix[row, col] == number)
                {
                    Console.WriteLine("Found number at row: " + (row + 1) + " and col: " + (col + 1) + " and value is: " + matrix[row, col]);
                    break;
                }
                else if (matrix[row, col] > number)
                    col -= 1;
                else
                    row += 1;
            }
        }

        public static void mergeTwoSortedArray(int[] first, int[] second, int m, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;

            while (i >= 0 && j >= 0)
            {
                if (first[i] > second[j])
                    first[k--] = first[i--];
                else
                    first[k--] = second[j--];
            }

            while (j >= 0)
            {
                first[k--] = second[j--];
            }
        }

        public static void getMaxSumInASequence(int[] arr)
        {
            int tempSum = 0;
            int maxSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (tempSum + arr[i] > 0)
                {
                    tempSum += arr[i];

                    if (tempSum > maxSum)
                        maxSum = tempSum;
                }
                else
                    tempSum = 0;

            }

            Console.WriteLine("Max Sum of array: " + maxSum);
        }


		//this is important 
		//must read it
        public static void getMaxSumInASequenceNegetive()
        {
            int[] arr = {-3, 1000, -1001, -4,-2,-3, -600, 3, 4000, 1, 9, 10, -400, 2, 40, -1};
            int tempSum = arr[0];
            int maxSum = arr[0];
			int startIndex =0, endIndex=0;
			int count = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (tempSum + arr[i] > arr[i])
                {
                    tempSum += arr[i];  
					count++;
                }
                else
                {
                    tempSum = Math.Max(arr[i], tempSum);
					count= 0;
                }
				if (tempSum > maxSum) {
					maxSum = tempSum;
					endIndex = i;
					startIndex = endIndex - count;
				}
            }

			Console.WriteLine("Max Sum of array: " + maxSum + "and Start index {0} and End Index{1}",startIndex,endIndex);
        }

        public static void getSequenceOfIncreasingOrderNumber(int[] arr)
        {
			int startIndex;
			int endIndex;

            int tempStartIndex = 0;
            int tempEndIndex = 0;

            int tempSum = arr[0];
            int maxSum = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] < arr[i])
                {
                    tempSum += arr[i];
                    tempEndIndex = i;

                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                        startIndex = tempStartIndex;
                        endIndex = tempEndIndex;
                    }
                }
                else
                {
                    tempStartIndex = tempEndIndex = i;
                    tempSum = arr[i];
                }
            }
        }

        public static void combinationOfSizeR(int[] arr, int[] data, int start, int end, int index, int cSize)
        {
            if (index == cSize)
            {
                for (int i = 0; i < cSize; i++)
                {
                    Console.Write(data[i] + "\t");
                }
                Console.Write("\n");
                return;
            }

            for (int i = start; i < end && end - i >= cSize - index; i++)
            {
                data[index] = arr[i];
                combinationOfSizeR(arr, data, i + 1, end, index + 1, cSize);
            }
        }

        public static void combinationOfSizeR_AnotherApproach(int[] arr, int[] data, int start, int end, int index, int cSize)
        {
            if (index == cSize)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    Console.Write(data[i] + "\t");
                }
                Console.Write("\n");
                return;
            }

            if (start >= end)
                return;

            data[index] = arr[start];
            combinationOfSizeR(arr, data, start + 1, end, index + 1, cSize);

            combinationOfSizeR(arr, data, start + 1, end, index, cSize);
        }

        //public static void sumOfCombination(int[] str, int length, int index, List<int> buffer, int sum)
        //{
        //    if (index == length)
        //    {
        //        return;
        //    }

        //    for (int i = index; i < str.Length; i++)
        //    {
        //        int verifySum = 0;

        //        foreach (int data in buffer)
        //        {
        //            verifySum += data;

        //            if (verifySum > sum)
        //            {
        //                return;
        //            }
        //            else if (verifySum == sum)
        //            {
        //                foreach (int value in buffer)
        //                {
        //                    Console.Write(value + "+");
        //                }
        //                Console.WriteLine("");
        //                return;
        //            }
        //        }

        //        buffer.Add(str[i]);
        //        sumOfCombination(str, length, i + 1, buffer, sum);
        //        buffer.Remove(str[i]);
        //    }
        //}

        public static void subset_Sum(int[]arr, int[]data, int aSize, int dSize, int sum, int index)
        {
            if (index >= aSize)
                return;

            if (0 == sum)
            {
                // Print numbers
                for (int d = 0; d < dSize; d++)
                {
                    Console.Write(data[d] + "+");
                }
                Console.WriteLine("");

                subset_Sum(arr, data, aSize, dSize - 1, sum + arr[index], index + 1);
                return;
            }
            else
            {
                for (int i = index; i < aSize; i++)
                {
                    data[dSize] = arr[i];
                    subset_Sum(arr, data, aSize, dSize + 1, sum - arr[i], i + 1);
                }
            }
        }

        public static void subArraySum(int[] arr, int sum)
        {
            int curr_sum = 0;
            int n = arr.Length;

            if (arr == null || arr.Length == 0 || n <= 0)
                Console.WriteLine("Not a valid issue");

            for (int i = 0; i < n; i++)
            {
                curr_sum = arr[i];

                for (int j = i + 1; j <= n; j++)
                {
                    if (curr_sum == sum)
                    {
                        Console.WriteLine("Sum found between subarray {0} and {1}", i, j - 1);
                        break;
                    }

                    if (curr_sum > sum || j == n)
                        break;

                    curr_sum += arr[j];
                }
            }
        }

        public static void combinationRecursive(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    for (int k = i; k <= j; k++)
                    {
                        Console.Write(arr[k] + "\t");
                    }
                    Console.WriteLine("");
                }
            }
        }

        public static void sumOfTwoEqualK()
        {
            int[] arr = {0,2,3,5,6,8,9,10,13,16};
            int k = 16;

            int start = 0;
            int end = arr.Length-1;
            while (start < end)
            {
                if (arr[start] + arr[end] == k)
                {
                    Console.WriteLine("1st number is {0} and 2nd number is {1}", arr[start], arr[end]);
                    start++;
                    end--;
                }
                else if (arr[start] + arr[end] > k)
                {
                    end--;
                }
                else
                {
                    start++;
                }
            }
        }

        public static void sumOfThreeEqualK()
        {
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 8, 9, 10, 13, 16 };
            int k = 16;
            
            for (int i = 0; i < arr.Length; i++)
            {
                int start = i+1;
                int end = arr.Length - 1;
                while (start < end)
                {
                    if (arr[start] + arr[end] + arr[i] == k)
                    {
                        Console.WriteLine("1st number is {0}, 2nd number is {1}, 3rd number is {2}", arr[start], arr[end], arr[i]);
                        start++;
                        end--;
                    }
                    else if (arr[start] + arr[end] + arr[i] > k)
                    {
                        end--;
                    }
                    else
                    {
                        start++;
                    }
                }
            }
        }

        public static void sumOfTwoEqualKDict()
        {
            int[] arr = { 6, 13, 16, 2, 5, 0, 9, 10, 8, 3 };
            int k = 16;

            int start = 0;
            int end = arr.Length-1;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(k - arr[i]) && dict[k - arr[i]] > 0)
                {
                    dict[k - arr[i]]--;
                    Console.WriteLine("1st number is {0} and 2nd number is {1}", arr[i], k-arr[i]);
                }
                else
                {
                    if (!dict.ContainsKey(arr[i]))
                    {
                        dict[arr[i]] = 0;
                    }
                    dict[arr[i]]++;
                }
            }           
        }
    }
}
