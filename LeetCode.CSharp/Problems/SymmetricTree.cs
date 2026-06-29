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
        var leftStack = new Stack<TreeNode>();
        var rightStack = new Stack<TreeNode>();

        leftStack.Push(root.left);
        rightStack.Push(root.right);

        while (leftStack.Count > 0 || rightStack.Count > 0)
        {
            var leftTmp = leftStack.Pop();
            var rightTmp = rightStack.Pop();

            if (leftTmp is not null)
            {
                leftStack.Push(leftTmp.right ?? null);
                leftStack.Push(leftTmp.left ?? null);
            }

            if (rightTmp is not null)
            {
                rightStack.Push(rightTmp.left ?? null);
                rightStack.Push(rightTmp.right ?? null);
            }

            if (leftTmp is null && rightTmp is null || leftTmp?.val == rightTmp?.val)
                continue;
            else
                return false;
        }

        return true;
    }
}