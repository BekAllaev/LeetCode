#pragma once
#include <string>
#include <stack>

using namespace std;

namespace ValidParentheses {
	class Solution {
	private:
		static constexpr char OPEN_PAREN    = '(';
		static constexpr char CLOSE_PAREN   = ')';
		static constexpr char OPEN_BRACE    = '{';
		static constexpr char CLOSE_BRACE   = '}';
		static constexpr char OPEN_BRACKET  = '[';
		static constexpr char CLOSE_BRACKET = ']';
	public:
		bool isValid(string s) {
			stack<char> st;
			for (int i = 0; i < s.size(); i++) {
				switch (s[i]) {
				case OPEN_PAREN:
				case OPEN_BRACE:
				case OPEN_BRACKET:
					st.push(s[i]);
					break;
				case CLOSE_PAREN:
					if (st.empty() || st.top() != OPEN_PAREN) return false;
					st.pop();
					break;
				case CLOSE_BRACE:
					if (st.empty() || st.top() != OPEN_BRACE) return false;
					st.pop();
					break;
				case CLOSE_BRACKET:
					if (st.empty() || st.top() != OPEN_BRACKET) return false;
					st.pop();
					break;
				}
			}
			return st.empty();
		}
	};
}