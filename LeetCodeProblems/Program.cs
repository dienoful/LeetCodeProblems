using LeetCodeProblems.Problems.Easy;

namespace LeetCodeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 2, 4 };
            int target = 6;

            int[] result = TwoSum.SolveProblem(nums, target);
            Console.WriteLine($"[{string.Join(", ", result)}]");
        }
    }
}
