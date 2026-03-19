#pragma once
#include <string>
#include <stack>

using namespace std;

namespace ValidParentheses {
	class Solution {
	private:
		static constexpr char OPEN_PAREN = '(';
		static constexpr char CLOSE_PAREN = ')';
		static constexpr char OPEN_BRACE = '{';
		static constexpr char CLOSE_BRACE = '}';
		static constexpr char OPEN_BRACKET = '[';
		static constexpr char CLOSE_BRACKET = ']';

	public:
		bool isValid(string s) {
			stack<char> st;

			for (int i = 0; i < s.length(); i++) {
				if (s[i] == OPEN_BRACE || s[i] == OPEN_BRACKET || s[i] == OPEN_PAREN) {
					st.push(s[i]);
				}
				else if (s[i] == CLOSE_BRACE) {
					if (st.empty() || st.top() != OPEN_BRACE) {
						return false;
					}
					st.pop();
				}
				else if (s[i] == CLOSE_BRACKET) {
					if (st.empty() || st.top() != OPEN_BRACKET) {
						return false;
					}
					st.pop();
				}
				else if (s[i] == CLOSE_PAREN) {
					if (st.empty() || st.top() != OPEN_PAREN) {
						return false;
					}
					st.pop();
				}
			}

			return st.empty();
		}
	};
}