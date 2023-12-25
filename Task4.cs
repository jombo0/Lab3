using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Task4
    {
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

        public class Solution
        {
            public void ReorderList(ListNode head)
            {
                if (head == null || head.next == null)
                {
                    return;
                }

                ListNode slow = head;
                ListNode fast = head;

                while (fast.next != null && fast.next.next != null)
                {
                    slow = slow.next;
                    fast = fast.next.next;
                }

                ListNode secondHalf = ReverseList(slow.next);
                slow.next = null;

                MergeLists(head, secondHalf);
            }

            private ListNode ReverseList(ListNode head)
            {
                ListNode prev = null;
                ListNode current = head;
                ListNode next;

                while (current != null)
                {
                    next = current.next;
                    current.next = prev;
                    prev = current;
                    current = next;
                }

                return prev;
            }

            private void MergeLists(ListNode list1, ListNode list2)
            {
                while (list1 != null && list2 != null)
                {
                    ListNode temp1 = list1.next;
                    ListNode temp2 = list2.next;

                    list1.next = list2;
                    list2.next = temp1;

                    list1 = temp1;
                    list2 = temp2;
                }
            }
        }
    }
}
