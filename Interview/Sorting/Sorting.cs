using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.Sorting
{
    class Sorting
    {
        public static void quickSort(int[] arr, int start, int end)
        {
            int i = start, j = end;
            int pivot = (start + end) / 2;
            int temp;
            while (i <= j)
            {
                while (arr[i] < arr[pivot])
                    i++;

                while (arr[j] > arr[pivot])
                    j--;

                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }

            if (start < j)
                quickSort(arr, start, j);

            if (i < end)
                quickSort(arr, i, end);

			//var arr1 = arr;

        }

        public static void mergeSort(int[] nums, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                mergeSort(nums, left, mid);
                mergeSort(nums, mid + 1, right);

                merge(nums, left, mid + 1, right);
            }
        }

        private static void merge(int[] nums, int left, int mid, int right)
        {
            int totalElements = right - left + 1;
            int[] temp = new int[nums.Length];
            int leftEnd = mid - 1;
            int tempPos = left;

            while ((left <= leftEnd) && (mid <= right))
            {
                if (nums[left] <= nums[mid])
                    temp[tempPos++] = nums[left++];
                else
                    temp[tempPos++] = nums[mid++];
            }

            while (left <= leftEnd)
            {
                temp[tempPos++] = nums[left++];
            }

            while (mid <= right)
            {
                temp[tempPos++] = nums[mid++];
            }


            for (int i = 0; i < totalElements; i++)
            {
                // There seems to be a bug. nums and temp should start from start and move till end.
                nums[right] = temp[right];
                right--;
            }
        }

        public static void insertSort(int[] nums)
        {
            int value;

            for (int i = 0; i < nums.Length; i++)
            {
                int j = i; 
                value = nums[i]; 
                while (j > 0 && nums[j - 1] > value)
                {
                    nums[j] = nums[j - 1];
                    j--;
                }

                nums[j] = value;
            }
        }

        public static void print(int[] numbers)
        {
            Console.WriteLine("########### Printing numbers");

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }

		public int[] Numbers;
		public int HeapSize;
		public void CreateHeap()
		{
			for (int i = Numbers.Length / 2; i >= 1; i--)
				Heapify(i);
		}

		public void Heapify(int pos)
		{
			int lc = pos * 2;
			int rc = pos * 2 + 1;
			int largest = pos;
			if (lc <= HeapSize && Numbers[lc - 1] > Numbers[pos - 1])
				largest = lc;
			if (rc <= HeapSize && Numbers[rc - 1] > Numbers[largest - 1])
				largest = rc;
			if (largest != pos)
			{
				int temp = Numbers[largest - 1];
				Numbers[largest - 1] = Numbers[pos - 1];
				Numbers[pos - 1] = temp;
				Heapify(largest);
			}
		}

		public void Sort()
		{
			for (int i = Numbers.Length-1; i >0 ; i--)
			{
				int temp = Numbers[i];
				Numbers[i] = Numbers[0];
				Numbers[0] = temp;
				HeapSize--;
				Heapify(1);
			}
		}
    }
}
