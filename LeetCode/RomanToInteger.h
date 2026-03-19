#pragma once
#include <string>
#include <unordered_map>

using namespace std;

namespace RomanToInteger {
	class Solution {
	private:
		inline static const unordered_map<string, int> romanToIntMap = {
			{"I", 1}, {"V", 5}, {"X", 10}, {"L", 50},
			{"C", 100}, {"D", 500}, {"M", 1000}, {"CD", 400},
			{"CM", 900}, {"XL", 40}, {"XC", 90}, {"IV", 4},
			{"IX", 9}
		};

	public:
		int romanToInt(string s) {
			int number = 0;

			for (int i = s.size() - 1; i >= 0; i--) {
				if (i == 0) {
					number += romanToIntMap.at({ s[i] });
				}
				else {
					if (!romanToIntMap.contains({ s[i - 1], s[i] }))
						number += romanToIntMap.at({ s[i] });
					else
					{
						number += romanToIntMap.at({ s[i - 1],s[i] });
						i--;
					}
				}
			}

			return number;
		}
	};
}
