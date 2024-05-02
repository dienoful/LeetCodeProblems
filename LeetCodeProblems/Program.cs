using LeetCodeProblems.Problems.Easy;
using LeetCodeProblems.Problems.Medium;

namespace LeetCodeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val = 2;

            int result = RemoveElement.SolveProblem(nums, val);
            Console.WriteLine(result);
            //Console.WriteLine($"[{string.Join(", ", result)}]");
        }
    }
}
