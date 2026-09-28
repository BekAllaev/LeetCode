namespace ReversePolishNotation;

public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new();

        foreach (var token in tokens)
        {
            if (token is "+" or "*" or "/" or "-")
            {
                var secondOperand = stack.Pop();
                var firstOperand = stack.Pop();

                var result = token switch
                {
                    "+" => firstOperand + secondOperand,
                    "*" => firstOperand * secondOperand,
                    "/" => firstOperand / secondOperand,
                    "-" => firstOperand - secondOperand
                };

                stack.Push(result);
            }
            else
                stack.Push(int.Parse(token));
        }

        return stack.Pop();
    }
}
