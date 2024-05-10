using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Medium
{
    /* 
     * Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.
     */
    internal class RotateArray
    {
        public static void SolveProblem(int[] nums, int k)
        {
            k = k % nums.Length;
            Array.Reverse(nums);
            Array.Reverse(nums, 0, k);
            Array.Reverse(nums, k, nums.Length - k);
        }
    }
}
