using LeetCodeProblems.Problems.Easy;
using LeetCodeProblems.Problems.Medium;

namespace LeetCodeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode l12 = new ListNode()
            {
                val = 9,
                next = null,
            };
            ListNode l11 = new ListNode()
            {
                val = 9,
                next = l12
            };
            ListNode l10 = new ListNode()
            {
                val = 5,
                next = null,
            };

            ListNode l22 = new ListNode()
            {
                val = 4,
                next = null,
            };
            ListNode l21 = new ListNode()
            {
                val = 9,
                next = null
            };
            ListNode l20 = new ListNode()
            {
                val = 5,
                next = null,
            };

            ListNode result = AddTwoNumbers.SolveProblem(l10, l20);
            Console.WriteLine($"[{string.Join(", ", result.val)}]");
        }
    }
}
