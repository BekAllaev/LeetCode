#pragma once    
#include <vector>

using namespace std;
// 35. Search Insert Position
// Runs for 0ms, complexity is O(logn)
class Solution {
public:
    int searchInsert(vector<int>& nums, int target) {
        int left = 0, right = nums.size() - 1, middle = 0;

        if (target > nums[right])
            return right + 1;
        else if (target < nums[left])
            return left;

        while (right - left > 1) {
            middle = left + (right - left) / 2;

            if (target > nums[middle])
                left = middle;
            else
                right = middle;
        }

        if (nums[middle] == target)
            return middle;
        else if (nums[left] == target)
            return left;
        else if (nums[right] == target)
            return right;
        else
            return left + 1;
    }
};

/*
Great solution from another dev
class Solution {
public:
    int searchInsert(vector<int>& nums, int target) {

        int start = 0;
        int end = nums.size() - 1;
        int mid = 0;

        while (start <= end) {

            mid = start + (end - start) / 2;

            if (nums[mid] == target) {
                return mid;
            }

            else if (nums[mid] < target) {
                start = mid + 1;
            }

            else {
                end = mid - 1;
            }
        }

        return (target > nums[mid]) ? mid + 1 : mid;
    }
};
*/