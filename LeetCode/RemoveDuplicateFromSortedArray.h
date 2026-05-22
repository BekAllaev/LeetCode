#pragma once
#include <vector>

using namespace std;

namespace RemoveDuplicateFromSortedArray {
	class Solution {
	public:
		int removeDuplicates(vector<int>& nums) {
			int slow = 0, fast = 0;
			int k = 1;

			for (; fast < nums.size(); fast++) {
				//1. put slow and fast to the first item
				//2. when fast!=slow-1 do the swap. Put the fast to the slow+1, and increase the slow
				//3. increase the k
				if (nums[fast] != nums[slow]) {
					nums[slow + 1] = nums[fast];
					slow++;
					k++;
				}
			}

			return k;
		}
	};
}
