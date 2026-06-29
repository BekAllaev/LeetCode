var p = new SameTree.TreeNode(
	1,
	new SameTree.TreeNode(2));

var q = new SameTree.TreeNode(
	1,
	null,
	new SameTree.TreeNode(2));

Console.WriteLine(new SameTree.Solution().IsSameTree(p, q));