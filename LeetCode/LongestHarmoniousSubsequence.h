#include <vector>
#include <cmath>
#include <algorithm>
#include <map>
#include <tuple>

using namespace std;

namespace LongestHarmoniousSubsequence {
	// This solution runs plus-minus for the same time as the previous....
	class Solution {
	public:
		int findLHS(vector<int>& nums) {
			unordered_map<int, int> map;
			int max = 0;

			for (int num : nums)
				map[num]++;

			for (auto& [key, value] : map)
				if (map.contains(key + 1) && value + map[key + 1] > max)
					max = value + map[key + 1];

			return max;
		}
	};

	//This solution works for 53ms and beats 55.22% solutions
	//class Solution {
	//private:
	//	int getPivotIndex(vector<int>& nums, int low, int high, int pivot) {
	//		int i = low - 1;

	//		for (int j = low; j < high; j++) {
	//			if (nums[j] <= pivot) {
	//				i++;
	//				swap(nums[i], nums[j]);
	//			}
	//		}

	//		swap(nums[i + 1], nums[high]);
	//		return i + 1;
	//	}

	//	void quickSort(vector<int>& nums, int low, int high) {
	//		if (low >= high)
	//			return;

	//		int pivot = nums[high];

	//		int pivotIndex = getPivotIndex(nums, low, high, pivot);

	//		quickSort(nums, low, pivotIndex - 1);
	//		quickSort(nums, pivotIndex + 1, high);
	//	}
	//public:
	//	int findLHS(vector<int>& nums) {
	//		int result = 0, left = 0, right = 0;

	//		quickSort(nums, 0, nums.size() - 1);

	//		for (; left < nums.size();) {
	//			for (; right + 1 < nums.size() && nums[right + 1] - nums[left] <= 1;)
	//				right++;

	//			if (nums[right] != nums[left] && right - left + 1 > result)
	//				result = right - left + 1;

	//			left++;
	//		}

	//		return result;
	//	}
	//};
}
