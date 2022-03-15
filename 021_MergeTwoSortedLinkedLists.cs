using LeetCode.DataStuctures;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _021_MergeTwoSortedLinkedLists
    {
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {

            ListNode result = new ListNode();

            if (l1 == null && l2 == null)
                return result.next;

            if (l1 == null)
                return l2;

            if (l1 == null)
                return l1;

            if (l1.val > l2.val)
            {
                result.val = l2.val;
                l2 = l2.next;
            }
            else
            {
                result.val = l1.val;
                l1 = l1.next;
            }

            orderListNodes(l1, l2, ref result);

            return result;
        }

        public static void orderListNodes(ListNode l1, ListNode l2, ref ListNode result)
        {
            if (l1 == null && l2 == null)
            {
                return;
            }

            if (l1 == null)
            {
                result.next = new ListNode(l2.val);
                l2 = l2.next;
            }
            else if (l2 == null)
            {
                result.next = new ListNode(l1.val);
                l1 = l1.next;
            }

            else if (l1.val <= l2.val)
            {
                result.next = new ListNode(l1.val);
                l1 = l1.next;
            }
            else if (l1.val > l2.val)
            {
                result.next = new ListNode(l2.val);
                l2 = l2.next;
            }

            orderListNodes(l1, l2, ref result.next);
        }

        public static void printListNode(ListNode node)
        {
            if (node == null) return;
            Console.WriteLine(node.val);
            printListNode(node.next);
        }

    }
}
