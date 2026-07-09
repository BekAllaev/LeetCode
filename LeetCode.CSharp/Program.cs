var root = new CountCompleteTreeNodes.TreeNode(1,
    new CountCompleteTreeNodes.TreeNode(2,
        new CountCompleteTreeNodes.TreeNode(4),
        new CountCompleteTreeNodes.TreeNode(5)),
    new CountCompleteTreeNodes.TreeNode(3,
        new CountCompleteTreeNodes.TreeNode(6)));

var obj = new CountCompleteTreeNodes.Solution();
var result = obj.CountNodes(root);

Console.WriteLine(result); // Expected: 6
