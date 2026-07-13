//using System.Diagnostics;

//List<int> numbers = new();

//for (int i = 100; i <= 12345678; i+= 500)
//{
//    numbers.Add(i);
//    Console.WriteLine($"Please wait... {(decimal)i / (decimal)999999999}");
//    Console.SetCursorPosition(0, 0);
//}

//var numbersArr = numbers.ToArray();
//Console.Clear();

//int target = 1345678;

//var sw = Stopwatch.StartNew();

//int index = BinarySearch(numbersArr, target);

//sw.Stop();

//if (index != -1)
//    Console.WriteLine($"Found {target} at index {index}");
//else
//    Console.WriteLine($"Did not find {target}");

//Console.WriteLine($"The binary search took: {sw.Elapsed.TotalMilliseconds} ms");

//sw.Restart();

//var test = numbersArr.IndexOf(444);

//sw.Stop();

//if (test != -1)
//    Console.WriteLine($"Found 444");

//Console.WriteLine($"The indexOf() method took: {sw.Elapsed.TotalMilliseconds} ms");


//sw.Restart();

//var testing = LinearSearchVang(numbersArr, target);

//sw.Stop();

//if (testing != -1)
//    Console.WriteLine($"Found 444 with vang linear search method.");

//Console.WriteLine($"The vang linear search method took: {sw.Elapsed.TotalMilliseconds} ms");

//static int BinarySearch(int[] numbers, int target)
//{
//    int low = 0;
//    int high = numbers.Length - 1;

//    while (low <= high)
//    {
//        int mid = low + (high - low) / 2;
//        int value = numbers[mid];

//        if (value < target)
//        {
//            low = mid + 1;
//        }
//        else if (value > target)
//        {
//            high = mid - 1;
//        }
//        else
//        {
//            return mid; // THE TARGET
//        }
//    }

//    return -1;
//}

//static int LinearSearchVang(int[] numbers, int target)
//{
//    for (int i = 0; i < numbers.Length - 1; i++)
//    {
//        if (numbers[i] == target)
//            return i;

//    }

//    return -1;
//}

List<int> numbers = new();
int target = 222;

for (int i = 0; i <= 1000; i++)
{
    if (i == 200)
    {
        numbers.Add(target);
        continue;
    }

    Random random = new();
    int randomNum = random.Next(10, 1000);

    if(randomNum != target)
    numbers.Add(randomNum);
}

numbers.Sort();
var numbersArr = numbers.ToArray();


int index = interpolationSerach(numbersArr, target);
if (index != -1)
    Console.WriteLine($"Found {target} at index {index}");
else
    Console.WriteLine($"Did not find {target}");

static int interpolationSerach(int[] array, int value)
{
    int high = array.Length - 1;
    int low = 0;

    while (value >= array[low] && value <= array[high] && low <= high)
    {
        int probe = low + (high - low) * (value - array[low]) / (array[high] - array[low]);

        Console.WriteLine($"Probe: {probe}");

        if (array[probe] == value)
        {
            return probe;
        }
        else if (array[probe] < value)
        {
            low = probe + 1;
        }
        else
        {
            high = probe - 1;
        }
    }

    return -1;
}

Console.ReadLine();