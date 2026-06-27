namespace MergeTwoSortedLinkedLists;

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
    // Accepted working solution too that runs for 0ms. Time complexity is O(n+m) and space complexity is O(1)
    // Since we don't do allocation 

    // Logic is very clear and simple. There is no extra allocation of nodes.
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode dummy = new();
        ListNode cur = dummy;

        while (list1 is not null && list2 is not null)
        {
            // This if-else construction add attach one node a time. If there will be equal node we just add the node from list1 
            // and then in the next itteration we will add another one...
            if (list1.val <= list2.val)
            {
                cur.next = list1;
                list1 = list1.next;
            }
            else
            {
                cur.next = list2;
                list2 = list2.next;
            }

            cur = cur.next;
        }

        // This is beatiful idea, this make logic of cycle works - list1 is not null && list2 is not null. Since one of the 
        // pointer will be null, we just attach the other list to the end of the merged list.
        cur.next = list1 ?? list2;

        return dummy.next;
    }

    // Accepted working solution that runs for 0ms. Time complexity is O(n + m) but space complexity is O(n + m) as well
    // because of allocation for each new node. 
    // public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    // {
    //     ListNode dummy = new(), cur = dummy;

    //     while (list1 is not null || list2 is not null)
    //     {
    //         if ((list1 is null && list2 is not null) || 
    //         (list1 is not null && list2 is not null && list1.val > list2.val))
    //         {
    //             cur.next = list2;
    //             list2 = list2.next;
    //         }
    //         else if ((list1 is not null && list2 is null) || 
    //         (list1 is not null && list2 is not null && list1.val < list2.val))
    //         {
    //             cur.next = list1;
    //             list1 = list1.next;
    //         }
    //         else if (list1 is not null && list2 is not null && list1.val == list2.val)
    //         {
    //             cur.next = list1;
    //             cur.next.next = list2;

    //             cur.next.next = list2;

    //             list1 = list1.next;
    //             list2 = list2.next;

    //             cur = cur.next;
    //         }

    //         cur = cur.next;
    //     }

    //     return dummy.next;
    // }
}