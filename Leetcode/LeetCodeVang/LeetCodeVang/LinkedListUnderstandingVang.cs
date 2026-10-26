namespace LeetCodeVang
{
    /*
     * This is a simple experimentation for me to mess around
     * With singly linked lists.
     */
    public static class LinkedListUnderstandingVang
    {
        public static void Main(string[] args)
        {
            LinkedListNodesVang test = new(1);

            for (int i = 2; i < 51; i++)
            {
                test.Add(i);
            }

            test.PrintAll();

            Console.WriteLine("Now removing 21");
            test.Remove(21);
            test.PrintAll();
            Console.WriteLine("And adding 21 back...");
            test.AddAfter(20, 21);
            test.PrintAll();
            Console.WriteLine("And now setting 0 as the starter now...");
            test.AddFirst(0);
            test.PrintAll();

            Console.WriteLine("Checking if list contains 21.");
            var check = test.Contains(21);
            Console.WriteLine($"Returned: {check}");

            Console.WriteLine("Finding the last node in the list...");
            var lastNode = test.FindLast();
            Console.WriteLine($"Returned {lastNode.Value}");

            Console.WriteLine("And now removing the last node...");
            test.RemoveLast();
            test.PrintAll();

            Console.WriteLine("Removing 12 and adding it back using the AddBefore function");
            test.Remove(12);
            Console.WriteLine("Removed");
            test.PrintAll();
            test.AddBefore(13, 12);
            Console.WriteLine("Added back.");
            test.PrintAll();

            Console.WriteLine("Clearing out the list");
            test.Clear();
            test.PrintAll();

            Console.WriteLine("Thanks for learning with me!");
            Console.ReadLine();
        }
    }

    public class LinkedListNodesVang
    {
        private LinkedListNodeVang _head;

        // For simplicity just one integer value to begin the list.
        public LinkedListNodesVang(int val)
        {
            _head = new LinkedListNodeVang(val);
        }

        public bool Contains(int val)
        {
            LinkedListNodeVang pointer = _head;

            // Or maybe in a prod. environment return the node itself.
            while (pointer != null)
            {
                if (pointer.Value == val)
                    return true;
                else if (pointer.Next != null)
                    pointer = pointer.Next;
                else
                    return false;
            }

            return false;
        }

        public bool RemoveLast()
        {
            LinkedListNodeVang toRemove = FindLast();

            if (toRemove != null)
                Remove(toRemove.Value);

            return true;
        }

        public LinkedListNodeVang FindLast()
        {
            LinkedListNodeVang pointer = _head;
            while (pointer != null)
            {
                if (pointer.Next != null)
                {
                    pointer = pointer.Next;
                }
                else
                {
                    return pointer;
                }
            }

            return _head;
        }

        public void Clear()
        {
            var toRemove = _head.Next;
            _head = null;

            while (toRemove != null)
            {
                if (toRemove.Next != null)
                {
                    var temp = toRemove.Next;
                    toRemove = null;
                    toRemove = temp;
                }
                else
                {
                    toRemove = null;
                }
            }
        }

        // Again for simplicity just assume no duplicate values.
        public bool AddAfter(int node, int newNode)
        {
            LinkedListNodeVang start = _head;
            while (start != null)
            {
                if (start.Value == node)
                    break;

                start = start.Next;
            }

            if (start != null)
            {
                var temp = start.Next;
                start.Next = new LinkedListNodeVang(newNode);
                start = start.Next;
                if (temp != null)
                {
                    start.Next = temp;
                    temp = temp.Next;
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        public bool AddBefore(int node, int newNode)
        {
            LinkedListNodeVang pointer = _head;

            while (pointer != null)
            {
                if (pointer.Next != null && pointer.Next.Value == node)
                {
                    var temp = pointer.Next;
                    pointer.Next = new LinkedListNodeVang(newNode)
                    {
                        Next = temp
                    };
                    return true;
                }
                else if (pointer.Next != null && pointer.Next.Value != node)
                {
                    pointer = pointer.Next;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        public bool AddFirst(int node)
        {
            var temp = _head;
            _head = new LinkedListNodeVang(node);
            _head.Next = temp;

            return true;
        }

        public bool Add(int value)
        {
            LinkedListNodeVang toAdd = new(value);
            LinkedListNodeVang start = _head;

            while (start != null)
            {
                if (start.Next == null)
                {
                    start.Next = toAdd;
                    break;
                }
                else
                    start = start.Next;
            }

            return true;
        }

        public bool Remove(int node)
        {
            // The node just one before what we remove.
            LinkedListNodeVang BeforeToRemove = _head;
            while (BeforeToRemove.Next != null)
            {
                if (BeforeToRemove.Next.Value == node)
                    break;
                BeforeToRemove = BeforeToRemove.Next;
            }

            if (BeforeToRemove != null)
            {
                LinkedListNodeVang temp = null;
                if (BeforeToRemove.Next!.Next != null)
                    temp = BeforeToRemove.Next.Next;

                if (temp == null)
                {
                    BeforeToRemove.Next = null;
                }
                else
                {
                    BeforeToRemove.Next = temp;
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintAll()
        {
            LinkedListNodeVang start = _head;

            Console.WriteLine("Starting:");
            while (start != null)
            {
                Console.Write($"{start.Value} ");
                start = start.Next;
            }
            Console.WriteLine("\nFinished!\n");
        }
    }

    public class LinkedListNodeVang
    {
        /// <summary>
        /// The data to hold in node.
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// The next node to point/reference to.
        /// </summary>
        public LinkedListNodeVang Next { get; set; }
        public LinkedListNodeVang(int val, LinkedListNodeVang next = null)
        {
            this.Value = val; this.Next = next;
        }
    }
}
