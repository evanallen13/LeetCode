using LeetCode.DataStuctures;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _24_SwapNodesInPairs
    {
        public static ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null) return head;

            int first = head.val;
            int second = head.next.val;

            head.val = second;
            head.next.val = first;

            SwapPairs(head.next.next);

            return head;
        }

        public static void printNode(ListNode node, ref string str)
        {
            if (node == null) return;
            str += $"{node.val.ToString()},";
            printNode(node.next, ref str);
        }
    }

}
