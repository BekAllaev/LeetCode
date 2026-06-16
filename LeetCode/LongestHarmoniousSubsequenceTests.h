#pragma once
#include <vector>
#include <iostream>
#include "LongestHarmoniousSubsequence.h"

using namespace std;

class LongestHarmoniousSubsequenceTests {
public:
	static void runAllTests() {
		testExample1();
		testExample2();
		testEmptyArray();
		testSingleElement();
		testTwoElementsDifferByOne();
		testTwoElementsSame();
		testTwoElementsDifferByTwo();
		testAllSameElements();
		testNoHarmoniousSubsequence();
		testConsecutiveNumbers();
		testConsecutiveWithDuplicates();
		testMultipleHarmoniousPairs();
		testNegativeNumbers();
		testMixedPositiveNegative();
		testLargeGaps();
		testOnePairOnly();
		testManyDuplicates();
		testAlreadyHarmonious();
	}

private:
	static void printArray(const vector<int>& nums, const string& label) {
		cout << label << ": ";
		for (int num : nums) {
			cout << num << " ";
		}
		cout << endl;
	}

	static void testExample1() {
		cout << "\n=== Test: Example 1 ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { 1, 3, 2, 2, 5, 2, 3, 7 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
		cout << "Expected: 5 (subsequence [3,2,2,2,3])" << endl;
	}

	static void testExample2() {
		cout << "\n=== Test: Example 2 ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { 1, 2, 3, 4 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
		cout << "Expected: 2 (any pair like [1,2] or [2,3] or [3,4])" << endl;
	}

	static void testEmptyArray() {
		cout << "\n=== Test: Empty Array ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = {};
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
		cout << "Expected: 0 (no elements)" << endl;
	}

	static void testSingleElement() {
		cout << "\n=== Test: Single Element ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { 1 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
		cout << "Expected: 0 (need at least 2 different values differing by 1)" << endl;
	}

	static void testTwoElementsDifferByOne() {
		cout << "\n=== Test: Two Elements Differ By One ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { 1, 2 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
		cout << "Expected: 2" << endl;
	}

	static void testTwoElementsSame() {
		cout << "\n=== Test: Two Same Elements ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { 5, 5 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
		cout << "Expected: 0 (difference is 0, not 1)" << endl;
	}

	static void testTwoElementsDifferByTwo() {
		cout << "\n=== Test: Two Elements Differ By Two ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { 1, 3 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
		cout << "Expected: 0 (difference is 2, not 1)" << endl;
	}

	static void testAllSameElements() {
		cout << "\n=== Test: All Same Elements ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { 7, 7, 7, 7, 7 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
		cout << "Expected: 0 (no difference)" << endl;
	}

	static void testNoHarmoniousSubsequence() {
		cout << "\n=== Test: No Harmonious Subsequence ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { 1, 4, 7, 10, 13 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
		cout << "Expected: 0 (all elements differ by more than 1)" << endl;
	}

	static void testConsecutiveNumbers() {
		cout << "\n=== Test: Consecutive Numbers ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { 1, 2, 3, 4, 5 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
		cout << "Expected: 2 (any consecutive pair)" << endl;
	}

	static void testConsecutiveWithDuplicates() {
		cout << "\n=== Test: Consecutive With Duplicates ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { 1, 1, 1, 2, 2, 2 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
		cout << "Expected: 6 (all elements form [1,1,1,2,2,2])" << endl;
	}

	static void testMultipleHarmoniousPairs() {
		cout << "\n=== Test: Multiple Harmonious Pairs ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { 1, 1, 2, 2, 5, 5, 6, 6, 6 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
		cout << "Expected: 5 (subsequence [5,5,6,6,6])" << endl;
	}

	static void testNegativeNumbers() {
		cout << "\n=== Test: Negative Numbers ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { -3, -3, -2, -2, -2, -1 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
		cout << "Expected: 5 (subsequence [-3,-3,-2,-2,-2] or [-2,-2,-2,-1])" << endl;
	}

	static void testMixedPositiveNegative() {
		cout << "\n=== Test: Mixed Positive Negative ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { -1, -1, 0, 0, 0, 1, 1 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
		cout << "Expected: 5 (subsequence [-1,-1,0,0,0] or [0,0,0,1,1])" << endl;
	}

	static void testLargeGaps() {
		cout << "\n=== Test: Large Gaps ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { 1, 100, 200, 201, 300 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
		cout << "Expected: 2 (only [200,201])" << endl;
	}

	static void testOnePairOnly() {
		cout << "\n=== Test: One Pair Only ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { 3, 4 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
		cout << "Expected: 2" << endl;
	}

	static void testManyDuplicates() {
		cout << "\n=== Test: Many Duplicates ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { 9, 9, 9, 9, 10, 10, 10 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
		cout << "Expected: 7 (all elements)" << endl;
	}

	static void testAlreadyHarmonious() {
		cout << "\n=== Test: Already Harmonious ===" << endl;
		LongestHarmoniousSubsequence::Solution solution;
		vector<int> nums = { 5, 5, 6, 6 };
		printArray(nums, "Input");
		int result = solution.findLHS(nums);
		cout << "Result: " << result << endl;
		cout << "Expected: 4 (all elements)" << endl;
	}
};
