//Stack<string> stack = new();

//string firstItem = "Minecraft";
//Console.WriteLine($"First item pushed: {firstItem}");
//stack.Push(firstItem);
//stack.Push("Baldurs Gate 3");
//stack.Push("Smash Bros Ultimate");

////var foundItem1 = stack.Where(x => x == "Baldurs Gate 3").FirstOrDefault();
////Console.WriteLine(foundItem1 != null ? "Found Baldurs Gate 3!" : "Did not find Baldurs Gate 3");

//var peekingTopItem = stack.Peek();
//Console.WriteLine($"Peeking at the top item before popping: {peekingTopItem}");

//stack.Pop();
//stack.Pop();
//var bottomItem = stack.Pop();
//Console.WriteLine($"Last Item popped: {bottomItem}");

//var foundItem = stack.Where(x => x == "Baldurs Gate 3").FirstOrDefault();
//Console.WriteLine(foundItem != null ? "Found Baldurs Gate 3!" : "Did not find Baldurs Gate 3");

//for(int i = 0; i < 1000000000; i++)
//{
//    // Console.WriteLine("Pushed FO76");
//    stack.Push("Fallout76");
//}

Queue<string> queue = new();
queue.Enqueue("Evan");
queue.Enqueue("John");
queue.Enqueue("Steve");
queue.Enqueue("Kevin");

// Console.WriteLine(queue.Peek());
//queue.Dequeue();
//queue.Dequeue();
//queue.Dequeue();

Console.WriteLine(queue.Contains("Kevin"));

Console.ReadLine();