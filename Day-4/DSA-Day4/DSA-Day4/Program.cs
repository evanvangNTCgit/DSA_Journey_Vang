// NOTICE how this array did not need to be at all sorted.
// Linear will start from the top (or bottom if desired) and check each one by one.
using System.Diagnostics;

List<int> initialArray = new();

int numsToAdd = 555555;
for (int i = 0; i < numsToAdd; i++)
{
    Console.SetCursorPosition(0, 0);
    Console.Write($"Wait {(decimal)i / (decimal)numsToAdd}%");
    initialArray.Add(i);
}

var array = initialArray.ToArray();
Console.WriteLine("\n");

Console.WriteLine("Linear Search Algorithm");

var stopwatch = Stopwatch.StartNew();

var lineartest = linearSearch(array, 2);
var lineartesting = linearSearch(array, 500000);

stopwatch.Stop();
var duration = stopwatch.Elapsed;

if (lineartest != -1)
    Console.WriteLine($"Found 2! {lineartest}");
else
    Console.WriteLine("Did not find 2");

if (lineartesting != -1)
    Console.WriteLine($"Found 500000! {lineartesting}");
else
    Console.WriteLine("Did not find 500000");

Console.WriteLine($"Duration for the linear search {duration}");

// -------------------------------------------------------------------------------

Console.WriteLine("--------------------------------------------------\nEvans Two way algorithm.");

stopwatch.Restart();

var test = evanTwoWaySearch(array, 2);
var testing = evanTwoWaySearch(array, 500000);

if (test != -1)
    Console.WriteLine($"Found 2! {test}");
else
    Console.WriteLine("Did not find 2");

if (testing != -1)
    Console.WriteLine($"Found 500000! {testing}");
else
    Console.WriteLine("Did not find 500000");

duration = stopwatch.Elapsed;

Console.WriteLine($"Duration for Evans algorithm {duration}");

static int linearSearch(int[] array, int searchValue)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == searchValue)
            return i;
    }

    return -1;
}

// Well here is something I thought about to (I think cut in half?) just search from bottom and top!
static int evanTwoWaySearch(int[] array, int searchValue)
{
    // Search result.
    int found = int.MinValue;

    // Get the top of the array
    int top = 0;

    // Bottom of array.
    int bottom = array.Length - 1;

    // Now work in two ways.
    while (found == int.MinValue && (bottom >= top))
    {
        if (array[top] == searchValue)
            return top;
        else
            top++;

        if (array[bottom] == searchValue)
            return bottom;
        else
            bottom--;
    }

    // Okay while ran and did not find it...
    return -1;
}