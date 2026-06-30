namespace SymmetricTree;

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
    public bool IsSymmetric(TreeNode root)
    {
        var stack = new Stack<(TreeNode?, TreeNode?)>();

        stack.Push((root.left, root.right));

        while (stack.Count > 0)
        {
            var (leftTmp, rightTmp) = stack.Pop();

            if (leftTmp is not null && rightTmp is not null)
            {
                stack.Push((leftTmp.right, rightTmp.left));
                stack.Push((leftTmp.left, rightTmp.right));
            }

            if (leftTmp?.val != rightTmp?.val)
                return false;
        }

        return true;
    }
}