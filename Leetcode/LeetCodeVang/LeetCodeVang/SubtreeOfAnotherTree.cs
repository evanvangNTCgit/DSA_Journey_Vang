namespace LeetCodeVang
{
    public static class SubtreeOfAnotherTree
    {
        public static void Main(string[] args)
        {
            // Root
            //TreeNode node7 = new TreeNode(7);
            //TreeNode node6 = new TreeNode(6);
            //TreeNode node5 = new TreeNode(5, node6, node7);
            //TreeNode node4 = new TreeNode(4);
            TreeNode node3 = new TreeNode(3);
            TreeNode node2 = new TreeNode(5);
            TreeNode node1 = new TreeNode(4, node2);

            // Sub root.
            TreeNode subnode7 = new TreeNode(7);
            TreeNode subnode6 = new TreeNode(6);
            TreeNode subNode5 = new TreeNode(5);
            TreeNode subNode4 = new TreeNode(4);
            TreeNode subNode2 = new TreeNode(4, null, subNode5);

            var test = IsSubtree(node1, subNode2);
            Console.WriteLine(test);
            Console.ReadLine();
        }

        public static bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            // Empty tree is always a subtree
            if (subRoot is null)
                return true;

            // Queue for DFS
            Queue<TreeNode> nodes = new Queue<TreeNode>();
            nodes.Enqueue(root);

            while (nodes.Count > 0)
            {
                var node = nodes.Dequeue();

                if (node.val == subRoot.val)
                {
                    var test = IsIdenticalNodes(node, subRoot);

                    if (test == true)
                        return true;
                }
                if (node.right is not null)
                    nodes.Enqueue((TreeNode)node.right);
                if (node.left is not null)
                    nodes.Enqueue(node.left);
            }

            return false;
        }

        // Helper method for determining if two tree nodes are identical
        public static bool IsIdenticalNodes(TreeNode brother, TreeNode sister)
        {
            if ((brother.left is null && sister.left is not null) || (brother.left is not null && sister.left is null))
                return false;

            if ((brother.right is null && sister.right is not null) || (brother.right is not null && sister.right is null))
                return false;

            // Populate the queue.
            // We go left, right, left right,
            // Now we already know the top nodes are equal so we can start with left right.
            Queue<TreeNode> brotherNodes = new Queue<TreeNode>();
            if (brother.left is not null)
                brotherNodes.Enqueue(brother.left);
            if (brother.right is not null)
                brotherNodes.Enqueue(brother.right);

            Queue<TreeNode> sisterNodes = new Queue<TreeNode>();
            if (sister.left is not null)
                sisterNodes.Enqueue(sister.left);
            if (sister.right is not null)
                sisterNodes.Enqueue(sister.right);

            while (brotherNodes.Count > 0 || sisterNodes.Count > 0)
            {
                // If the two queue counts do not ever match then it is not a proper sub root...
                if (sisterNodes.Count != brotherNodes.Count)
                    return false;

                // left
                TreeNode broLeftNode = brotherNodes.Dequeue();
                TreeNode sisLeftNode = sisterNodes.Dequeue();

                if (broLeftNode.val != sisLeftNode.val)
                {
                    return false;
                }
                if (broLeftNode.left is not null && sisLeftNode.left is not null)
                {
                    brotherNodes.Enqueue((TreeNode)broLeftNode.left);
                    sisterNodes.Enqueue((TreeNode)sisLeftNode.left);
                }
                if (broLeftNode.right is not null && sisLeftNode.right is not null)
                {
                    brotherNodes.Enqueue(broLeftNode.right);
                    sisterNodes.Enqueue(sisLeftNode.right);
                }
                // has to EXACTLY MATCH so if the sister node does have a value and bro does not then it does not pass...
                // Vice versa...
                if ((broLeftNode.left is null && sisLeftNode.left is not null) || (broLeftNode.left is not null && sisLeftNode.left is null))
                    return false;
                if ((broLeftNode.right is null && sisLeftNode.right is not null) || (broLeftNode.right is not null && sisLeftNode.right is null))
                    return false;

                // right
                // Does not matter if it is truly 'right-side' still dequeing.

                if (brotherNodes.Count > 0 && sisterNodes.Count > 0)
                {
                    TreeNode broRightNode = brotherNodes.Dequeue();
                    TreeNode sisRightNode = sisterNodes.Dequeue();

                    if (broRightNode.val != sisRightNode.val)
                    {
                        return false;
                    }
                    if (broRightNode.left is not null && sisRightNode.left is not null)
                    {
                        brotherNodes.Enqueue((TreeNode)broRightNode.left);
                        sisterNodes.Enqueue((TreeNode)sisRightNode.left);
                    }
                    if (broRightNode.right is not null && sisRightNode.right is not null)
                    {
                        brotherNodes.Enqueue(broRightNode.right);
                        sisterNodes.Enqueue(sisRightNode.right);
                    }
                    if ((broRightNode.left is null && sisRightNode.left is not null) || (broRightNode.left is not null && sisRightNode.left is null))
                        return false;
                    if ((broRightNode.right is null && sisRightNode.right is not null) || (broRightNode.right is not null && sisRightNode.right is null))
                        return false;
                }
            }
            return true;
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
