using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.Games
{
    public static class Telephone
    {
        // 425
        static string[] telephoneKeys = {"", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

        public static void TelephoneKeyCombination(string telephoneNumber)
        {
            char[] result = new char[telephoneNumber.Length];

            DoPrintTelephoneWords(telephoneNumber.ToCharArray(), 0, result);
        }

        private static void DoPrintTelephoneWords(char[] telephoneNumber, int currDigit, char[] result)
        {
            if (currDigit == telephoneNumber.Length)
            {
                Console.WriteLine(result);
                return;
            }

            for (int i = 0; i < 3; i++)
            {
                result[currDigit] = GetCharValue(int.Parse(telephoneNumber[currDigit].ToString()), i);

                DoPrintTelephoneWords(telephoneNumber, currDigit + 1, result);

                if (telephoneNumber[currDigit] == '0' || telephoneNumber[currDigit] == '1')
                {
                    return; 
                }
            }
        }
        
        private static char GetCharValue(int number, int position)
        {
            switch (number)
            {
                case 0:
                    return '0';
                case 1:
                    return '1';
                default:
                    return telephoneKeys[number].ToCharArray()[position];
            }
        }
    }
}
