namespace LeetCodeVang
{
    public static class SameBinaryTree
    {
        public static void Main(string[] args)
        {
            TreeNode left = new TreeNode(1);

            TreeNode right2 = new TreeNode(2);
            TreeNode right = new TreeNode(1, null, right2);

            var test = IsSameTree(left, right);

            Console.WriteLine(test);
            Console.ReadLine();
        }

        /**
         * Given the roots of two binary trees P and Q,
         * Return true if the trees are equivalent, otherwise false.
         * 
         * Considered equivalent if they share the exact same structure.
         * Nodes have the same values as well.
         * 
         * Constraints:
         * 0 <= number of nodes in both trees <= 100
         * -100 <= Node.val <= 100
         */
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            // Make a queue for both nodes.
            // Start both queues with a node.
            Queue<TreeNode> leftQueue = new Queue<TreeNode>();
            if (p is not null)
                leftQueue.Enqueue(p);
            Queue<TreeNode> rightQueue = new Queue<TreeNode>();
            if (q is not null)
                rightQueue.Enqueue(q);

            while (leftQueue.Count > 0 || rightQueue.Count > 0)
            {
                // Node one of them is empty, yet the other isnt...
                if (leftQueue.Count <= 0 || rightQueue.Count <= 0) return false;

                var nodeL = leftQueue.Dequeue();
                var nodeR = rightQueue.Dequeue();

                if (nodeL.val != nodeR.val) return false;

                if (nodeL.left is not null && nodeR.left is not null)
                {
                    leftQueue.Enqueue(nodeL.left);
                    rightQueue.Enqueue(nodeR.left);
                }
                else if (nodeL.left is null && nodeR.left is null) 
                {
                    // Do nothing.
                }
                else
                {
                    return false;
                }

                if (nodeL.right is not null && nodeR.right is not null)
                {
                    leftQueue.Enqueue(nodeL.right);
                    rightQueue.Enqueue(nodeR.right);
                }
                else if (nodeL.right is null && nodeR.right is null)
                {
                    // Do nothing.
                }
                else
                {
                    return false;
                }
            }

            return true;
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
