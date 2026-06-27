var list1 = new MergeTwoSortedLinkedLists.ListNode(
	1,
	new MergeTwoSortedLinkedLists.ListNode(
		2,
		new MergeTwoSortedLinkedLists.ListNode(4)));

var list2 = new MergeTwoSortedLinkedLists.ListNode(
	1,
	new MergeTwoSortedLinkedLists.ListNode(
		3,
		new MergeTwoSortedLinkedLists.ListNode(4)));

var merged = new MergeTwoSortedLinkedLists.Solution().MergeTwoLists(list1, list2);
var values = new List<int>();

while (merged != null)
{
	values.Add(merged.val);
	merged = merged.next;
}

Console.WriteLine($"Output: [{string.Join(',', values)}]");