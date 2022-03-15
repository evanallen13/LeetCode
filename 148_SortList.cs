using LeetCode.DataStuctures;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _148_SortList
    {
        public static ListNode SortList(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode curr = head;
            ListNode next = head.next;
            ListNode nextNext = next.next;

            if (curr.val > next.val)
            {
                head = next;
                head.next = curr;
                head.next.next = nextNext;
            }

            SortList(head.next);

            return head;
        }
    }
}
