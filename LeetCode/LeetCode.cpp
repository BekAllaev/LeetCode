#include <iostream>
#include <vector>
#include "RomanToInteger.h"
#include "LongestCommonPrefix.h"
#include "ValidParentheses.h"
#include "RemoveDuplicateFromSortedArray.h"
#include "ContainsDuplicateII.h"
#include "MergeSortedArrays.h"
#include "BaseBallGame.h"
#include "XorTotals.h"
#include "SameTree.h"
#include "Task28.h"
#include "LongestHarmoniousSubsequenceTests.h"
//#include "QuickSortTests.h"
#include "IntersectionOfTwoLinkedListTests.h"

using namespace std;

int main()
{
	//RomanToInteger::Solution romanToIntegerSolution;
	//std::cout << romanToIntegerSolution.romanToInt("MCMXCIV");

	//LongestCommonPrefix::Solution longestCommonPrefixSolution;
	//vector<string> words = { "flower", "flow", "flight" };
	//std::cout << longestCommonPrefixSolution.longestCommonPrefix(words);

	//ValidParentheses::Solution validParenthesesSolution;
	//std::cout << validParenthesesSolution.isValid("()") << std::endl;
	//std::cout << validParenthesesSolution.isValid("()[]{}") << std::endl;
	//std::cout << validParenthesesSolution.isValid("(]") << std::endl;
	//std::cout << validParenthesesSolution.isValid("([])") << std::endl;
	//std::cout << validParenthesesSolution.isValid("([)]") << std::endl;

	//RemoveDuplicateFromSortedArray::Solution removeDuplicateFromSortedArray;
	//vector<int> vector1 = { 1, 1, 2 };
	//vector<int> vector2 = { 0,0,1,1,1,2,2,3,3,4 };
	//int k1 = removeDuplicateFromSortedArray.removeDuplicates(vector1);
	//int k2 = removeDuplicateFromSortedArray.removeDuplicates(vector2);

	//std::cout << "For vector1, k - " << k1 << std::endl;
	//for (int i = 0; i < k1; i++)
	//{
	//	std::cout << vector1[i] << " ";
	//}

	//std::cout << std::endl;

	//std::cout << "For vector2, k - " << k2 << std::endl;
	//for (int i = 0; i < k2; i++)
	//{
	//	std::cout << vector2[i] << " ";
	//}

	//std::cout << std::endl;

	//ContainsDuplicateII::Solution containsDuplicateII;

	//vector<int> vector1 = { 1,2,3,1 };
	//int k1 = 3;
	//vector<int> vector2 = { 1,0,1,1 };
	//int k2 = 1;
	//vector<int> vector3 = { 1,2,3,1,2,3 };
	//int k3 = 2;
	//vector<int> vector4 = { 4,1,2,3,1,5 };
	//int k4 = 3;
	//vector<int> vector5 = { 0,1,2,3,2,5 };
	//int k5 = 3;
	//vector<int> vector6 = { 1,2,1 };
	//int k6 = 0;

	//std::cout << "For vector1" << " " << containsDuplicateII.containsNearbyDuplicate(vector1, k1) << std::endl;
	//std::cout << "For vector2" << " " << containsDuplicateII.containsNearbyDuplicate(vector2, k2) << std::endl;
	//std::cout << "For vector3" << " " << containsDuplicateII.containsNearbyDuplicate(vector3, k3) << std::endl;
	//std::cout << "For vector4" << " " << containsDuplicateII.containsNearbyDuplicate(vector4, k4) << std::endl;
	//std::cout << "For vector5" << " " << containsDuplicateII.containsNearbyDuplicate(vector5, k5) << std::endl;
	//std::cout << "For vector6" << " " << containsDuplicateII.containsNearbyDuplicate(vector6, k6) << std::endl;

	//MergeSortedArray::Solution mergeSortedArray;
	//vector<int> vector1 = { 1,2,3,0,0,0 };
	//vector<int> vector2 = { 2,5,6 };
	//int m1 = 3, n1 = 3;
	//mergeSortedArray.merge(vector1, m1, vector2, n1);

	//vector<int> vector11 = { 1 };
	//vector<int> vector21 = {};
	//int m2 = 1, n2 = 0;
	//mergeSortedArray.merge(vector11, m2, vector21, n2);

	//vector<int> vector1 = { 2,0 };
	//vector<int> vector2 = { 1 };
	//int m = 1, n = 1;
	//mergeSortedArray.merge(vector1, m, vector2, n);

	//vector<int> vector1 = { 1,2,3,0,0,0 };
	//vector<int> vector2 = { 4,5,6 };
	//int m1 = 3, n1 = 3;
	//mergeSortedArray.merge(vector1, m1, vector2, n1);

	//BaseBallGame::Solution baseBallGame;

	//vector<string> operations = { "5", "-2", "4", "C", "D", "9", "+", "+" };
	//baseBallGame.calPoints(operations);

	//XorTotals::Solution xorTotals;

	//vector<int> nums = { 5,1,6 };
	//xorTotals.subsetXORSum(nums);

	//SameTree::Solution sameTreeSolution;

	// Example 1: p = [1,2,3], q = [1,2,3]
	//SameTree::TreeNode* p1 = new SameTree::TreeNode(1);
	//p1->left = new SameTree::TreeNode(2);
	//p1->right = new SameTree::TreeNode(3);

	//SameTree::TreeNode* q1 = new SameTree::TreeNode(1);
	//q1->left = new SameTree::TreeNode(2);
	//q1->right = new SameTree::TreeNode(3);

	//std::cout << "Example 1 - Are trees the same? " << (sameTreeSolution.isSameTree(p1, q1) ? "true" : "false") << std::endl;

	// Example 2: Left tree has 1->left(2), Right tree has 1->right(2)
	//SameTree::TreeNode* p2 = new SameTree::TreeNode(1);
	//p2->left = new SameTree::TreeNode(2);

	//SameTree::TreeNode* q2 = new SameTree::TreeNode(1);
	//q2->right = new SameTree::TreeNode(2);

	//std::cout << "Example 2 - Are trees the same? " << (sameTreeSolution.isSameTree(p2, q2) ? "true" : "false") << std::endl;

	//Solution task28Solution;

	// Example 1: haystack = "sadbutsad", needle = "sad"
	//std::cout << "Example 1 - Index: " << task28Solution.strStr("sadbutsad", "sad") << " (Expected: 0)" << std::endl;

	//// Example 2: haystack = "leetcode", needle = "leeto"
	//std::cout << "Example 2 - Index: " << task28Solution.strStr("leetcode", "leeto") << " (Expected: -1)" << std::endl;

	//// Additional test cases
	//std::cout << "Example 3 - Index: " << task28Solution.strStr("hello", "ll") << " (Expected: 2)" << std::endl;
	//std::cout << "Example 4 - Index: " << task28Solution.strStr("aaaaa", "bba") << " (Expected: -1)" << std::endl;
	//std::cout << "Example 6 - Index: " << task28Solution.strStr("a", "a") << " (Expected: 0)" << std::endl;

	//std::cout << task28Solution.strStr("ssad", "sad") << std::endl;
	//std::cout << task28Solution.strStr("sssad", "sad") << std::endl;
	//std::cout << task28Solution.strStr("ssssad", "sad") << std::endl;
	//std::cout << task28Solution.strStr("ssssssssad", "sad") << std::endl;
	//std::cout << task28Solution.strStr("sssssssssad", "sad") << std::endl;
	//std::cout << task28Solution.strStr("ssssssssssad", "sad") << std::endl;
	//std::cout << task28Solution.strStr("sssssssssssad", "sad") << std::endl;
	//std::cout << task28Solution.strStr("mississippi", "issip") << std::endl;
	//std::cout << task28Solution.strStr("mississippi", "issipi") << std::endl;

//QuickSortTests::runAllTests();
	//LongestHarmoniousSubsequenceTests::runAllTests();
	IntersectionOfTwoLinkedListTests::runAllTests();
}
