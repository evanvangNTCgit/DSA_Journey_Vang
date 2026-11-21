namespace LeetCodeVang
{
    /*
     * Design a stack class that supports these operations
     * push, pop, top, and getMin
     * 
     * ALL IN O(1) TIME.
     * 
     * void Push(int val) pushes elemnt val onto stack
     * void Pop() removes top element of stack
     * int Top() gets the top element of the stack
     * int getMin() gets the minimum element in the stack.
     */
    public class MinStack
    {
        Stack<int> stack;
        Stack<int> mins; // Top elem should be the minimum.

        public MinStack()
        {
            this.stack = new Stack<int>();
            this.mins = new Stack<int>();
        }

        public void Push(int val)
        {
            this.stack.Push(val);
            if (this.mins.Count <= 0)
            {
                this.mins.Push(val);
            }
            else
            {
                if(this.mins.Peek() > val)
                {
                    this.mins.Push(val);
                }
                else
                {
                    this.mins.Push(this.mins.Peek());
                }
            }
        }

        public void Pop()
        {
            this.stack.Pop();
            this.mins.Pop();
        }

        public int Top()
        {
            return this.stack.Peek();
        }

        public int GetMin()
        {
            return this.mins.Peek();
        }
    }
}
