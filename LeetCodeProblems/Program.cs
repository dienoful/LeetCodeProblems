using LeetCodeProblems.Problems.Easy;
using LeetCodeProblems.Problems.Medium;

namespace LeetCodeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 2, 2, 1 };
            int value = 3;
            int randomValue = new Random().Next(9999);

            int result = BoatsToSavePeople.SolveProblem(array, value);
            Console.WriteLine(result);
            //Console.WriteLine($"[{string.Join(", ", result)}]");
        }
    }
}
