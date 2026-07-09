// In C# List<T> is a dynamic array
// List<T> defines the array size at run-time.
//List<string> dynamicArray = new();
//Console.WriteLine(dynamicArray.Capacity);



/**
 * In C# the dynamic array starts off at 0 (if you instantiate with nothing)
 * Likely to consume as little memory as possible
 * Then when you add the first element its capacity is set to 0
 * When you fill all 4 capacity slots up the capacity is doubled
 * So you add four people to the array, the capacity is now 8,
 * Fill all 8 then 16, so on...
 *//**
 * ------------------------------------------------------
 * Array lists vs linked lists
 * ------------------------------------------------------
 */
LinkedList<int> linkedList = new();
List<int> list = new();

TimeOnly startTime;
TimeOnly endTime;
TimeSpan elapsedTime;

for (int i = 0; i < 100000; i++)
{
    linkedList.AddFirst(i);
    list.Add(i);

    Console.SetCursorPosition(0, 0);
    Console.Write($"Currently at {Math.Round((decimal)i / (decimal)100000, 2)}%");
}
Console.WriteLine("\n-------------------------------------");


// Linked list.
startTime = TimeOnly.FromDateTime(DateTime.Now);
//-------------------------------

// var linkedsearch = linkedList.Find(0); Linked list lost the search to array list.
// var linkedHalf = linkedList.Find(50000); The most shocking, took way slower than an array list.
//var linkedLast = linkedList.Find(100000); Lost yet again to an array list in searching.

// linkedList.Remove(0); Very surprisingly the array list won.
// linkedList.Remove(50000); Array list won.
// linkedList.Remove(99999); Array list won 

//-------------------------------
endTime = TimeOnly.FromDateTime(DateTime.Now);
elapsedTime = endTime - startTime;

Console.WriteLine($"LinkedList: {elapsedTime}");


// Arraylist.
startTime = TimeOnly.FromDateTime(DateTime.Now);
//-------------------------------

// var arraySearch = list.Find(x => x == 0); Array list won the search against linked list.
//var arrayHalf = list.Find(x => x == 50000); Array list won again against linked list.
//var arrayEnd = list.Find(x => x == 100000); Array list won yet again in searching.

// list.Remove(0); Very surprisingly array list won.
// list.Remove(50000); Array list won again.
// list.Remove(99999); Array list won.

//-------------------------------
endTime = TimeOnly.FromDateTime(DateTime.Now);
elapsedTime = endTime - startTime;

Console.WriteLine($"Array List: {elapsedTime}");

Console.ReadLine();