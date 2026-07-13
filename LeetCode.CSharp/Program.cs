var obj = new RemoveLinkedListElements.Solution();

var head = new RemoveLinkedListElements.ListNode(1,
    new RemoveLinkedListElements.ListNode(2,
        new RemoveLinkedListElements.ListNode(6,
            new RemoveLinkedListElements.ListNode(3,
                new RemoveLinkedListElements.ListNode(4,
                    new RemoveLinkedListElements.ListNode(5,
                        new RemoveLinkedListElements.ListNode(6)))))));

obj.RemoveElements(head, 6);
