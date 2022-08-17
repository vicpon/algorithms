// https://leetcode.com/problems/minimum-depth-of-binary-tree/
namespace AlgorithmsPractice.LeetCode
{

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
    public class _111_Minimum_Depth_Binary_Tree
    {
        int mindepth = Int32.MaxValue;
        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            dfs(root, 1);
            return mindepth;
        }

        void dfs(TreeNode node, int depth)
        {
            // Console.WriteLine("Depth {0}", depth);
            if (node == null) return;
            if (node.left == null && node.right == null)
            {
                if (depth < mindepth) mindepth = depth;
                return;
            }

            depth++;
            dfs(node.left, depth);
            dfs(node.right, depth);
        }
    }
}
