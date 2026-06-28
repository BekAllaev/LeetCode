namespace BinaryTreePaths;

public class TreeNode 
{
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) 
      {
          this.val = val;
          this.left = left;
          this.right = right;
      }
 }
 
public class Solution 
{
    private void Dfs(TreeNode node, string path, IList<string> result)
    {
        if (node is null)
            return;

        path = string.IsNullOrWhiteSpace(path) ? $"{node.val}" : $"{path}->{node.val}";

        if (node.left is null && node.right is null)
            result.Add(path);

        Dfs(node.left, path, result);
        Dfs(node.right, path, result);
    }

    public IList<string> BinaryTreePaths(TreeNode root) 
    {
        var result = new List<string>();

        Dfs(root, string.Empty, result);

        return result;
    }
}
