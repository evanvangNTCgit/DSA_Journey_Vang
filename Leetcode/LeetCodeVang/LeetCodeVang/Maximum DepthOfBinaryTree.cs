namespace LeetCodeVang
{
    public static class Maximum_DepthOfBinaryTree
    {
        public static void Main(string[] args)
        {
            TreeNode node4 = new TreeNode(4);
            TreeNode node3 = new TreeNode(3, node4);
            TreeNode node2 = new TreeNode(2, node3);
            TreeNode node1 = new TreeNode(1, node2);

            var test = MaxDepth(node1);
            Console.WriteLine(test);
            Console.ReadLine();
        }

        /*
         * Given the root of a binary tree, return its depth.
         * Depth of a binary tree defined as the number of nodes along its longest path.
         * From root node down to furthest leaf node.
         * 
         * Constraints:
         * 0 <= Numbder of nodes in tree <= 100
         * -100 <= Node.val <= 100
         */


        // THIS IS AN INEFFICIENT SOLUTION.
        public static int MaxDepth(TreeNode root)
        {
            if (root is null) return 0;

            Stack<TreeNode> nodesVisited = new Stack<TreeNode>();
            Dictionary<TreeNode,int> dict = new Dictionary<TreeNode,int>();

            nodesVisited.Push(root);
            dict.Add(root, 0);
            int maxDepth = 0;
            while (nodesVisited.Count > 0)
            {
                var node = nodesVisited.Pop();

                if(node.left is null && node.right is null)
                {
                    maxDepth = maxDepth < dict[node] ? dict[node] : maxDepth;
                }
                if (node.left is not null)
                {
                    nodesVisited.Push(node.left);
                    dict.Add(node.left, dict[node] + 1);
                }
                if(node.right is not null)
                {
                    nodesVisited.Push(node.right);
                    dict.Add(node.right, dict[node] + 1);
                }
            }

            return maxDepth;
        }

        /*
         * What is a DFS? (Depth first search)
         * Explores as far down a branch of a tree or graph as possible before backtracking.
         * Goes deep into one branch before trying another.
         * Great for exploring all possible paths.
         * Uses a stack
         * 
         * What is BFS? (Bredth first search)
         * Explores all nodes at the current level before moving onto the next level.
         * Great for problems when you need to find the shortest path between two nodes.
         * Uses a queue
         * More memory-intensive, especially in wide graphs
         */

        // Class definition of Tree Node.
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
