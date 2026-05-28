#pragma once
#include <vector>

using namespace std;

namespace RemoveElementArray {
    // 27. Remove element
    class Solution {
    public:
        int removeElement(vector<int>& nums, int val) {
            int slow = 0, fast = 0;
            int k = 0;

            for (; fast < nums.size(); fast++) {
                if (nums[fast] != val) {
                    nums[slow] = nums[fast];
                    slow++;
                    k++;
                }
            }

            return k;
        }
    };
}