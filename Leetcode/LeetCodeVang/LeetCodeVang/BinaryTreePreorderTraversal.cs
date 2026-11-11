namespace LeetCodeVang
{
    public static class BinaryTreePreorderTraversal
    {
        public static void Main(string[] args)
        {

        }

        public static List<int> PreorderTraversal(TreeNode root)
        {
            List<int> response = new List<int>();

            void traverse(TreeNode node)
            {
                if (node is null) return;
                response.Add(node.val);
                if (node.left is not null) traverse(node.left);
                if (node.right is not null) traverse(node.right);
            }
            traverse(root);
            return response;
        }

        // Class definition:
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
