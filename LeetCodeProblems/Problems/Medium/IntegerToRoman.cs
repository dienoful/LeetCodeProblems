using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Medium
{
    internal class IntegerToRoman
    {
        /*
         * Given an integer, convert it to a Roman numeral.
         */
        public static string SolveProblem(int num)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>
            {
                [1] = "I",
                [4] = "IV",
                [5] = "V",
                [9] = "IX",
                [10] = "X",
                [40] = "XL",
                [50] = "L",
                [90] = "XC",
                [100] = "C",
                [400] = "CD",
                [500] = "D",
                [900] = "CM",
                [1000] = "M",
            };
            int[] removeOrder = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            string result = "";

            for (int i = 0; i < removeOrder.Length; i++)
            {
                int currentRemove = removeOrder[i];
                while (num >= currentRemove)
                {
                    result += dict[currentRemove];
                    num -= currentRemove;
                }
            }

            return result;
        }
    }
}
