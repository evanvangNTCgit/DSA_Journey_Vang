
// Systems.collections.generic
// Stores elements according to some sort of priority.
// Greater priority are removed from queue before lesser priority.
//PriorityQueue<string, int> pq = new();
//Console.WriteLine("!QUICK WE MUST DEAL WITH THESE PATIENTS EFFICIENTLY!");
//pq.Enqueue("Evan, broken hand", 99);
//pq.Enqueue("John, Heart Attack", 1);
//pq.Enqueue("Jane, Heat Stroke", 3);
//pq.Enqueue("Jillian, Heavy Bleeding", 2);

//while(pq.Count > 0)
//{
//    var elem = pq.TryDequeue(out string? person, out int priority);

//    if(person != null)
//    Console.WriteLine($"Dequeued {person}, Priority {priority}");
//}

// By default is doubly linked list.
// Every node knows the previous and next nodes. Again using memory locations (or references in High-level languages)
LinkedList<string> linkedList = new();

linkedList.AddFirst("A");
linkedList.AddFirst("B");
linkedList.AddFirst("C");
linkedList.AddFirst("E");

//var test = linkedList.First();
//linkedList.RemoveFirst();
//Console.WriteLine(test);

// The beauty of linked lists here.
// Say there is now a 2.0 version of B but the original B is still here.
// We can just...
LinkedListNode<string>? node = linkedList.Find("C");

if (node != null)
    linkedList.AddBefore(node, "D");

Console.WriteLine();
Console.WriteLine($"Looking for E.");
try
{
    Console.WriteLine($"{linkedList.Find("E")?.Value} Found!");
}
catch { }

Console.WriteLine("\n\nNow peeking at the top and bottom of the same list!");
Console.WriteLine($"At the top of our list... {linkedList.First?.Value}");
Console.WriteLine($"At the bottom of our list... {linkedList.Last?.Value}");

Console.WriteLine("\nSee how its not removed...");
foreach (var item in linkedList)
{
    Console.Write($"{item}, ");
}
Console.WriteLine("------------------------");

Console.WriteLine("Adding Evan to the top...");
linkedList.AddFirst("Evan");
foreach (var item in linkedList)
{
    Console.Write($"{item}, ");
}
Console.WriteLine("----------------------");

Console.WriteLine("Removing Evan from the top...");
linkedList.RemoveFirst();
foreach (var item in linkedList)
{
    Console.Write($"{item}, ");
}
Console.WriteLine();


Console.ReadLine();

// Linked lists last bit of notes.

/**
 * A data structure storing nodes in 2 parts (data + address)
 * Nodes are in non-consecutive memory locations
 * Elements are linked together using pointers/references
 * 
 * Singly linked list
 * (data | address to the next)
 * 
 * 
 * Doubly linked list
 * REQUIRES MORE MEMORY
 * (address to previous node | data | address to next node)
 * 
 * Advantages:
 * 1. Allocates memory while running
 * 2. Insertion and deletion are easy 0(1) time.
 * 3. No/Low memory waste.
 * 
 * Disadvantages:
 * 1. Takes way longer to find something (NO INDEXING, REQUIRES YOU TO SEARCH ONE BY ONE 0(1) LINEAR)
 * 2. Requires more memory (per element) since you store address(es)
 */