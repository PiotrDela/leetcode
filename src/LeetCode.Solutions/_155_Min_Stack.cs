//Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.

//Implement the MinStack class:

//    MinStack() initializes the stack object.
//    void push(int val) pushes the element val onto the stack.
//    void pop() removes the element on the top of the stack.
//    int top() gets the top element of the stack.
//    int getMin() retrieves the minimum element in the stack.

//You must implement a solution with O(1) time complexity for each function.

namespace LeetCode.Solutions;

public class _155_Min_Stack
{
    private readonly LinkedList<(int Value, int MinValue)> list = new LinkedList<(int Value, int MinValue)> ();

    public void Push(int val)
    {
        if (list.Count == 0)
        {
            list.AddFirst((val, val));            
        }
        else
        {
            var min = Math.Min(list.First.Value.MinValue, val);
            list.AddFirst((val, min));
        }
    }

    public void Pop()
    {
        list.RemoveFirst();
    }

    public int Top()
    {
        return list.First.Value.Value;
    }

    public int GetMin()
    {
        return list.First.Value.MinValue;
    }
}
