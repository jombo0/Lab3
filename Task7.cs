using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Task7
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
            public ListNode MergeKLists(ListNode[] lists)
            {
                if (lists == null || lists.Length == 0)
                {
                    return null;
                }

                PriorityQueue<ListNode> minHeap = new PriorityQueue<ListNode>(new ListNodeComparer());

                foreach (ListNode list in lists)
                {
                    if (list != null)
                    {
                        minHeap.Enqueue(list);
                    }
                }

                ListNode dummy = new ListNode();
                ListNode current = dummy;

                while (minHeap.Count > 0)
                {
                    ListNode minNode = minHeap.Dequeue();
                    current.next = minNode;
                    current = current.next;

                    if (minNode.next != null)
                    {
                        minHeap.Enqueue(minNode.next);
                    }
                }

                return dummy.next;
            }

            private class ListNodeComparer : IComparer<ListNode>
            {
                public int Compare(ListNode x, ListNode y)
                {
                    return x.val.CompareTo(y.val);
                }
            }

            private class PriorityQueue<T>
            {
                private List<T> heap;
                private IComparer<T> comparer;

                public int Count { get { return heap.Count; } }

                public PriorityQueue(IComparer<T> comparer)
                {
                    this.heap = new List<T>();
                    this.comparer = comparer;
                }

                public void Enqueue(T item)
                {
                    heap.Add(item);
                    int index = heap.Count - 1;
                    while (index > 0)
                    {
                        int parentIndex = (index - 1) / 2;
                        if (comparer.Compare(heap[index], heap[parentIndex]) >= 0)
                            break;
                        Swap(index, parentIndex);
                        index = parentIndex;
                    }
                }

                public T Dequeue()
                {
                    if (heap.Count == 0)
                        throw new InvalidOperationException("Queue is empty");
                    T result = heap[0];
                    int last = heap.Count - 1;
                    heap[0] = heap[last];
                    heap.RemoveAt(last);

                    int index = 0;
                    while (true)
                    {
                        int leftChild = 2 * index + 1;
                        int rightChild = 2 * index + 2;
                        int smallest = index;

                        if (leftChild < heap.Count && comparer.Compare(heap[leftChild], heap[smallest]) < 0)
                            smallest = leftChild;
                        if (rightChild < heap.Count && comparer.Compare(heap[rightChild], heap[smallest]) < 0)
                            smallest = rightChild;

                        if (smallest == index)
                            break;
                        Swap(index, smallest);
                        index = smallest;
                    }

                    return result;
                }

                private void Swap(int i, int j)
                {
                    T temp = heap[i];
                    heap[i] = heap[j];
                    heap[j] = temp;
                }
            }
        }

    }
}
