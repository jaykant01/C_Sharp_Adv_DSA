namespace Stack;

interface IExpressionEvaluator
{
    int Evaluate(string expression);
}

public class PostfixEvaluator : IExpressionEvaluator
{
    public int Evaluate(string infixExpression)
    {
        string postfix = ConvertInfixToPostfix(infixExpression);
        return EvaluatePostfix(postfix);
    }

    private string ConvertInfixToPostfix(string infix)
    {
        Stack<char> stack = new Stack<char>();
        string postfix = "";

        foreach (char ch in infix)
        {
            if (char.IsDigit(ch))
                postfix += ch;
            else if (ch == '(')
                stack.Push(ch);
            else if (ch == ')')
            {
                while (stack.Peek() != '(')
                    postfix += stack.Pop();
                stack.Pop();
            }
            else
            {
                while (stack.Count > 0 && Precedence(stack.Peek()) >= Precedence(ch))
                    postfix += stack.Pop();
                stack.Push(ch);
            }
        }

        while (stack.Count > 0)
            postfix += stack.Pop();

        return postfix;
    }

    private int EvaluatePostfix(string postfix)
    {
        Stack<int> stack = new Stack<int>();

        foreach (char ch in postfix)
        {
            if (char.IsDigit(ch))
                stack.Push(ch - '0');
            else
            {
                int b = stack.Pop();
                int a = stack.Pop();
                stack.Push(ApplyOperator(a, b, ch));
            }
        }
        return stack.Pop();
    }

    private int Precedence(char op)
    {
        if (op == '+' || op == '-') return 1;
        if (op == '*' || op == '/') return 2;
        return 0;
    }

    private int ApplyOperator(int a, int b, char op)
    {
        return op switch
        {
            '+' => a + b,
            '-' => a - b,
            '*' => a * b,
            '/' => a / b,
            _ => 0
        };
    }
}
