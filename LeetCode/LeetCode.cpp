#include <iostream>
#include <vector>
#include "RomanToInteger.h"
#include "LongestCommonPrefix.h"
#include "ValidParentheses.h"

using namespace std;

int main()
{
	//RomanToInteger::Solution romanToIntegerSolution;
	//std::cout << romanToIntegerSolution.romanToInt("MCMXCIV");

	//LongestCommonPrefix::Solution longestCommonPrefixSolution;
	//vector<string> words = { "flower", "flow", "flight" };
	//std::cout << longestCommonPrefixSolution.longestCommonPrefix(words);

	ValidParentheses::Solution validParenthesesSolution;
	std::cout << validParenthesesSolution.isValid("()") << std::endl;
	std::cout << validParenthesesSolution.isValid("()[]{}") << std::endl;
	std::cout << validParenthesesSolution.isValid("(]") << std::endl;
	std::cout << validParenthesesSolution.isValid("([])") << std::endl;
	std::cout << validParenthesesSolution.isValid("([)]") << std::endl;
}
