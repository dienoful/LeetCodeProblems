using LeetCodeProblems.Problems.Easy;
using LeetCodeProblems.Problems.Medium;

namespace LeetCodeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 4, 1 };
            int value = 3;

            var result = BestTimeToBuyAndSellStock.SolveProblem(array);
            Console.WriteLine(result);
            //Console.WriteLine($"[{string.Join(", ", result)}]");
        }
    }
}
