#pragma once
#include <vector>

using namespace std;

// 88. Merge Sorted Array
namespace MergeSortedArray {
	// This is O(M+N) solution, also runs for 0ms(beats 100%)
	class Solution {
	public:
		void merge(vector<int>& nums1, int m, vector<int>& nums2, int n) {
			int pointer1 = m - 1;
			int pointer2 = n - 1;
			int pointer3 = m + n - 1;

			for (; pointer3 >= 0;) {
				if (pointer1 < 0) {
					nums1[pointer3] = nums2[pointer2];
					pointer3--;
					pointer2--;
					continue;
				}

				if (pointer2 < 0) {
					nums1[pointer3] = nums1[pointer1];
					pointer3--;
					pointer1--;
					continue;
				}

				if (nums1[pointer1] > nums2[pointer2]) {
					nums1[pointer3] = nums1[pointer1];
					pointer1--;
				}
				else if (nums1[pointer1] < nums2[pointer2]) {
					nums1[pointer3] = nums2[pointer2];
					pointer2--;
				}
				else {
					nums1[pointer3] = nums1[pointer1];

					pointer3--;
					pointer1--;

					nums1[pointer3] = nums2[pointer2];

					pointer2--;
				}

				pointer3--;
			}
		}
	};

	// This is O(M*N) solution, but even though it is O(M*N) it runs relatively fast, I have it for 0ms(beats 100%)
	// For example, worst case - all numbers from nums2 are smaller than all numbers from nums1 which make compare all numbers from nums2 with all numbers from num1
	//class Solution {
	//public:
	//	void merge(vector<int>& nums1, int m, vector<int>& nums2, int n) {
	//		int pointer1 = 0, pointer2 = 0, tmp = 0, nums1Size = nums1.size();

	//		if (m == 0) {
	//			nums1 = nums2;
	//			return;
	//		}

	//		for (; pointer2 < n; pointer2++) {

	//			nums1[nums1Size - 1] = nums2[pointer2];

	//			for (int i = nums1Size - 1; i >= pointer1; i--) {
	//				if (i - 1 >= 0 && (nums1[i - 1] > nums1[i] || (nums1[i - 1] == 0 && i > (m + pointer2)))) {
	//					tmp = nums1[i - 1];
	//					nums1[i - 1] = nums1[i];
	//					nums1[i] = tmp;
	//				}
	//				else {
	//					pointer1 = i;
	//				}
	//			}
	//		}
	//	}
	//};
}