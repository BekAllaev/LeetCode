namespace BinaryTreePostorderTraversal;

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

public class Solution
{
    // This solution runs for 0ms. Time and space complexity is O(n).
    // This solution is iterative and don't use call stack
    public IList<int> PostorderTraversal(TreeNode root)
    {
        var stack = new Stack<TreeNode>();
        var result = new List<int>();
        TreeNode? prev = null;

        if (root is not null)
            stack.Push(root);

        while (stack.Count > 0)
        {
            var node = stack.Peek();

            if ((node.right is null && node.left is null)
                || (prev is not null && (node.left == prev || node.right == prev)))
            {
                result.Add(node.val);
                prev = stack.Pop();

                continue;
            }

            if (node.right is not null)
                stack.Push(node.right);
            if (node.left is not null)
                stack.Push(node.left);
        }

        return result;
    }

    // This is recursive solution which runs for 0ms. Time and space complexity is O(n). Also there is call stack which is O(h), where h - is the height of the tree
    // private void Traverse(TreeNode node, IList<int> result)
    // {
    //     if (node is null)
    //         return;

    //     Traverse(node.left, result);
    //     Traverse(node.right, result);

    //     result.Add(node.val);
    // }

    // public IList<int> PostorderTraversal(TreeNode root) 
    // {
    //     var result = new List<int>();

    //     Traverse(root, result);

    //     return result;
    // }
}