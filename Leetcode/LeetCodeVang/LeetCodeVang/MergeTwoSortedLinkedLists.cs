namespace LeetCodeVang
{
    public static class MergeTwoSortedLinkedLists
    {
        public static void Main(string[] args)
        {
            ListNode list1 = new ListNode(-1, new ListNode(1));
            // ListNode list1 = new ListNode();
            ListNode list2 = new ListNode(-69);
            var test = MergeTwoLists(list1, list2);

            Console.WriteLine(test.val);
            while (test.next != null)
            {
                Console.WriteLine(test.next.val);
                test = test.next;
            }
        }

        /*
         * Given two heads of sorted singly linked lists. List1 & List2.
         * Merge the two lists into one sorted linked list. 
         * And return the head of a new sorted linked list.
         * 
         * Constraints:
         * 0 <= length of each list <= 100
         * -100 <= Node.val <= 100
         */
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            // If any of the lists are null return the other, no comparisons/sorting to be made.
            if (list1 == null)
                return list2;
            if (list2 == null)
                return list1;

            // Get the starting node (lower int value) and other node.
            ListNode starterNode = null;
            ListNode enderNode = null;

            if (list1.val <= list2.val)
            {
                starterNode = list1; enderNode = list2;
            }
            else
            {
                starterNode = list2; enderNode = list1;
            }

            // This will be the node to return.
            ListNode beginningNode = starterNode;

            while (starterNode.next != null && enderNode != null)
            {
                // To make sure we do not lose the original 'links'
                ListNode temp = starterNode.next;
                ListNode temp2 = enderNode.next;
                
                // Simple comparison for if the current other list node 'top node'
                // Is lower than what is next in the determined starter node.
                if (enderNode.val <= starterNode.next.val)
                {
                    starterNode.next = enderNode;
                    starterNode.next.next = temp;

                    // Now continue iteration down the linked lists.
                    enderNode = temp2;
                    starterNode = starterNode.next;
                }
                else
                {
                    starterNode = starterNode.next;
                }
            }

            // And then lastly make sure we do not forget the last node(s).
            if (enderNode != null)
            {
                starterNode.next = enderNode;
            }

            return beginningNode;
        }

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
