#pragma once
#include <queue>
#include <unordered_set>

using namespace std;

namespace SameTree {
	struct TreeNode {
		int val;
		TreeNode* left;
		TreeNode* right;
		TreeNode() : val(0), left(nullptr), right(nullptr) {}
		TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
		TreeNode(int x, TreeNode* left, TreeNode* right) : val(x), left(left), right(right) {}
	};
	// 100. Same tree
	// Accepted solution runs for 0ms. But it is suggested to solve it with DFS to reduce space usage
	class Solution {
	public:
		bool isSameTree(TreeNode* p, TreeNode* q) {
			queue<TreeNode*> firstQueue;
			queue<TreeNode*> secondQueue;

			TreeNode* firstTmp;
			TreeNode* secondTmp;

			firstQueue.push(p);
			secondQueue.push(q);

			// Start BFS on both trees and on each itteration compare node values
			while (!firstQueue.empty() || !secondQueue.empty()) {
				if (firstQueue.size() != secondQueue.size())
					return false;

				firstTmp = firstQueue.front();
				secondTmp = secondQueue.front();

				firstQueue.pop();
				secondQueue.pop();

				if (firstTmp == nullptr && secondTmp == nullptr)
					continue;
				else if ((firstTmp == nullptr && secondTmp != nullptr) || (secondTmp == nullptr && firstTmp != nullptr))
					return false;
				else if (firstTmp->val != secondTmp->val)
					return false;

				if (firstTmp->left || firstTmp->right) {
					firstQueue.push(firstTmp->left);
					firstQueue.push(firstTmp->right);
				}

				if (secondTmp->left || secondTmp->right) {
					secondQueue.push(secondTmp->left);
					secondQueue.push(secondTmp->right);
				}
			}

			return true;
		}
	};
}