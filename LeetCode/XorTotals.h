#pragma once
#include <vector>

using namespace std;

namespace XorTotals {
	/* 
	===========
	Accepted solution that runs for 61ms, beats 6.63%
	Solution approach - backtracking
	===========
		class Solution {
	private:
		int getXor(vector<int>& nums) {
			if (nums.size() == 1) {
				return nums[0];
			}

			int result = 0;

			for (int i = 0; i < nums.size(); i++) {
				result = result ^ nums[i];
			}

			return result;
		}

		void setSubSets(vector<int>& nums, vector<vector<int>>& subSets, vector<int> previous, int numsIndex, int& iterration) {
			if (numsIndex == nums.size())
				return;

			vector<int> tmp = previous;

			for (int i = numsIndex; i < nums.size(); i++) {
				iterration++;

				previous.push_back(nums[i]);
				subSets[iterration] = previous;
				result += getXor(subSets[iterration]);

				setSubSets(nums, subSets, previous, i + 1, iterration);

				previous = tmp;
			}
		}
	public:
		int subsetXORSum(vector<int>& nums) {
			int result = 0, iterration = 0;
			int numberOfSubSets = pow(2, nums.size()) - 1;
			vector<vector<int>> subSets(numberOfSubSets);

			for (int i = 0; i < nums.size(); i++) {
				subSets[iterration] = { nums[i] };

				setSubSets(nums, subSets, subSets[iterration], i + 1, iterration);
				iterration++;
			}

			for (int i = 0; i < subSets.size(); i++) {
				result += getXor(subSets[i]);
			}

			return result;
		}
	};
	*/

	// Accepted solution that runs for 0ms
	// Optimized backtracking
	//class Solution {
	//private:
	//	void setSubSets(vector<int>& nums, int currentXor, int numsIndex, int& result) {
	//		if (numsIndex == nums.size())
	//			return;

	//		int previousXor = currentXor;

	//		for (int i = numsIndex; i < nums.size(); i++) {
	//			currentXor = previousXor ^ nums[i];
	//			result += currentXor;

	//			setSubSets(nums, currentXor, i + 1, result);
	//		}
	//	}
	//public:
	//	int subsetXORSum(vector<int>& nums) {
	//		int result = 0;

	//		for (int i = 0; i < nums.size(); i++) {
	//			result += nums[i];

	//			setSubSets(nums, nums[i], i + 1, result);
	//		}

	//		return result;
	//	}
	//};

	// This solution also runs for 0ms, but the idea - FUHA, I didn't even imagined that this can be a solution....
	// Solution approach - bit manipulation
	class Solution {
	public:
		int subsetXORSum(vector<int>& nums) {
			int orResult = 0;

			for (int i = 0; i < nums.size(); i++) {
				orResult |= nums[i];
			}

			return orResult * pow(2, nums.size() - 1);
		}
	};
}