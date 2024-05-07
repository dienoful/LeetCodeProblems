using LeetCodeProblems.Problems.Easy;
using LeetCodeProblems.Problems.Medium;

namespace LeetCodeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int value = 3;
            int randomValue = new Random().Next(9999);
            string stringNum1 = "123";
            string stringNum2 = "456";

            int result = RemoveDuplicatesFromSortedArray.SolveProblem(array);
            Console.WriteLine(result);
            //Console.WriteLine($"[{string.Join(", ", result)}]");
        }
    }
}
