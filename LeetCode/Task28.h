#include <string>

using namespace std;

class Solution {
public:
	int strStr(string haystack, string needle) {
		int left = 0, right = 0, needleSize = needle.size();

		for (; left < haystack.size();) {
			if (haystack[left] != needle[0]) {
				left++;
				continue;
			}

			for (int i = 0; i < needle.size(); i++) {
				if (haystack[left + i] != needle[i])
					break;
				else if (i + 1 < needle.size())
					continue;

				return left;
			}

			left++;
		}

		return -1;
	}
};
