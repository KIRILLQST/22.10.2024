
public class ParenthesesChecker
{
    public bool IsBalanced(string s)
    {
        var stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if (stack.Count == 0)
                {
                    return false; 
                }

                char last = stack.Pop();
                if (!IsPair(last, c))
                {
                    return false; 
                }
            }
        }

        return stack.Count == 0; 
    }

    private bool IsPair(char open, char close)
    {
        return (open == '(' && close == ')') ||
               (open == '{' && close == '}') ||
               (open == '[' && close == ']');
    }
}


