using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---task1---");
            task1.ListNode list1 = new task1.ListNode(1, new task1.ListNode(2, new task1.ListNode(4)));
            task1.ListNode list2 = new task1.ListNode(1, new task1.ListNode(3, new task1.ListNode(4)));

            task1.Solution solution1 = new task1.Solution();
            task1.ListNode mergedList = solution1.MergeTwoLists(list1, list2);

            Console.Write("Merged List: ");
            while (mergedList != null)
            {
                Console.Write(mergedList.val + " ");
                mergedList = mergedList.next;
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("---task2---");
            Task2.ListNode head2_1 = new Task2.ListNode(1, new Task2.ListNode(1, new Task2.ListNode(2)));
            Task2.ListNode head2_2 = new Task2.ListNode(1, new Task2.ListNode(1, new Task2.ListNode(2, new Task2.ListNode(3, new Task2.ListNode(3)))));

            Task2.Solution solution2 = new Task2.Solution();

            Task2.ListNode result1 = solution2.DeleteDuplicates(head2_1);
            Task2.ListNode result2 = solution2.DeleteDuplicates(head2_2);

            Console.Write("Result 1: ");
            PrintList(result1);

            Console.Write("\nResult 2: ");
            PrintList(result2);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("---task3---");
            Task3.ListNode head3_1 = new Task3.ListNode(3, new Task3.ListNode(2, new Task3.ListNode(0, new Task3.ListNode(-4))));
            head3_1.next.next.next.next = head3_1.next;

            Task3.ListNode head3_2 = new Task3.ListNode(1, new Task3.ListNode(2));
            head3_2.next.next = head3_2;

            Task3.ListNode head3 = new Task3.ListNode(1);

            Task3.Solution solution = new Task3.Solution();

            bool hasCycle1 = solution.HasCycle(head3_1);
            bool hasCycle2 = solution.HasCycle(head3_2);

            Console.WriteLine("Has Cycle 1: " + hasCycle1);
            Console.WriteLine("Has Cycle 2: " + hasCycle2);
            Console.WriteLine();

            Console.WriteLine("---task4---");
            Task4.ListNode head4_1 = new Task4.ListNode(1, new Task4.ListNode(2, new Task4.ListNode(3, new Task4.ListNode(4))));
            Task4.ListNode head4_2 = new Task4.ListNode(1, new Task4.ListNode(2, new Task4.ListNode(3, new Task4.ListNode(4, new Task4.ListNode(5)))));

            Task4.Solution solution4 = new Task4.Solution();

            solution4.ReorderList(head4_1);
            solution4.ReorderList(head4_2);

            PrintList(head4_1);
            Console.WriteLine();
            PrintList(head4_2);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("---task5---");
            Task5.ListNode head5_1 = new Task5.ListNode(4, new Task5.ListNode(5, new Task5.ListNode(1, new Task5.ListNode(9))));
            Task5.ListNode node5_1 = head5_1.next;

            Task5.ListNode head5_2 = new Task5.ListNode(4, new Task5.ListNode(5, new Task5.ListNode(1, new Task5.ListNode(9))));
            Task5.ListNode node5_2 = head5_2.next.next;

            Task5.Solution solution5 = new Task5.Solution();

            solution5.DeleteNode(node5_1);
            solution5.DeleteNode(node5_2);

            PrintList(head5_1);
            Console.WriteLine();
            PrintList(head5_2);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("---task6---");
            Task6.ListNode head1 = new Task6.ListNode(1, new Task6.ListNode(8, new Task6.ListNode(9)));
            Task6.ListNode head2 = new Task6.ListNode(9, new Task6.ListNode(9, new Task6.ListNode(9)));

            Task6.Solution solution6 = new Task6.Solution();

            Task6.ListNode result6_1 = solution6.DoubleLinkedList(head1);
            Task6.ListNode result6_2 = solution6.DoubleLinkedList(head2);

            PrintList(result6_1);
            Console.WriteLine();
            PrintList(result6_2);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("---task7---");
            Task7.ListNode[] lists = new Task7.ListNode[]
            {
            new Task7.ListNode(1, new Task7.ListNode(4, new Task7.ListNode(5))),
            new Task7.ListNode(1, new Task7.ListNode(3, new Task7.ListNode(4))),
            new Task7.ListNode(2, new Task7.ListNode(6))
            };

            Task7.Solution solution7 = new Task7.Solution();

            Task7.ListNode result = solution7.MergeKLists(lists);

            PrintList(result);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("---task8---");
            Task8.ListNode head8_1 = new Task8.ListNode(1, new Task8.ListNode(2, new Task8.ListNode(3, new Task8.ListNode(4, new Task8.ListNode(5)))));
            int k1 = 2;

            Task8.ListNode head8_2 = new Task8.ListNode(1, new Task8.ListNode(2, new Task8.ListNode(3, new Task8.ListNode(4, new Task8.ListNode(5)))));
            int k2 = 3;

            Task8.Solution solution8 = new Task8.Solution();

            Task8.ListNode result8_1 = solution8.ReverseKGroup(head8_1, k1);
            Task8.ListNode result8_2 = solution8.ReverseKGroup(head8_2, k2);

            PrintList(result8_1);
            Console.WriteLine();
            PrintList(result8_2);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("---task9---");
            Task9.ListNode head9_1 = new Task9.ListNode(1, new Task9.ListNode(4, new Task9.ListNode(3, new Task9.ListNode(2, new Task9.ListNode(5, new Task9.ListNode(2))))));
            int x1 = 3;

            Task9.ListNode head9_2 = new Task9.ListNode(2, new Task9.ListNode(1));
            int x2 = 2;

            Task9.Solution solution9 = new Task9.Solution();

            Task9.ListNode result9_1 = solution9.Partition(head9_1, x1);
            Task9.ListNode result9_2 = solution9.Partition(head9_2, x2);

            PrintList(result9_1);
            Console.WriteLine();
            PrintList(result9_2);

            Console.ReadKey();
        }
        static void PrintList(Task2.ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " ");
                head = head.next;
            }
        }
        static void PrintList(Task4.ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " ");
                head = head.next;
            }
        }
        static void PrintList(Task5.ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " ");
                head = head.next;
            }
        }
        static void PrintList(Task6.ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " ");
                head = head.next;
            }
        } 
        static void PrintList(Task7.ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " ");
                head = head.next;
            }
        }
        static void PrintList(Task8.ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " ");
                head = head.next;
            }
        } static void PrintList(Task9.ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " ");
                head = head.next;
            }
        }
    }
}
