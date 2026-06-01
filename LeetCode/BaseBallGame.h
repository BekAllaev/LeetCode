#pragma once
#include <stack>
#include <vector>
#include <string>

using namespace std;

// 682. Baseball Game
// This solution runs for O(n), in particular for 0ms
namespace BaseBallGame {
	class Solution {
	public:
		int calPoints(vector<string>& operations) {
			stack<int> s;
			int tmp = 0, firstOperand = 0, secondOperand = 0;

			for (int i = 0; i < operations.size(); i++) {
				if (operations[i] == "C") {
					s.pop();
				}
				else if (operations[i] == "D") {
					tmp = s.top();
					tmp = tmp * 2;
					s.push(tmp);
				}
				else if (operations[i] == "+") {
					firstOperand = s.top();
					s.pop();
					secondOperand = s.top();
					s.pop();
					tmp = firstOperand + secondOperand;

					s.push(secondOperand);
					s.push(firstOperand);
					s.push(tmp);
				}
				else {
					s.push(stoi(operations[i]));
				}
			}

			int stackSize = s.size();
			tmp = 0;

			while (!s.empty()) {
				tmp += s.top();
				s.pop();
			}

			return tmp;
		}
	};
}