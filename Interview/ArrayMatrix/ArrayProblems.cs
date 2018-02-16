using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Interview.ArrayMatrix
{
    public class ArrayProblems
    {
        //Input  - 10	20	30	40	50	60	70	
        //Output - 70	60	50	40	30	20	10	
        public static void reverseArray()
        {
            int[] arrayObj = { 10, 20, 30, 40, 50, 60, 70 };

            int length = arrayObj.Length - 1;
            int start = 0;
            int temp;

            printArray(arrayObj);

            while(start < length)
            {
                temp = arrayObj[start];
                arrayObj[start] = arrayObj[length];
                arrayObj[length] = temp;
                start++;
                length--;
            }

            printArray(arrayObj);
        }

        // Input - 10	20	30	40	50	60	70	80	
        // Output- 30	20	10	60	50	40	80	70	
        public static void reverseKthElementInArray()
        {
            int kth = 3;
            int[] arrayObj = { 10, 20, 30, 40, 50, 60, 70, 80 };

            int length = arrayObj.Length;
            int start = 0;
            int end = 0;
            int temp;

            printArray(arrayObj);

            int reversalCount = length % kth == 0 ? length / kth : (length / kth) + 1;

            //for (int i = 1; i <= reversalCount; i++)
            //{
            //    end = (kth * i) - 1;
            //    start = kth * (i - 1);

            for (int i = 0; i < reversalCount; i++)
            {
                end = (kth * i) + kth- 1;
                start = kth * i;
                end = end < length ? end : length - 1;

                while (start < end)
                {
                    temp = arrayObj[start];
                    arrayObj[start] = arrayObj[end];
                    arrayObj[end] = temp;
                    start++;
                    end--;
                }
            }

            printArray(arrayObj);
        }

        //10	20	30	40	50	60	70	80	
        //40	50	60	70	80	10	20	30	
        public static void RotateArrayAtKthElement()
        {
            int kth = 3;
            int[] arrayObj = { 10, 20, 30, 40, 50, 60, 70, 80 };
            int length = arrayObj.Length - 1;
            int start = 0;
            int end = kth -1;

            printArray(arrayObj);
            
            //Rotate first half
            while (start < end)
            {
                swap(arrayObj, start, end);
                start++;
                end--;
            }

            start = kth;
            end = length;
            //Rotate second half
            while (start < end)
            {
                swap(arrayObj, start, end);
                start++;
                end--;
            }

            start = 0;
            end = length;
            //Rotate complete
            while (start < end)
            {
                swap(arrayObj, start, end);
                start++;
                end--;
            }

            printArray(arrayObj);
        }

        private static void swap(int[] array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
            left++;
            right--;
        }

        // arr[] = {8, 10, 20, 80, 100, 200, 400, 500, 3, 2, 1}
        public static void findMaximumElementInRotatedArray(int[] arr, int start, int end)
        {
            if (start >= end)
                return;

            int mid = (start + end) / 2;

            if (arr[mid] > arr[start] && arr[mid] > arr[mid + 1])
            {
                Console.WriteLine("Maximum number is : " + arr[mid]);
                return;
            }
            else if (arr[mid] > arr[start])
            {
                findMaximumElementInRotatedArray(arr, mid + 1, end);
            }
            else
            {
                findMaximumElementInRotatedArray(arr, start, mid);
            }
        }

        private static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }

            Console.WriteLine("");
        }

        // I/P : {"425-111-1234", "+1-425-111-1234", "206-111-1234", "001-206-111-1234", "+1-206-111-1234", "206111-1234", "425111-1234", "123-111-1234", "456-111-1234"}
        // O/P : 206
        public static void printMaxAreaCode()
        {
            //string phones = "425-111-1234 425-111-1234 206-111-1234 206-111-1234 206-111-1234 206111-1234 425111-1234 123-111-1234 456-111-1234";
            string[] phones = { "425-111-1234", "425-111-1234", "206-111-1234", "206-111-1234", "206-111-1234", "206111-1234", "425111-1234", "123-111-1234", "456-111-1234" };
            string pattern = @"(\d{3})-(\d{3}-\d{4})";
            Hashtable hash = new Hashtable();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            StringBuilder areaCode = new StringBuilder();
            int max = 0;
            string maxKey = null;
            foreach (string phone in phones)
            {
                if (Regex.IsMatch(phone, pattern))
                {
                    char[] areac = phone.ToCharArray();
                    for (int i = 0; i < 3; i++)
                    {
                        areaCode.Append(areac[i].ToString());
                    }
                    if (dict.ContainsKey(areaCode.ToString()))
                    {
                        dict[areaCode.ToString()]++;
                    }
                    else
                    {
                        dict.Add(areaCode.ToString(), 1);
                    }
                    areaCode = new StringBuilder();
                    
                }             
            }
            foreach (KeyValuePair<string, int> entry in dict)
            {
                if (entry.Value > max)
                {
                    max = entry.Value;
                    maxKey = entry.Key;
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(maxKey.ToString());
        }


	



		public static void GetOddOcuurence(int [] arr)
		{
			int result = 0;
			for (int i = 0; i < arr.Length; i++) {
				result = result ^ arr [i];
			}
			Console.Write ("No is ", result);
		}

		public static void FindFirstMissingNo(int[] arr,int start, int end)
		{
			if (start > end)
			{
				Console.Write("invalid");
				return;
			}
			if (start != arr [start]) {
				Console.WriteLine ("missing no is " + start);
				return;
			}


			int mid = (start + end )/ 2;

			if (arr [mid] > mid)
				FindFirstMissingNo (arr, start, mid);
			else
				FindFirstMissingNo (arr, mid + 1, end);
		}


		public static void PrintRepatedNo(int[] arr )
		{
			for (int i = 0; i < arr.Length; i++) {
				if (arr [Math.Abs (arr [i])] >= 0)
					arr [Math.Abs (arr [i])] = -arr [Math.Abs (arr [i])];
				else
						Console.Write ("repeated no is " + Math.Abs (arr [i]));
			}
		}


		public static void SortRGB()
		{
			string str = "RGBRRBG";
			char[] arr = str.ToCharArray ();

			int strRed = 0; int strBlue = arr.Length-1;

			for (int i = 0; i < arr.Length-1; i++) {
				if (strRed < strBlue) {

					if (arr [i] == 'R') {
						var temp = arr [i];
						arr [i] = arr [strRed];
						arr [strRed] = temp;
						strRed++;
						//SwapArr ( arr [i], arr [strRed++]);

					}
					else if (arr [i] == 'B') {
						var temp = arr [i];
						arr [i] = arr [strBlue];
						arr [strBlue] = temp;
						strBlue--;
						//SwapArr (arr [i], arr [strBlue--]);
						i--;
					}
				}
			}

			Console.Write ("Final String is ", arr.ToString ());
		}

		public static void SortRGBfromDucthFlag()
		{
			string str = "BRGBRRBGB";
			char[] arr = str.ToCharArray ();

			int low = 0; int high = arr.Length-1;
			int mid = 0;

			while (mid <= high) {

				switch (arr [mid]) {

				case 'R':
					{
						var temp = arr [low];
						arr [low] = arr [mid];
						arr [mid] = temp;
						low++;
						mid++;
						break;
					}

				case 'G':
					{
						mid++;
						break;
					}

				case 'B':
					{
						var temp = arr [mid];
						arr [mid] = arr [high];
						arr [high] = temp;
						high--;

						break;
					}

				}
			}



		}

		private static void SwapArr( char arr1, char arr2)
		{
			var temp = arr1;
			arr1 = arr2;
			arr2 = temp;
		}


    }



}
