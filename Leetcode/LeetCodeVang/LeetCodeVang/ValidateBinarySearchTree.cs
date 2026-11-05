namespace LeetCodeVang
{
    public static class ValidateBinarySearchTree
    {
        public static void Main(string[] args)
        {
            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(4);
            root.right = new TreeNode(6);

            root.right.left = new TreeNode(3);
            root.right.right = new TreeNode(7);

            var test = IsValidBST(root);
            Console.WriteLine(test);
            Console.ReadLine();
        }

        /*
         * Given root of a BST return true if it is a valid BST,
         * otherwise false.
         * 
         * BST valid if...
         * Left subtree of every node only contains nodes less than nodes key
         * Right subtree of every node contains nodes greater than nodes key
         * Both left and right subtree also BST
         */
        public static bool IsValidBST(TreeNode root)
        {
            if (root is null)
                return true;
            Queue<(TreeNode node, long min, long max)> q = new Queue<(TreeNode, long min, long max)>();
            q.Enqueue((root, long.MinValue, long.MaxValue));
            while (q.Count > 0)
            {
                var node = q.Dequeue();

                // If it is not in range return false...
                if (!(node.min < node.node.val && node.node.val < node.max))
                    return false;

                if (node.node.left is not null)
                {
                    // should be LESS than the previous value...
                    q.Enqueue((node.node.left, node.min, node.node.val));
                }

                if (node.node.right is not null)
                {
                    // Should be MORE than the previous value...
                    q.Enqueue((node.node.right, node.node.val, node.max));
                }
            }

            return true;
        }

        // Class Definition:
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
