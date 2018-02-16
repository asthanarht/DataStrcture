using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.Games
{
    public class ConvertIntegersToRoman
    {

		public static string ToRoman(int number)
		{
			if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
			if (number < 1) return string.Empty;            
			if (number >= 1000) return "M" + ToRoman(number - 1000);
			if (number >= 900) return "CM" + ToRoman(number - 900); //EDIT: i've typed 400 instead 900
			if (number >= 500) return "D" + ToRoman(number - 500);
			if (number >= 400) return "CD" + ToRoman(number - 400);
			if (number >= 100) return "C" + ToRoman(number - 100);            
			if (number >= 90) return "XC" + ToRoman(number - 90);
			if (number >= 50) return "L" + ToRoman(number - 50);
			if (number >= 40) return "XL" + ToRoman(number - 40);
			if (number >= 10) return "X" + ToRoman(number - 10);
			if (number >= 9) return "IX" + ToRoman(number - 9);
			if (number >= 5) return "V" + ToRoman(number - 5);
			if (number >= 4) return "IV" + ToRoman(number - 4);
			if (number >= 1) return "I" + ToRoman(number - 1);
			throw new ArgumentOutOfRangeException("something bad happened");
		}


        public static void GetRomanValue(int number)
        {
            string roman = string.Empty;
            
            if (number >= 4000 || number <= 0)
                roman = "Invalid";
            else
            {
                roman = GetThousand(number);

                // Remove thousand
                int rNum = number % 1000;

                roman += GetHundred(rNum);
            }

            Console.WriteLine("Roman value for {0} is {1}", number, roman);
        }

        // Get roman value for 1s
        private static string GetOnes(int number)
        {
            string roman = string.Empty;

            return roman;
        }

        // Get roman value for 10s
        private static string GetTens(int number)
        {
            string roman = string.Empty;

            return roman;
        }

        // Get roman value for 50s
        private static string GetFiftys(int number)
        {
            string roman = string.Empty;

            return roman;
        }

        // Get roman value for hundred
        private static string GetHundred(int number)
        {
            string roman = string.Empty;

            if (number >= 100)
            {
                int tCount = number / 100;

                if (tCount == 9)
                {
                    roman = "CM";
                }
                else if (tCount >= 5)
                {
                    roman = "D";
                    for (int i = 0; i < tCount - 5; i++)
                    {
                        roman += "C";
                    }
                }
                else if (tCount == 4)
                {
                    roman += "CD";
                }
                else
                {
                    for (int i = 0; i < tCount; i++)
                    {
                        roman += "C";
                    }
                }
            }

            return roman;
        }

        // Get roman value for thousand
        private static string GetThousand(int number)
        {
            string roman = string.Empty;

            if (number >= 1000)
            {
                int tCount = number / 1000;

                for (int i = 0; i < tCount; i++)
                {
                    roman += "M";
                }
            }

            return roman;
        }
    }
}
