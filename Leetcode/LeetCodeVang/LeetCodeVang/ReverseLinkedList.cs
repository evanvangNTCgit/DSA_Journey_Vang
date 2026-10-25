namespace LeetCodeVang
{
    public static class ReverseLinkedList
    {
        public static void Main(string[] args)
        {
        }

        /*
         * Given the beginning of a singly linked list head,
         * Reverse the list,
         * And return the beginning of the list.
         * 
         * Input: head = [0,1,2,3]
         * Output: [3,2,1,0]
         * 
         * Constraints:
         * 0 <= Length of the list <= 1000
         * -1000 <= Node.val <= 1000
         */
        public static ListNode ReverseList(ListNode head)
        {
            // For what current should point to next in list.
            ListNode prev = null;
            ListNode curr = head;

            while (curr != null) 
            {
                // So we dont lose original value.
                var temp = curr.next;
                curr.next = prev;

                // Now in the next iteration the previous is what node we are at RN
                // And the curr is the next node.
                prev = curr;
                curr = temp;
            }

            // And return the new start of the singly linked-list.
            return prev;
        }

        // Class for problem.
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
