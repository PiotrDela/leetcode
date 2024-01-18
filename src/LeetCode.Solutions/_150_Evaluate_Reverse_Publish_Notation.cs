//Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.

//Implement the MinStack class:

//    MinStack() initializes the stack object.
//    void push(int val) pushes the element val onto the stack.
//    void pop() removes the element on the top of the stack.
//    int top() gets the top element of the stack.
//    int getMin() retrieves the minimum element in the stack.

//You must implement a solution with O(1) time complexity for each function.

namespace LeetCode.Solutions;

public class _150_Evaluate_Reverse_Publish_Notation
{
    private static readonly Dictionary<string, Func<int, int, int>> calculations = new Dictionary<string, Func<int, int, int>>()
    {
        {"+", (a, b) => a + b },
        {"-", (a, b) => a - b },
        {"*", (a, b) => a * b },
        {"/", (a, b) => a / b },
    };

    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();

        for (int i = 0; i < tokens.Length; i++)
        {
            var token = tokens[i];
            if (int.TryParse(token, out var number))
            {
                stack.Push(number);
                continue;
            }

            var second = stack.Pop();
            var first = stack.Pop();

            stack.Push(calculations[token](first, second));
        }

        return stack.Pop();
    }
}
