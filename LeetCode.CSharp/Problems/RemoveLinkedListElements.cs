namespace RemoveLinkedListElements;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        var dummy = new ListNode();
        ListNode curr = dummy;

        while (head is not null)
        {
            if (head.val != val)
            {
                curr.next = head;
                curr = curr.next;
            }
            head = head.next;
        }

        // So basically this line handles the case when the item to remove is at the end.
        // In if statement we move curr every time we head.val != val. In case when head is the last node
        // we won't move the curr and the curr.next will point to the ListNode that should be removed. So this logic works
        curr.next = null!;
        return dummy.next;
    }
}