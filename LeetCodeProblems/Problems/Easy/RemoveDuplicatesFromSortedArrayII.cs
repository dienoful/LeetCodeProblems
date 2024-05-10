using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy
{
    internal class RemoveDuplicatesFromSortedArrayII
    {
        public static int SolveProblem(int[] nums)
        {
            int posPointer = 0;
            int repeatTimes = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i + 1 >= nums.Length || nums[i + 1] > nums[i] || (nums[i + 1] == nums[i] && repeatTimes < 1))
                {
                    nums[posPointer] = nums[i];
                    posPointer++;

                    if (i + 1 < nums.Length && nums[i + 1] > nums[i])
                    {
                        repeatTimes = 0;
                    }
                    else
                    {
                        repeatTimes++;
                    }
                }
            }

            return posPointer;
        }
    }
}
