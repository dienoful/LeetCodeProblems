using LeetCodeProblems.Problems.Easy;
using LeetCodeProblems.Problems.Medium;

namespace LeetCodeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = { 2, 5, 6 };
            int m = 3;
            int n = 3;

            int[] result = MergeSortedArray.SolveProblem(nums1, m, nums2, n);
            Console.WriteLine($"[{string.Join(", ", result)}]");
        }
    }
}
