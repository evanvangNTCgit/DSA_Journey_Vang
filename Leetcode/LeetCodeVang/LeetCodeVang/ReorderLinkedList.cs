using System.Security.Cryptography;

namespace LeetCodeVang
{
    public static class ReorderLinkedList
    {
        public static void Main(string[] args)
        {

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

            // Get the end of the linked list.
            ListNode foot = head;
            while (foot.next != null)
            {
                foot = foot.next;
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
