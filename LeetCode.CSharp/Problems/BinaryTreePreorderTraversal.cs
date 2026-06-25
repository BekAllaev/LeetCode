namespace BinaryTreePreorderTraversal;

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
    // This is iterrative solution that runs for 0ms. 
    // Time complexity is O(n) but here we don't have call stack, we work itteratively
    public IList<int> PreorderTraversal(TreeNode root)
    {
        var stack = new Stack<TreeNode>();
        var result = new List<int>();

        if (root is not null)
            stack.Push(root);

        while (stack.Count > 0)
        {
            var node = stack.Pop();

            result.Add(node.val);

            if (node.right is not null)
                stack.Push(node.right);

            if (node.left is not null)
                stack.Push(node.left);
        }

        return result;
    }
    /*
    // This is recursive solution that runs for 0ms. Time complexity is O(n), space complexity is O(n). In recursice solution we work we call stack which depth is O(h), where h - is the height of the stack. For worst case tree may look like linked list so in this case h = n
    private void Traverse(TreeNode node, IList<int> result)
    {
        if (node is null)
            return;

        result.Add(node.val);
        Traverse(node.left, result);
        Traverse(node.right, result);   
    }

    public IList<int> PreorderTraversal(TreeNode root) 
    {
        IList<int> result = new List<int>();

        Traverse(root, result);

        return result;
    }
    */
}
