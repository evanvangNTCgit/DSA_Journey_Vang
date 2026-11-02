namespace LeetCodeVang
{
    public static class InvertBinaryTree
    {
        public static void Main(string[] args)
        {

        }

        /*
         * Given the roto of a binary tree.
         * Invert the binary tree and return its root.
         * 
         * Constraints:
         * 0 <= Number of nodes in tree <= 100
         * -100 <= Node.val <= 100
         */
        public static TreeNode InvertTree(TreeNode root)
        {
            //if (root is null) return null;

            //TreeNode temp = root.left;
            //root.left = root.right;
            //root.right = temp;

            //// Keep switching who the nodes reference for every root.left and root.right.
            //InvertTree(root.left);
            //InvertTree(root.right);

            //return root;

            if (root == null) return null;

            Queue<TreeNode> nodes = new Queue<TreeNode>();
            nodes.Enqueue(root);

            while (nodes.Count > 0)
            {
                TreeNode node = nodes.Dequeue();

                var temp = node.left;
                node.left = node.right;
                node.right = temp;

                if (node.left is not null)
                    nodes.Enqueue(node.left);
                if (node.right is not null)
                    nodes.Enqueue((node.right));
            }

            return root;
        }

        // Class definition
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
