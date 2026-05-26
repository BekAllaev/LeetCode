#pragma once
#include <vector>
#include <unordered_set>

using namespace std;

namespace ContainsDuplicateII {
	class Solution {
	public:
		bool containsNearbyDuplicate(vector<int>& nums, int k) {
			int l = 0, r = 0;
			std::unordered_set<int> s;

			for (; r < nums.size(); r++) {
				if (std::abs(l - r) > k) {
					s.erase(nums[l]);
					l++;
				}

				if (s.count(nums[r])) {
					return true;
				}

				s.insert(nums[r]);
			}

			return false;
		}
	};
}