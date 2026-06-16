#pragma once
#include <vector>
#include <iostream>
#include "LongestHarmoniousSubsequence.h"

using namespace std;

class QuickSortTests {
public:
	static void runAllTests() {
		testEmptyArray();
		testSingleElement();
		testTwoElements();
		testAlreadySorted();
		testReverseSorted();
		testAllSameElements();
		testDuplicates();
		testNegativeNumbers();
		testMixedPositiveNegative();
		testLargeArray();
		testAlternatingHighLow();
		testThreeElements();
	}

private:
	static void printArray(const vector<int>& nums, const string& label) {
		cout << label << ": ";
		for (int num : nums) {
			cout << num << " ";
		}
		cout << endl;
	}

	static void testEmptyArray() {
		cout << "\n=== Test: Empty Array ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = {};
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
	}

	static void testSingleElement() {
		cout << "\n=== Test: Single Element ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { 5 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
	}

	static void testTwoElements() {
		cout << "\n=== Test: Two Elements ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { 3, 1 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
	}

	static void testThreeElements() {
		cout << "\n=== Test: Three Elements ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { 3, 1, 2 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
	}

	static void testAlreadySorted() {
		cout << "\n=== Test: Already Sorted ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
	}

	static void testReverseSorted() {
		cout << "\n=== Test: Reverse Sorted ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
	}

	static void testAllSameElements() {
		cout << "\n=== Test: All Same Elements ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { 5, 5, 5, 5, 5, 5 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
	}

	static void testDuplicates() {
		cout << "\n=== Test: Array with Duplicates ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { 4, 2, 7, 2, 9, 4, 1, 7, 4 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
	}

	static void testNegativeNumbers() {
		cout << "\n=== Test: Negative Numbers ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { -5, -1, -9, -3, -7 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
	}

	static void testMixedPositiveNegative() {
		cout << "\n=== Test: Mixed Positive and Negative ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { 3, -1, 4, -5, 2, -3, 0, 6, -2 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
	}

	static void testLargeArray() {
		cout << "\n=== Test: Large Array ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { 64, 34, 25, 12, 22, 11, 90, 88, 45, 50, 23, 36, 18, 77, 99, 1, 5, 81, 100, 42 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
	}

	static void testAlternatingHighLow() {
		cout << "\n=== Test: Alternating High Low ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { 100, 1, 99, 2, 98, 3, 97, 4 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
	}
};
