using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.DynamicProgramming
{
    public class DP
    {
        public static void LongestCommonSubString()
        {
            string str1 = "techinterviewzone";
            string str2 = "zoneinterviewxyz";

            int m = str1.Length;
            int n = str2.Length;

            int[,] lcs = new int[m + 1, n + 1];
            int result = 0;
            int endpoint = 0;

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                        lcs[i, j] = 0;
                    else if (str1[i - 1] == str2[j - 1])
                    {
                        lcs[i, j] = lcs[i - 1, j - 1] + 1;
                        //result = Math.Max(lcs[i, j], result);
                        if (lcs[i, j] > result)
                        {
                            result = lcs[i, j];
                            endpoint = i;
                        }                        
                    }
                    else
                        lcs[i, j] = 0;
                }
            }

            Console.WriteLine(result);
            Console.WriteLine(str1.Substring(endpoint - result, result));
        }

        public static void MaximumSubSequenceStringInTwoString()
        {
            int m , n;
            char[] str1 = {'a', 'b', 'c', 'd', 'e'};
            char[] str2 = {'a', 'y', 'b', 'd', 'b', 'd', 'm', 'n', 'e'};
            m = str1.Length;
            n = str2.Length;
            //StringBuilder subs = new StringBuilder();

            int[,] Lcs = new int[m + 1, n + 1];           

            for(int i = 1; i<=str1.Length; i++)
                for (int j = 1; j <= str2.Length; j++)
                {
                    if (i == 0 || j == 0)
                        Lcs[i, j] = 0;
                    else if (str1[i -1] == str2[j - 1])
                    {
                        Lcs[i, j] = Lcs[i - 1, j - 1] + 1;
                        //subs.Append(str1[i-1]);
                    }
                    else
                        Lcs[i, j] = Math.Max(Lcs[i - 1, j], Lcs[i, j - 1]);
                }

            Console.WriteLine(Lcs[m, n]);

            // Below Commented code will not work in case on  char[] str1 = {'a', 'b', 'c', 'd'};  char[] str2 = { 'a', 'y', 'b', 'd' };
            //for (int i = 1; i <= n; i++)
            //{
            //    if (Lcs[m, i - 1] != Lcs[m, i])
            //    {
            //        Console.Write(str1[i-1]);
            //    }
            //}
            //Console.WriteLine(subs);
        }

        public static int FabonicciNumber(int num, Dictionary<int, int> dict)
        {
            if (num <= 2)
                return 1;

            if (dict.ContainsKey(num))
                return dict[num];
            else
            {
                int n = FabonicciNumber(num - 1, dict) + FabonicciNumber(num - 2, dict);

                dict.Add(num, n);

                return n;
            }
        }
    }
}


