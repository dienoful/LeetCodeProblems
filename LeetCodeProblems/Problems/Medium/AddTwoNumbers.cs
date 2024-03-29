using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Medium
{
    // Given class for this problem
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    /*
        You are given two non-empty linked lists representing two non-negative integers.
        The digits are stored in reverse order, and each of their nodes contains a single digit.
        Add the two numbers and return the sum as a linked list.
        You may assume the two numbers do not contain any leading zero, except the number 0 itself.
    */
    internal class AddTwoNumbers
    {
        public static ListNode SolveProblem(ListNode l1, ListNode l2)
        {
            int valSum = l1.val + l2.val;
            int resultVal = valSum % 10;
            int lastExtra = valSum / 10;

            l1 = l1.next;
            l2 = l2.next;
            ListNode headNode = new ListNode()
            {
                val = resultVal,
                next = (l1 != null || l2 != null || lastExtra > 0) ? new ListNode() : null,
            };

            ListNode nextNode = headNode.next;
            ListNode currentNode = headNode;

            while (l1 != null || l2 != null || lastExtra > 0)
            {
                int l1Val = l1 != null ? l1.val : 0;
                int l2Val = l2 != null ? l2.val : 0;
                valSum = l1Val + l2Val + lastExtra;
                resultVal = valSum % 10;
                lastExtra = valSum / 10;

                currentNode = nextNode;
                currentNode.val = resultVal;

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;

                if (l1 != null || l2 != null || lastExtra > 0)
                {
                    nextNode = new ListNode();
                    currentNode.next = nextNode;
                }
            }

            return headNode;
        }
    }
}
