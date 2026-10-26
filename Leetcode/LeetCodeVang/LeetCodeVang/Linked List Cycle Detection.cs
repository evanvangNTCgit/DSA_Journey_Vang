using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeVang
{
    public static class Linked_List_Cycle_Detection
    {
        public static void Main(string[] args)
        {

        }

        /*
         * Given the beginning of a linked list (head),
         * return true if there is a cycle in the linked list.
         * Otherwise false.
         * 
         * If there is a cycle in a linked list 
         * meaning one node can be visited AGAIN by following the next pointer.
         * 
         * Internally, 'index' determines the index of the beginning of the cycle,
         * If it exists. The tail node of the list will set its next pointer
         * to the index-th node.
         * If index = -1, thent he tail node points to null and no cycle exists.
         */
        public static bool HasCycle(ListNode head) 
        {
            //HashSet<ListNode> visited = new HashSet<ListNode>(); 

            //while(head != null)
            //{
            //    if (visited.Contains(head))
            //        return true;

            //    visited.Add(head);
            //    head = head.next;
            //}

            /*
             * The 'tortoise & hare approach'
             * One pointer can move faster than the other.
             * If they meet then that means there is a cyle.
             */
            ListNode McQueen = head;
            ListNode Mater = head;

            while(McQueen != null && McQueen.next != null)
            {
                Mater = Mater.next;
                McQueen = McQueen.next.next;

                if (McQueen == Mater)
                    return true;
            }

            return false;
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
