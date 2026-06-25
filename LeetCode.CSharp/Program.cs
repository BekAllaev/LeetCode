var sqrt = new Sqrt();

Console.WriteLine($"For 25 - {sqrt.MySqrt(25)}");
Console.WriteLine($"For 100 - {sqrt.MySqrt(100)}");
Console.WriteLine($"For 8 - {sqrt.MySqrt(8)}");
Console.WriteLine($"For 2147395599 - {sqrt.MySqrt(2147395599)}");
Console.WriteLine($"For 808 909 662 - {sqrt.MySqrt(808909662)}");

// Binary Tree Postorder Traversal test case: [1,null,2,3]
var node3 = new BinaryTreePostorderTraversal.TreeNode(3);
var node2 = new BinaryTreePostorderTraversal.TreeNode(2, left: node3, right: null);
var root = new BinaryTreePostorderTraversal.TreeNode(1, left: null, right: node2);

var solution = new BinaryTreePostorderTraversal.Solution();
var result = solution.PostorderTraversal(root);

Console.WriteLine($"Postorder Traversal of [1,null,2,3]: [{string.Join(",", result)}]");
