#pragma once
#include <string>
#include <vector>

using namespace std;

namespace LongestCommonPrefix {
	class Solution {
	public:
		string longestCommonPrefix(vector<string>& strs) {
			if (strs.empty()) return "";

			int prefixLen = strs[0].size();

			for (int i = 1; i < strs.size(); i++) {
				while (strs[i].compare(0, prefixLen, strs[0], 0, prefixLen) != 0)
					prefixLen--;

				if (prefixLen == 0) return "";
			}

			return strs[0].substr(0, prefixLen);
		}
	};
}