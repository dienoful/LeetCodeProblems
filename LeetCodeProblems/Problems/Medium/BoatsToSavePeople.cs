using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Medium
{
    /*
     * You are given an array people where people[i] is the weight of the ith person, and an infinite number of boats where each boat can carry a maximum weight of limit.
     * Each boat carries at most two people at the same time, provided the sum of the weight of those people is at most limit.
     * Return the minimum number of boats to carry every given person.
     */
    internal class BoatsToSavePeople
    {
        public static int SolveProblem(int[] people, int limit)
        {
            int result = 0;

            Array.Sort(people);

            for (int i = 0, j = people.Length - 1; i <= j;)
            {
                if (i == j)
                {
                    result++;
                    break;
                }

                int highestWeight = people[j];
                int lowestWeight = people[i];

                if (highestWeight + lowestWeight <= limit)
                {
                    i++;
                    j--;
                }
                else
                {
                    j--;
                }

                result++;
            }

            return result;
        }
    }
}
