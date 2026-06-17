#pragma once
#include <iostream>
#include "IntersectionOfTwoLinkedList.h"

using namespace std;

class IntersectionOfTwoLinkedListTests {
public:
	static void runAllTests() {
		testExample1();
		testExample2();
	}

private:
	static void testExample1() {
		cout << "\n=== Test: Example 1 ===" << endl;

		// Build shared tail: 8 -> 4 -> 5
		IntersectionOfTwoLinkedList::ListNode* intersection = new IntersectionOfTwoLinkedList::ListNode(8);
		intersection->next = new IntersectionOfTwoLinkedList::ListNode(4);
		intersection->next->next = new IntersectionOfTwoLinkedList::ListNode(5);

		// Build list A: 4 -> 1 -> (intersection)
		IntersectionOfTwoLinkedList::ListNode* headA = new IntersectionOfTwoLinkedList::ListNode(4);
		headA->next = new IntersectionOfTwoLinkedList::ListNode(1);
		headA->next->next = intersection;

		// Build list B: 5 -> 6 -> 1 -> (intersection)
		IntersectionOfTwoLinkedList::ListNode* headB = new IntersectionOfTwoLinkedList::ListNode(5);
		headB->next = new IntersectionOfTwoLinkedList::ListNode(6);
		headB->next->next = new IntersectionOfTwoLinkedList::ListNode(1);
		headB->next->next->next = intersection;

		cout << "listA = [4,1,8,4,5], listB = [5,6,1,8,4,5], skipA = 2, skipB = 3" << endl;

		IntersectionOfTwoLinkedList::Solution solution;
		IntersectionOfTwoLinkedList::ListNode* result = solution.getIntersectionNode(headA, headB);

		cout << "Result: Intersected at '" << (result ? to_string(result->val) : "null") << "'" << endl;
		cout << "Expected: Intersected at '8'" << endl;
		cout << (result == intersection ? "PASS" : "FAIL") << endl;

		// Cleanup (break cycle before deleting)
		headA->next->next = nullptr;
		headB->next->next->next = nullptr;
		delete headA->next;
		delete headA;
		delete headB->next->next;
		delete headB->next;
		delete headB;
		delete intersection->next->next;
		delete intersection->next;
		delete intersection;
	}

	static void testExample2() {
		cout << "\n=== Test: Example 2 ===" << endl;

		// Build shared tail: 4 -> 5 -> 4
		IntersectionOfTwoLinkedList::ListNode* intersection = new IntersectionOfTwoLinkedList::ListNode(4);
		intersection->next = new IntersectionOfTwoLinkedList::ListNode(5);
		intersection->next->next = new IntersectionOfTwoLinkedList::ListNode(4);

		// Build list A: 2 -> 2 -> (intersection)
		IntersectionOfTwoLinkedList::ListNode* headA = new IntersectionOfTwoLinkedList::ListNode(2);
		headA->next = new IntersectionOfTwoLinkedList::ListNode(2);
		headA->next->next = intersection;

		// Build list B: 2 -> 2 -> (intersection)
		IntersectionOfTwoLinkedList::ListNode* headB = new IntersectionOfTwoLinkedList::ListNode(2);
		headB->next = new IntersectionOfTwoLinkedList::ListNode(2);
		headB->next->next = intersection;

		cout << "listA = [2,2,4,5,4], listB = [2,2,4,5,4], skipA = 2, skipB = 2" << endl;

		IntersectionOfTwoLinkedList::Solution solution;
		IntersectionOfTwoLinkedList::ListNode* result = solution.getIntersectionNode(headA, headB);

		cout << "Result: Intersected at '" << (result ? to_string(result->val) : "null") << "'" << endl;
		cout << "Expected: Intersected at '4'" << endl;
		cout << (result == intersection ? "PASS" : "FAIL") << endl;

		// Cleanup (break cycles before deleting)
		headA->next->next = nullptr;
		headB->next->next = nullptr;
		delete headA->next;
		delete headA;
		delete headB->next;
		delete headB;
		delete intersection->next->next;
		delete intersection->next;
		delete intersection;
	}
};
