using System.Runtime.ExceptionServices;
using System.Security.Cryptography;

namespace LeetCodeVang
{
    public static class ReorderLinkedList
    {
        public static void Main(string[] args)
        {
            //ListNode ln10 = new ListNode(10, null);
            //ListNode ln9 = new ListNode(9, ln10);
            //ListNode ln8 = new ListNode(8, ln9);
            //ListNode ln7 = new ListNode(7, ln8);
            //ListNode ln6 = new ListNode(6, ln7);
            //ListNode ln5 = new ListNode(5, ln6);
            //ListNode ln4 = new ListNode(4, ln5);
            //ListNode ln3 = new ListNode(3, ln4);
            ListNode ln2 = new ListNode(2, null);
            ListNode ln1 = new ListNode(1, ln2);
            //ListNode ln0 = new ListNode(0, ln1);

            ReorderList(ln1);
            while(ln1 != null)
            {
                Console.WriteLine(ln1.val);
                ln1 = ln1.next;
            }

            Console.ReadLine();
        }

        /*
         * Given the head of singly linked-list.
         * For example: 
         * [0, 1, 2, 3, 4, 5, 6]
         * Reorder the list to be in the following order:
         * [0, 6, 1, 5, 2, 4, 3]
         * 
         * In general the positions should appear in this order.
         * [0, n-1, 1, n-2, 2, n-3, ...]
         * 
         * Constraints:
         * 1 <= length of list <= 1000
         * 1 <= node.val <= 1000
         */
        public static void ReorderList(ListNode head)
        {
            if (head.next == null)
                return;

            // Brute force
            List<ListNode> list = new List<ListNode>() { head };
            while(head.next != null)
            {
                list.Add(head.next);
                head = head.next;
            }
            head = list[0];

            int left = 1;
            int right = list.Count - 1;
            while(left <= right)
            {
                if (right <= left)
                {
                    head.next = list[right];
                    head.next.next = null;
                    break;
                }

                head.next = list[right];
                head = head.next;
                right--;

                head.next = list[left];
                head = head.next;
                left++;
            }
        }

        // Class definition for problem.
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
    }
}
