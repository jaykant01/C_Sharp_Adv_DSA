namespace Stack;

interface ISyntaxChecker
{
    bool IsSyntaxValid(string code);
}

public class CStyleSyntaxChecker : ISyntaxChecker
{
    public bool IsSyntaxValid(string code)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char ch in code)
        {
            if (IsOpening(ch))
            {
                stack.Push(ch);
            }
            else if (IsClosing(ch))
            {
                if (stack.Count == 0)
                    return false;

                char top = stack.Pop();
                if (!IsMatchingPair(top, ch))
                    return false;
            }
        }

        return stack.Count == 0;
    }

    
    private bool IsOpening(char ch)
    {
        return ch == '(' || ch == '{' || ch == '[';
    }

    private bool IsClosing(char ch)
    {
        return ch == ')' || ch == '}' || ch == ']';
    }

    private bool IsMatchingPair(char open, char close)
    {
        return (open == '(' && close == ')') ||
               (open == '{' && close == '}') ||
               (open == '[' && close == ']');
    }
}
