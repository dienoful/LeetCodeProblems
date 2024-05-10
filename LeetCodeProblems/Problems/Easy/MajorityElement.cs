using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy
{
    internal class MajorityElement
    {
        /*
         * Given an array nums of size n, return the majority element.
         * The majority element is the element that appears more than ⌊n / 2⌋ times.
         * You may assume that the majority element always exists in the array.
         */
        public static int SolveProblem(int[] nums)
        {
            Array.Sort(nums);
            return nums[nums.Length/2];
        }
    }
}
