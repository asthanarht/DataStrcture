using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Interview.Games.Backtracking
{
    class Coin_Combination
    {
        public static ArrayList list = new ArrayList();

        public static void GetCoinCombination()
        {
            int[] coinType = {25, 10, 5}; 
            int[] coinNumber = {3, 9, 9, 9}; 

            //MakeChanges(coinType, coinNumber, change);

            Console.WriteLine("Total combination for 1$:");

            PrintChange(coinType, new int[coinType.Length], 0, 100);
        }

        public static void PrintChange(int[] coins, int[] counts, int startIndex, int totalAmount)
        {
            if (startIndex >= coins.Length)
            {
                for (int i = 0; i < coins.Length; i++ )
                {
                    Console.Write("{0} * {1} \t + ", coins[i], counts[i]);
                }

                Console.WriteLine("");

                return;
            }

            if (startIndex == coins.Length - 1)
            {
                if (totalAmount % coins[startIndex] == 0)
                {
                    counts[startIndex] = totalAmount / coins[startIndex];
                    PrintChange(coins, counts, startIndex + 1, 0);
                }
            }
            else
            {
                for (int i = 0; i <= totalAmount / coins[startIndex]; i++)
                {
                    counts[startIndex] = i;
                    PrintChange(coins, counts, startIndex + 1, totalAmount - coins[startIndex] * i);
                }
            }
        }

    }


}
