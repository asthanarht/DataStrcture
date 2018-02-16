using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.Bit_Manupulation
{
    public class BitProblems
    {
        public static int GetBitCount(int num)
        {
            int i = GetBitCnt(num);
            return i;
        }
        public static int GetBitCnt(int num)
        {
            if (num <= 1 && num >= -1)
                return 1;
            else
                return 1 + GetBitCnt(num / 2);
        }

        public static int GetMaxIntergerValueFromBitCount(int bitCount)
        {
            int value = 0;
                       
            for (int i = 0; i < bitCount; i++)
            {
                value += 1 << i;
            }

            return value;
        }

        public static void PrintBinaryRepresentationOfANumber(int num)
        {
            if (num >= 1 || num <= -1)
            {
                PrintBinaryRepresentationOfANumber(num / 2);
            }
            else
                return;

            Console.Write(num % 2);
        }

        public static void PrintDecimalToBinary()
        {
            string value = "011011";

            int start = value.Length - 1;
            int result = 0;

            for (int i = 0; i < value.Length; i++)
            {
                if(value[start--] == '1')
                    result += 1 << i;
            }

            Console.WriteLine(result);
        }

		public static void ToDecimal(string number,int baseVal)
		{
			int power = 1;
			int res = 0;
			for (int i = number.Length-1; i >= 0; i--)
			{
				if ((number[i] - '0') > baseVal)
					return ; //invalid
				res = res + (number[i] - '0') * power;
				power = power * baseVal;
			}

			Console.WriteLine("Base number is ", res);
		}
    }
}
