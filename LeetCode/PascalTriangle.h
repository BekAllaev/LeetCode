#pragma once
#include <vector>

using namespace std;

class Solution {
public:
    vector<vector<int>> generate(int numRows) {
        vector<vector<int>> dp(numRows);

        if (numRows > 0)
            dp[0] = { 1 };

        if (numRows > 1)
            dp[1] = { 1, 1 };

        for (int i = 2; i < dp.size(); i++) {
            dp[i].push_back(1);
            for (int j = 1; j < dp[i - 1].size(); j++)
                dp[i].push_back(dp[i - 1][j - 1] + dp[i - 1][j]);
            dp[i].push_back(1);
        }

        return dp;
    }
};