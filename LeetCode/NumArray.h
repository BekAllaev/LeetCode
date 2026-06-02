#pragma once
#include <vector>

using namespace std;

// 303. Range Sum Query - Immutable 
// This solution runs for 0ms. We build prefixSums for O(n) and then sumRange works for O(1)

// Note: I made a mistake that cycle which fills prefix sum was in the sumRange. So I my solution was run
// for 275ms which beats 5% of solutions. Fix was simple, just move cycle into the constructor
class NumArray {
private:
    vector<int> nums;
    vector<int> prefixSums;

public:
    NumArray(vector<int>& nums) : nums(nums), prefixSums(nums.size() + 1) {
        for (int i = 0; i < nums.size(); i++) {
            prefixSums[i + 1] = prefixSums[i] + nums[i];
        }
    }

    int sumRange(int left, int right) {
        return prefixSums[right + 1] - prefixSums[left - 1];
    }
};
