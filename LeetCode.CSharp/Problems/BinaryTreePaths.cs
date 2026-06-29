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
    // This algo runs for O(n^2) time complexity
    private void Dfs(TreeNode node, string path, IList<string> result)
    {
        if (node is null)
            return;

        // Here is the reason why it this algorithm runs for O(n^2) time complexity
        // Here occurs copying. For each itteration we copy previous string and adding to the new value
        // So progresion of number of copying after all itteration is like this - 1, 2, 3, 4, 6, 7, 8..... n
        // This arithmetic progression which's sum gives us n(n+1)/2 = O(n^2)
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
