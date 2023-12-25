using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Task5
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
            public void DeleteNode(ListNode node)
            {
                if (node == null || node.next == null)
                {
                    return;
                }

                node.val = node.next.val;

                node.next = node.next.next;
            }
        }
    }
}
