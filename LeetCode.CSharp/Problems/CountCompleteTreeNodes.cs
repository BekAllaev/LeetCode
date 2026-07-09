namespace CountCompleteTreeNodes;

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
    private bool IsIdeal(TreeNode root, out int height)
    {
        TreeNode? left = root.left, right = root.right;
        height = 1;

        while (left is not null && right is not null)
        {
            left = left.left;
            right = right.right;
            height++;
        }

        return left is null && right is null;
    }

    // Accepted solution that runs for 0ms and has O((log(n))^2) time complexity
    // O((log(n))^2) is because we check at least log(n) nodes at each level and we have log(n) levels
    // so log(n) * log(n) = (log(n))^2
    public int CountNodes(TreeNode root)
    {
        int result = 0;
        var stack = new Stack<TreeNode?>();
        stack.Push(root);

        while (stack.Count > 0)
        {
            var node = stack.Pop();

            if (node is null)
                continue;

            var isIdeal = IsIdeal(node, out int height);

            if (isIdeal)
                result += (1 << height) - 1;
            else
            {
                result++;

                stack.Push(node.right);
                stack.Push(node.left);
            }
        }

        return result;
    }

    // Accepted solution that runs for 1ms and has O(n) time complexity
    // public int CountNodes(TreeNode root) 
    // {
    //     var stack = new Stack<TreeNode?>();
    //     int result = 0;

    //     stack.Push(root);

    //     while(stack.Count > 0)
    //     {
    //         var node = stack.Pop();

    //         if (node is not null)
    //         {
    //             result++;
    //             stack.Push(node.right);
    //             stack.Push(node.left);
    //         }
    //     }

    //     return result;
    // }
}