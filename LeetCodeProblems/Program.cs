using LeetCodeProblems.Problems.Easy;
using LeetCodeProblems.Problems.Medium;

namespace LeetCodeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = new Random().Next(9999);

            string result = IntegerToRoman.SolveProblem(num);
            Console.WriteLine($"{num} => {result}");
            //Console.WriteLine($"[{string.Join(", ", result)}]");
        }
    }
}
