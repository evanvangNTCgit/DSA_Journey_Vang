namespace LeetCodeVang
{
    public static class LinkedListInBinaryTree
    {
        public static void Main(string[] args)
        {
            TreeNode node4 = new TreeNode(4);
            TreeNode node3 = new TreeNode(3);
            TreeNode node2 = new TreeNode(2, node4);
            TreeNode root = new TreeNode(1, node2);

            ListNode listNode4 = new ListNode(4);
            ListNode listNode = new ListNode(2, listNode4);

            var test = IsSubPath(listNode, root);
        }

        public static bool IsSubPath(ListNode head, TreeNode root)
        {
            // BFS initially
            // Then whenever a node that starts the head is found.
            // DFS this node and see if it matches up to the head.

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                TreeNode node = q.Dequeue();

                if (node.val == head.val)
                {
                    bool containsList = DFS(head, node);
                    if (containsList)
                        return true;
                }

                if (node.left is not null)
                    q.Enqueue(node.left);
                if (node.right is not null)
                    q.Enqueue(node.right);
            }

            return false;
        }

        public static bool DFS(ListNode head, TreeNode node)
        {
            if (head == null) return true;

            if (head.val == node.val)
            {
                head = head.next;
                if (head == null) return true;

                if (node.left is not null)
                {
                    if(DFS(head, node.left))
                    {
                        return true;
                    }
                }
                if (node.right is not null)
                {
                    if (DFS(head, node.right))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public class ListNode
        {
            /// <summary>
            /// The data to hold in node.
            /// </summary>
            public int val { get; set; }

            /// <summary>
            /// The next node to point/reference to.
            /// </summary>
            public ListNode next { get; set; }
            public ListNode(int val, ListNode next = null)
            {
                this.val = val; this.next = next;
            }
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}
