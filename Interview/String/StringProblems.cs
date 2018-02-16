using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace Interview.StringProblem
{
	public class StringProblems
	{
		public void permutation(char[] str, int index)
		{
			int i = 0;
			if (index == str.Length)
			{
				// We have a permutation so print it
				Console.WriteLine(str);
				return;
			}

			for (i = index; i < str.Length; i++)
			{
				char temp;
				temp = str[index];
				str[index] = str[i];
				str[i] = temp;
				permutation(str, index + 1);
				temp = str[index];
				str[index] = str[i];
				str[i] = temp;
			}
		}

		public void combination(char[] str, int length, int index, StringBuilder buffer)
		{
			if (index == length)
			{
				return;
			}

			for (int i = index; i < str.Length; i++)
			{
				buffer.Append(str[i]);
				Console.WriteLine(buffer.ToString());
				combination(str, length, i + 1, buffer);
				buffer.Remove(buffer.Length - 1, 1);


			}
		}

		public void patternMatch(char[] dataSequence, char[] pattern)
		{
			List<int> matchPositions = new List<int>();
			int patternPos = 0;
			int patternMatchPos = -1;
			Console.WriteLine("Input string: " + dataSequence.ToString() + " and Pattern: " + pattern.ToString());

			for (int dataPos = 0; dataPos < dataSequence.Length; dataPos++)
			{
				if (dataSequence[dataPos] == pattern[patternPos])
				{
					// start position of match
					if (patternMatchPos == -1)
					{
						patternMatchPos = dataPos;
					}

					patternPos++;

					if (patternPos == pattern.Length)
					{
						matchPositions.Add(patternMatchPos);
						Console.WriteLine("String matches at position: " + (patternMatchPos + 1));
						patternMatchPos = -1;
						patternPos = 0;
					}
				}
				else if (patternMatchPos != -1)
				{
					dataPos = patternMatchPos + 1;
					patternPos = 0;
					patternMatchPos = -1;
				}
			}
		}

		private int shiftedPosition(char[] data, int end)
		{
			int start = 0, shift = 0;

			for (int i = 0; i <= end; i++)
			{
				start = i;
				for (int j = i; j <= end; j++)
				{
					if (data[i] != data[++shift])
					{
						shift = i;
						break;
					}
				}
			}

			return start;
		}

		public void reverseWord(string sentence)
		{
			Console.WriteLine("*********** Reverse sentence ************");

			char[] str = sentence.ToCharArray();

			int len = str.Length;
			char temp;

			// Reverse a string.
			for (int ctr = 0, rev = len - 1; ctr < len / 2; ctr++, rev--)
			{
				temp = str[ctr];
				str[ctr] = str[rev];
				str[rev] = temp;
			}

			// Reverse all the word.
			int start = 0, end = 0;
			for (int ctr = 0; ctr < len; ctr++)
			{
				if (str[ctr] == ' ' || ctr + 1 == len)
				{
					end = ctr + 1 == len ? ctr : ctr - 1;

					while (start < end)
					{
						temp = str[start];
						str[start] = str[end];
						str[end] = temp;
						start += 1;
						end -= 1;
					}

					start = ctr + 1;
				}
			}

			Console.WriteLine(str);
		}

		public void reverseWordReducedTime(string sentance)
		{
			char[] data = sentance.ToCharArray();
			int length = data.Length;
			char temp;

			// Reverse all the characters.
			for (int i = 0, j = length; i < length / 2; i++)
			{
				temp = data[i];
				data[i] = data[--j];
				data[j] = temp;
			}

			int iStart = 0, iEnd = 0, jStart = 0, jEnd = length - 1;

			// Loop to reverse word
			for (int i = 0, j = length - 1; i <= length / 2; i++, j--)
			{
				if (data[i] == ' ')
				{
					iEnd = i - 1;
					while (iStart <= i / 2)
					{
						temp = data[iStart];
						data[iStart] = data[iEnd];
						data[iEnd] = temp;

						iStart++;
						iEnd--;
					}

					iStart = i + 1;
				}

				if (data[j] == ' ')
				{
					jStart = j + 1;
					int jLoop = (jStart + jEnd) / 2;
					while (jStart <= jLoop)
					{
						temp = data[jStart];
						data[jStart] = data[jEnd];
						data[jEnd] = temp;

						jStart++;
						jEnd--;
					}

					jEnd = j - 1;
				}
			}

			Console.WriteLine(data);
		}

		public static void IsUniqueCharacter(char[] str)
		{
			Boolean[] array = new Boolean[255];

			for (int i = 0; i < str.Length; i++)
			{
				int value = str[i];
				if (array[value])
				{
					Console.WriteLine("########## Characters are not unique ");
					return;
				}
				else
				{
					array[value] = true;
				}
			}

			Console.WriteLine("########## Characters are unique ");
		}

		public static void removeDuplicate(char[] str)
		{
			int charPosition = 1;
			bool charUnique = true;

			for (int i = 1; i < str.Length; i++)
			{
				charUnique = true;

				for (int j = i - 1; j >= 0; j--)
				{
					if (str[i] == str[j])
					{
						charUnique = false;
						break;
					}
				}

				if (charUnique)
				{
					str[charPosition] = str[i];
					charPosition += 1;
				}
			}

			for (int i = charPosition; i < str.Length; i++)
			{
				str[i] = '\0';
			}
		}

		public static void CheckPalindrome(char[] str)
		{
			int end = str.Length - 1;

			for (int i = 0; i < (str.Length / 2); i++, end--)
			{
				if (str[i] != str[end])
				{
					Console.WriteLine("### String is not a palindrome");
					return;
				}
			}

			Console.WriteLine("#### String is a palindrome");
		}

		public static void LongestPalindromeInString(string str)
		{
			int leftIndex = 0, rightIndex = 0;
			string maxLengthPalindrome = "", tempPalindrome = "";

			for (int i = 1; i < str.Length - 1; i++)
			{
				leftIndex = i - 1; rightIndex = i + 1;
				while (leftIndex >= 0 && rightIndex < str.Length)
				{
					// this will break loop execution if palindrome found
					if (str[leftIndex] != str[rightIndex])
						break;

					tempPalindrome = str.Substring(leftIndex, rightIndex - leftIndex + 1);
					maxLengthPalindrome = tempPalindrome.Length > maxLengthPalindrome.Length ? tempPalindrome : maxLengthPalindrome;

					leftIndex--;
					rightIndex++;
				}
			}

			Console.WriteLine("Longest palindrome: " + maxLengthPalindrome);
		}

		//Input abcd
		//Output 3 - e.g.dcbabcd
		public static int MinimumInsertionToFormPalindrome(string str, int l, int h)
		{
			if (l > h) return 0;
			if (l == h) return 0;
			if (l == h - 1) return (str[l] == str[h]) ? 0 : 1;

			return str[l] == str[h] ? MinimumInsertionToFormPalindrome(str, l + 1, h - 1) :
				Math.Min(MinimumInsertionToFormPalindrome(str, l, h - 1), MinimumInsertionToFormPalindrome(str, l + 1, h)) + 1;
		}

		public static bool matchStringWithWildCard(char[] first, char[] second, int firstPos, int secondPos, int firstSize, int secondSize)
		{
			if (firstPos == firstSize && secondPos == secondSize)
			{
				return true;
			}

			//// If we reach at the end of both strings, we are done
			//if (first[firstPos] == '\0' && second[secondPos] == '\0')
			//    return true;

			// Make sure that the characters after '*' are present in second string.
			// This function assumes that the first string will not contain two
			// consecutive '*' 
			if (first[firstPos] == '*' && firstPos != firstSize && secondPos == secondSize)
				return false;

			// If the first string contains '?', or current characters of both 
			// strings match
			if (first[firstPos] == '?' || first[firstPos] == second[secondPos])
				return matchStringWithWildCard(first, second, firstPos + 1, secondPos + 1, firstSize, secondSize);

			// If there is *, then there are two possibilities
			// a) We consider current character of second string
			// b) We ignore current character of second string.
			if (first[firstPos] == '*')
				return matchStringWithWildCard(first, second, firstPos + 1, secondPos, firstSize, secondSize) || matchStringWithWildCard(first, second, firstPos, secondPos + 1, firstSize, secondSize);

			return false;
		}

		public static void printParenthesis(int n)
		{
			printParenthesis("", n, n);
		}

		static void printParenthesis(String s, int open, int close)
		{
			if (open > close)
				return;

			if (open == 0 && close == 0)
			{
				Console.WriteLine(s);
				return;
			}

			if (open < 0 || close < 0)
				return;

			printParenthesis(s + '{', open - 1, close);
			printParenthesis(s + '}', open, close - 1);
		}

		public static void countWords(string str)
		{
			bool outState = true;
			int count = 0;

			for (int i = 0; i < str.Length; i++)
			{
				if (str[i] == '\t' || str[i] == ' ' || str[i] == '\n')
					outState = true;
				else if (outState == true)
				{
					count++;
					outState = false;
				}
			}

			Console.WriteLine("No. of words: " + count);
		}

		public static void DeleteBandACfromString(char[] str)
		{
			bool stateSingle = true;
			int j = 0;
			for (int i = 0; i < str.Length; i++)
			{
				if (stateSingle && str[i] != 'a' && str[i] != 'b')
				{
					str[j] = str[i];
					j++;
				}

				if (!stateSingle && str[i] != 'c')
				{
					str[j] = 'a';
					j++;

					if (str[i] != 'a' && str[i] != 'b')
					{
						str[j] = str[i];
						j++;
					}
				}

				stateSingle = str[i] == 'a' ? false : true;
			}

			if (!stateSingle)
			{
				str[j] = 'a';
				j++;
			}

			str[j] = '\0';

			Console.WriteLine(str);
		}


		public static void remoneAandAC()
		{
			StringBuilder newString = new StringBuilder();
			int state = 0;
			int j = 0;
			string str = "abacdeaacuvcwxyzac";
			for (int i = 0; i < str.Length; i++)
			{
				if (str[i] != 'a' && state == 0)
				{
					newString.Append(str[i]);
				}
				else if (str[i] == 'a')
				{
					state = 1;
				}
				else if (state == 1)
				{
					if (str[i] == 'c')
					{
						state = 0;
					}
					else if (str[i] == 'a')
					{
					}
					else
					{
						newString.Append(str[i]);
						state = 0;
					}
				}
			}
			Console.WriteLine(newString);
		}

		public static void compressString()
		{
			string str = "aabbbccdddddefff";
			char[] strC = str.ToCharArray();
			StringBuilder op = new StringBuilder();
			int length = str.Length;
			int count = 1;
			for (int i = 0; i < length - 1; ++i)
			{
				if (strC[i] == strC[i + 1])
				{
					++count;
				}
				else
				{
					op.Append(strC[i].ToString());
					if (count > 1)
						op.Append(count.ToString());
					count = 1;
				}
			}
			op.Append(strC[length - 1].ToString());
			if (count > 1)
				op.Append(count.ToString());
			count = 1;
			Console.WriteLine(op);
		}

		public static void deCompressString()
		{
			string str = "a2b3c4f6";
			char[] strC = str.ToCharArray();
			StringBuilder op = new StringBuilder();
			int length = str.Length;
			int count = 1;
			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < int.Parse(strC[i + 1].ToString()); ++j)
				{
					op.Append(strC[i]);
				}
				i++;
			}
			Console.WriteLine(op);
		}

		public static void findSquareRoot(double number)
		{

			bool isPositiveNumber = true;
			double g1;

			//if the number given is a 0
			if (number == 0)
			{
				Console.Write("Square root of " + number + " = " + 0);
			}

			//If the number given is a -ve number
			else if (number < 0)
			{
				number = -number;
				isPositiveNumber = false;
			}

			//Proceeding to find out square root of the number
			double squareRoot = number / 2;
			do
			{
				g1 = squareRoot;
				squareRoot = (g1 + (number / g1)) / 2;
			}
			while ((g1 - squareRoot) != 0);

			//Displays square root in the case of a positive number
			if (isPositiveNumber)
			{
				Console.Write("Square roots of " + number + " are ");
				Console.Write("+" + squareRoot);
				Console.Write("-" + squareRoot);
			}
			//Displays square root in the case of a -ve number
			else
			{
				Console.Write("Square roots of -" + number + " are ");
				Console.Write("+" + squareRoot + " i");
				Console.Write("-" + squareRoot + " i");
			}

		}

		public static void MaxOccurenceCharacter()
		{
			string str = "abacdfjkkcldiopaasdd";
			int[] countArr = new int[128]; ;

			char[] strChar = str.ToCharArray();

			int maxindex = 0;

			for (int i = 0; i < str.Length; i++)
			{
				countArr[strChar[i]]++;
			}

			for (int i = 1; i < countArr.Length; i++)
			{

				if (countArr[i] > countArr[maxindex])
					maxindex = i;

			}

			Console.Write("max occuring char is", (char)maxindex);
		}

		public static void RemoveDupeStr()
		{
			string inputStr = "abcdddmappowhalksdp";
			char[] str = inputStr.ToCharArray();
			inputStr = string.Empty;
			bool[] check = new bool[256];
			for (int i = 0; i < str.Length; i++)
			{
				if (check[str[i]])
				{
					continue;
				}
				else
				{

					check[str[i]] = true;
					inputStr += str[i];
				}
			}
			Console.Write("new string is = " + inputStr.ToString());
		}

		public static void KthFrequentChar()
		{
			string inputStr = "aabbaccddca";

			int kthChar = 1;
			var charDict = new Dictionary<Char, int>();
			foreach (var c in inputStr)
			{
				if (charDict.ContainsKey(c))
				{
					charDict[c] += 1;
				}
				else
				{
					charDict.Add(c, 1);
				}
			}

			var sortDict = charDict.OrderByDescending(x => x.Value);

			var freqChar = sortDict.ElementAt(kthChar - 1).Key;
			Console.Write("kth frequent char is", freqChar);
		}

		public static void SmallChange()
		{
			int[] chnage = { 20, 9, 6 };
			var inttt = SmallChangeRecurse(24, chnage);
		}

		private static int SmallChangeRecurse(int x, int[] coins)
		{
			if (x == 0) return 0;

			int min = x;
			foreach (var coin in coins)
			{
				if (x - coin >= 0)
				{
					int c = SmallChangeRecurse(x - coin, coins);
					if (min > c + 1) min = c + 1;
				}
			}
			return min;
		}

		public static void SortStack()
		{
			var stack = new Stack<int>();
			stack.Push(5);
			stack.Push(4);
			stack.Push(8);
			stack.Push(3);
			stack.Push(7);

			var newStack = new Stack<int>();
			newStack.Push(stack.Pop());

			while (stack.Count != 0)
			{
				var temp = stack.Pop();
				while (newStack.Count != 0 && temp > newStack.Peek())
				{
					stack.Push(newStack.Pop());
				}
				newStack.Push(temp);
			}

			var n = newStack;
		}


		public static void binayconversion()
		{
			binaryconversion(8);
		}
		private static int binaryconversion(int num)
		{
			int bin;
			if (num != 0)
			{
				bin = (num % 2) + (10 * binaryconversion(num / 2));
				Console.Write(bin);
				return 0;
			}
			else
			{
				return 0;
			}

		}


public static String generateLowestNumber(String number, int n)
{
			
	if (number == null || number.Length < n)
	{
		return null;
	}
	else if (number.Length > n)
	{
		int removed = 0;
		for (int i = 0, j = 1; removed != n && j != number.Length;)
		{
			if (number[i] > number[j])
			{
						number = number.Substring(0, i)
						+ number.Substring(j, number.Length-1);
						Console.Write(number);
				i = 0;
				j = 1;
				removed++;
			}
			else
			{
				i++;
				j++;
			}
		}
	}
	return null;
	}


		public static string multiplyString(String num1, String num2)
{
			var n1 = num1.ToCharArray().Reverse().ToArray();
			var n2 = num2.ToCharArray().Reverse().ToArray();
	
			int[] d = new int[num1.Length + num2.Length];

	//multiply each digit and sum at the corresponding positions
			for (int i = 0; i < n1.Count(); i++)
	        {
				for (int j = 0; j < n2.Count(); j++)
		        {
					d[i + j] = d[i + j]+(n1[i] - '0') * (n2[j] - '0');
		         }
	         }

			var sb = new StringBuilder();

	//calculate each digit
			for (int i = 0; i < d.Count(); i++)
	         {
				int mod = d[i] % 10;
				int carry = d[i] / 10;
						if (i + 1 < d.Count())
				{
					d[i + 1] =d[i + 1] +carry;
				}

				sb.Insert(0,mod);
			}

			//remove front 0's

			return sb.ToString();
}


		public static void MultiplyEasy(string s1, string s2)
		{
			var num1 = s1.ToCharArray();
			var num2 = s2.ToCharArray();

			int a = num1.Length-1;
			int b = num2.Length-1;
			int x;
			int y;
			int res = 0;
			var rsultList = new List<int>();
			for (int i = 0; i <= a; i++)
			{
				x = (int)(num1[a - i]-'0');

				for (int j = 0; j <= b; j++)
				{
					y= (int)(num2[b - j]-'0');

					res += x * y *( (int)Math.Pow(10,(i + j)));
				}
			}

			Console.Write("Product is = ",res);
		}



        public static IEnumerable<int[]> Combinations(int m, int n)
        {
            int[] result = new int[m];
            Stack<int> stack = new Stack<int>();
            stack.Push(0);

            while (stack.Count > 0)
            {
                int index = stack.Count - 1;
                int value = stack.Pop();

                while (value < n)
                {
                    result[index++] = ++value;
                    stack.Push(value);

                    if (index == m)
                    {
                        yield return result;
                        break;
                    }
                }
            }
        }


    }








}
