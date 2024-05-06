using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Medium
{
    /*
     * Given two non-negative integers num1 and num2 represented as strings, return the product of num1 and num2, also represented as a string.
     * Note: You must not use any built-in BigInteger library or convert the inputs to integer directly.
     */
    internal class MultiplyStrings
    {
        public static string SolveProblem(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0") return "0";
            if (num1 == "1") return num2;
            if (num2 == "1") return num1;

            int num1Length = num1.Length;
            int num2Length = num2.Length;
            int[] resultArray = new int[num1Length + num2Length];

            for (int i = num1Length - 1; i >= 0; i--)
            {
                int num1Digit = num1[i] - '0';
                for (int j = num2Length - 1; j >= 0; j--)
                {
                    int num2Digit = num2[j] - '0';

                    resultArray[i + j + 1] += num1Digit * num2Digit;
                    resultArray[i + j] += resultArray[i + j + 1] / 10;
                    resultArray[i + j + 1] = resultArray[i + j + 1] % 10;
                }
            }

            StringBuilder stringBuilder = new StringBuilder();
            int finalIter = 0;
            while (resultArray[finalIter] == 0) finalIter++;
            for (; finalIter < resultArray.Length; finalIter++)
            {
                stringBuilder.Append(resultArray[finalIter]);
            }

            return stringBuilder.ToString();
        }
    }
}
