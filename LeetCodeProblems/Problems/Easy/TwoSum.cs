using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy
{
    /*
        Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        You may assume that each input would have exactly one solution, and you may not use the same element twice.
        You can return the answer in any order.
    */
    internal class TwoSum
    {
        public static int[] SolveProblem(int[] nums, int target)
        {
            var numHashtable = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                numHashtable[nums[i]] = i;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int firstNum = nums[i];
                int secondNum = target - firstNum;
                if (numHashtable.TryGetValue(secondNum, out int secondNumPos) && secondNumPos != i)
                {
                    return new int[] { i, numHashtable[secondNum] };
                }
            }

            return new int[0];
        }
    }
}
