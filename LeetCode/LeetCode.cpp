#include <iostream>
#include <vector>
#include "RomanToInteger.h"
#include "LongestCommonPrefix.h"
#include "ValidParentheses.h"
#include "RemoveDuplicateFromSortedArray.h"

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

	RemoveDuplicateFromSortedArray::Solution removeDuplicateFromSortedArray;
	vector<int> vector1 = { 1, 1, 2 };
	vector<int> vector2 = { 0,0,1,1,1,2,2,3,3,4 };
	int k1 = removeDuplicateFromSortedArray.removeDuplicates(vector1);
	int k2 = removeDuplicateFromSortedArray.removeDuplicates(vector2);

	std::cout << "For vector1, k - " << k1 << std::endl;
	for (int i = 0; i < k1; i++)
	{
		std::cout << vector1[i] << " ";
	}

	std::cout << std::endl;

	std::cout << "For vector2, k - " << k2 << std::endl;
	for (int i = 0; i < k2; i++)
	{
		std::cout << vector2[i] << " ";
	}

	std::cout << std::endl;

}
