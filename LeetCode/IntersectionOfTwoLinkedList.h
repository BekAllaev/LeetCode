#pragma once

namespace IntersectionOfTwoLinkedList {
	struct ListNode {
		int val;
		ListNode* next;
		ListNode(int x) : val(x), next(nullptr) {}
	};

    // This solution's time complexity is O(m+n), space complexity is O(1)
    class Solution {
    public:
        ListNode* getIntersectionNode(ListNode* headA, ListNode* headB) {
            ListNode* currentNodeA = headA;
            ListNode* currentNodeB = headB;

            while (currentNodeA != currentNodeB) {
                currentNodeA = currentNodeA ? currentNodeA->next : headB;
                currentNodeB = currentNodeB ? currentNodeB->next : headA;
            }

            return currentNodeA;
        }
    };

    // This solution's time complexity is O(m+n), space complexity is O(m+n) too
    //class Solution {
    //public:
    //    ListNode* getIntersectionNode(ListNode* headA, ListNode* headB) {
    //        unordered_set<ListNode*> visited;

    //        while (headA || headB) {
    //            if (visited.contains(headA) || headA == headB)
    //                return headA;
    //            else if (visited.contains(headB))
    //                return headB;

    //            if (headA)
    //                visited.insert(headA);
    //            if (headB)
    //                visited.insert(headB);

    //            if (headA)
    //                headA = headA->next;
    //            if (headB)
    //                headB = headB->next;
    //        }

    //        return nullptr;
    //    }
    //};
}