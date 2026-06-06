#pragma once
#include <vector>
#include <stack>

using namespace std;

/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */

struct TreeNode {
	int val;
	TreeNode* left;
	TreeNode* right;
	TreeNode() : val(0), left(nullptr), right(nullptr) {}
	TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
	TreeNode(int x, TreeNode* left, TreeNode* right) : val(x), left(left), right(right) {}
};

// Solution with recursion that runs for 0ms
//class Solution {
//private:
//	void travers(TreeNode* node, vector<int>& result) {
//		if (!node)
//			return;
//
//		travers(node->left, result);
//		result.push_back(node->val);
//
//		travers(node->right, result);
//	}
//public:
//	vector<int> inorderTraversal(TreeNode* root) {
//		vector<int> result;
//
//		travers(root, result);
//
//		return result;
//	}
//};
