namespace SameTree;

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
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        var stack1 = new Stack<TreeNode?>();
        var stack2 = new Stack<TreeNode?>();

        stack1.Push(p);
        stack2.Push(q);

        while (stack1.Count > 0 || stack2.Count > 0)
        {
            var tmp1 = stack1.Count == 0 ? null : stack1.Pop();
            var tmp2 = stack2.Count == 0 ? null : stack2.Pop();

            if (tmp1 is not null)
            {
                stack1.Push(tmp1.right ?? null);
                stack1.Push(tmp1.left ?? null);
            }

            if (tmp2 is not null)
            {
                stack2.Push(tmp2.right ?? null);
                stack2.Push(tmp2.left ?? null);
            }

            if (tmp1 is null && tmp2 is null || tmp1?.val == tmp2?.val)
                continue;
            else
                return false;
        }

        return true;
    }
}