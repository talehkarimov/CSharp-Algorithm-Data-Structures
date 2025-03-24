namespace CSharp_Solutions.Solutions;

internal class BaseballGame
{
    /*
    This method evaluates a list of operations that represent actions in a 
    scoring system (e.g., adding points, doubling the score, removing the last 
    score, etc.). It uses a stack to process these operations and compute the final score.
    */

    public int CalculateTotalScore(string[] operations)
    {
        Stack<int> stack = new Stack<int>();
        foreach (string op in operations)
        {
            if (op == "C") stack.Pop(); // Remove last score
            else if (op == "D") stack.Push(stack.Peek() * 2); // Double the last score
            else if (op == "+")
            {
                int top = stack.Pop();
                int newTop = top + stack.Peek();
                stack.Push(top);
                stack.Push(newTop);
            }
            else stack.Push(int.Parse(op)); // Add new score
        }
        return stack.Sum();
    }
}
