using LeetCode.DataStuctures;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _083_RemoveDuplicateFromSortedList
    {
        public static ListNode DeleteDuplicates(ListNode head)
        {
            ListNode dummy = head;

            if (dummy == null || dummy.next == null) return head;
            if (dummy.val == dummy.next.val)
            {
                ListNode newNext = dummy.next.next;
                dummy.next = newNext;
                DeleteDuplicates(dummy);
            }
            else
            {
                DeleteDuplicates(dummy.next);
            }

            return head;
        }
    }
}
