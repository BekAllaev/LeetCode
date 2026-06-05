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

	XorTotals::Solution xorTotals;

	vector<int> nums = { 5,1,6 };
	xorTotals.subsetXORSum(nums);
}
