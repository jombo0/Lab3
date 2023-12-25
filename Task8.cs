using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Task8
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
            public ListNode ReverseKGroup(ListNode head, int k)
            {
                if (head == null || k <= 1)
                {
                    return head;
                }

                ListNode dummy = new ListNode(0);
                dummy.next = head;

                ListNode prevGroupEnd = dummy;
                ListNode current = head;
                int length = GetLength(head);

                for (int i = 0; i < length / k; i++)
                {
                    ListNode groupStart = prevGroupEnd.next;
                    ListNode groupEnd = current;

                    for (int j = 0; j < k; j++)
                    {
                        ListNode nextNode = current.next;
                        current.next = groupStart;
                        groupStart = current;
                        current = nextNode;
                    }

                    prevGroupEnd.next = groupStart;
                    groupEnd.next = current;
                    prevGroupEnd = groupEnd;
                }

                return dummy.next;
            }

            private int GetLength(ListNode head)
            {
                int length = 0;
                while (head != null)
                {
                    length++;
                    head = head.next;
                }
                return length;
            }
        }
    }
}
