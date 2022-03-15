using LeetCode.DataStuctures;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _203_RemoveLinkedListElement
    {
        public static ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null) return null;
            if (head.val == val) return RemoveElements(head.next, val);

            head.next = RemoveElements(head.next, val);
            return head;
        }

        private static void remove(ref ListNode head, int val)
        {
            if (head == null) return;
            ListNode current = head;
            ListNode next = head.next;
            ListNode nextNext = head.next.next;

            if (next.val == val)
            {
                current.next = nextNext;
            }
            else
            {
                remove(ref head.next, val);
            }
        }
    }
}
