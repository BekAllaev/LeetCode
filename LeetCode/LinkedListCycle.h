#pragma once
#include <unordered_set>

using namespace std;

namespace LinkedListCycle {
	struct ListNode {
		int val;
		ListNode* next;
		ListNode(int x) : val(x), next(nullptr) {}
	};
    // HashSet approach
	// put ListNode in to the hashset and do reference by head->next, each time
	// Runs for 15ms(beats 9.18%) and 14.43 mb(beats 9.75%)
	// Time complexity - O(n), Space complexity - O(n)
	// 
	//class Solution {
	//public:
	//	bool hasCycle(ListNode* head) {
	//		std::unordered_set<ListNode*> s;

	//		if (head == nullptr)
	//			return false;

	//		while (head->next) {
	//			if (s.count(head->next))
	//				return true;
	//			else {
	//				s.insert(head->next);
	//				head = head->next;
	//			}
	//		}

	//		return false;
	//	}
	//};

	// Floyd's Cycle Detection
	// Fast pointer do two steps, slow pointer do one step. Sooner or later they will meet
	// Runs for 8ms(beats 83.60%) and 11.83 mb(beats 52.11%)
	// Time complexity - O(n), Space complexity - O(1)
	class Solution {
	public:
		bool hasCycle(ListNode* head) {
			if (head == nullptr || head->next == nullptr)
				return false;

			ListNode* slow = head->next;
			ListNode* fast = head->next->next;

			if (fast == nullptr)
				return false;

			while (fast->next) {

				if (fast->next == nullptr)
					return false;

				slow = slow->next;
				fast = fast->next->next;

				if (slow == fast)
					return true;
			}

			return false;
		}
	};
}
