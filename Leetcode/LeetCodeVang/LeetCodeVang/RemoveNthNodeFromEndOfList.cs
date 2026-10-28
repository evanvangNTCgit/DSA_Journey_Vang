using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeVang
{
    public static class RemoveNthNodeFromEndOfList
    {
        public static void Main(string[] args)
        {
            ListNode ln4 = new ListNode(4);
            //ListNode ln3 = new ListNode(3, ln4);
            //ListNode ln2 = new ListNode(2, ln3);
            //ListNode ln1 = new ListNode(1, ln2);
            var test = RemoveNthFromEnd(ln4, 1);

            while(test != null)
            {
                Console.WriteLine(test.val);
                test = test.next;
            }
        }

        /*
         * Given the head of a linked list and integer n.
         * Remove the Nth node form the end of the list and return its head.
         * 
         * Constraints:
         * sz, number of nodes in list.
         * 1 <= sz <= 30
         * 0 <= Node.val <= 100
         * 1 <= n <= sz
         * 
         * EX's:
         * [1,2,3,4], N = 2
         * [1,2,4] <- So essientially the 2nd element from the left of the end of element was removed
         * 
         * [1,2], N = 2
         * [2]
         * 
         * [5], N = 1
         * []
         */
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            /*
             * A 'fast' node that goes ahead of the slow node
             * Increment a counter integer, will be used to compare to N for if the slower node can move along.
             */
            ListNode fast = head;
            ListNode slow = head;
            int count = 0;

            while(fast != null)
            {
                // Keep going until the end of the list.
                if(fast.next != null)
                {
                    fast = fast.next;
                    count++;
                    if (count > n)
                        slow = slow.next;
                }
                else
                {
                    break;
                }
            }

            // If at the end of the while loop count isone short of N 
            // This means we were to remove the first node.
            // Also this is a safe check since the problem constrains N to <= sz (size of list)
            if(count + 1 == n)
            {
                return head.next;
            }

            // Removal of node from the link.
            // If there is nodes past the desired node to remove connect to one ahead of removed node
            // Otherwise just remove the last node.
            if(slow.next.next != null)
            {
                slow.next = slow.next.next;
            }
            else
            {
                slow.next = null;
            }

            return head;
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
