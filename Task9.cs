﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Task9
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
            public ListNode Partition(ListNode head, int x)
            {
                if (head == null)
                {
                    return null;
                }

                ListNode dummy1 = new ListNode(0);
                ListNode dummy2 = new ListNode(0);
                ListNode current1 = dummy1;
                ListNode current2 = dummy2;

                while (head != null)
                {
                    if (head.val < x)
                    {
                        current1.next = head;
                        current1 = current1.next;
                    }
                    else
                    {
                        current2.next = head;
                        current2 = current2.next;
                    }

                    head = head.next;
                }

                // З'єднуємо дві частини
                current1.next = dummy2.next;
                current2.next = null;

                return dummy1.next;
            }
        }
    }
}
