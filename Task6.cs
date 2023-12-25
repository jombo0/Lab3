using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Task6
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
            public ListNode DoubleLinkedList(ListNode head)
            {
                if (head == null)
                {
                    return null;
                }

                ListNode dummy = new ListNode(0);
                dummy.next = head;

                ListNode current = head;
                ListNode prev = dummy;

                int carry = 0;

                while (current != null)
                {
                    int sum = current.val * 2 + carry;
                    current.val = sum % 10;
                    carry = sum / 10;

                    prev = current;
                    current = current.next;
                }

                if (carry > 0)
                {
                    prev.next = new ListNode(carry);
                }

                return dummy.next;
            }
        }
    }
}
