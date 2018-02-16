using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Interview.ArrayMatrix;
namespace Interview
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			//Application.EnableVisualStyles();
			//Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new Form1());
			string[] words = {"a","ab","abc","acd","dap","d" };
            //var t = new AutoComplete(words).GetPrefix("a");

            //StringProblem.StringProblems.MultiplyEasy("123","456");

            //ArrayProblems.FindFirstMissingNo(new int[] { 0,1, 2, 3, 5, 7, 10 }, 0, 9);

            //var t = StringProblem.StringProblems.Combinations(3, 5);
            //Bit_Manupulation.BitProblems.ToDecimal("1011011", 2);
            foreach (int[] c in StringProblem.StringProblems.Combinations(2, 2))
            {
                Console.WriteLine(string.Join(",", c));
                Console.WriteLine();
            }
        }
    }
}
