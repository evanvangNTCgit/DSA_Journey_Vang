////walk(5);
////Console.WriteLine();
////walkRecursive(5);

////Console.WriteLine(factorial(7));
//Console.WriteLine(power(2,8));

//// Iteration, the repetition of an internal process
//static void walk(int steps)
//{
//    for (int i = 0; i < steps; i++)
//    {
//        Console.WriteLine("You took a step. ITERATIVELY");
//    }
//}

//// Recursion, (recursive method) calls itself, can be a substitute for iteration
//// dividing a problem into sub-problems of the same type as the original.
//static void walkRecursive(int steps)
//{
//    // In recursion (explaining why it takes more memory)
//    /*
//     * We are adding the same method with a different parameter value passed in
//     * to the call stack of our program. 
//     * Compared to just the iterative approach of giving this funciton 5 and looping a for-loop.
//     * Hence more memory, and potentially a slower program.
//     */

//    if (steps < 1) return;
//    Console.WriteLine("You took a step. RECURSIVELY");
//    walkRecursive(steps - 1);
//}

//static int factorial(int number)
//{
//    if (number < 1) return 1;

//    return number * factorial(number - 1);
//}

//static int power(int basenum, int exponent)
//{
//    if (exponent < 1) return 1; // base case.

//    return basenum * power(basenum, exponent - 1); // recursive case.
//}
// -------------------------------------------------------------------------

//List<int> numbers = new List<int> { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
//var numbersToSort = numbers.ToArray();

//mergeSort(numbersToSort);

//foreach (var item in numbersToSort)
//{
//    Console.WriteLine(item);
//}

//static void mergeSort(int[] numbersToSort)
//{
//    int length = numbersToSort.Length;
//    if (length <= 1) return; // base case.

//    int middle = length / 2;
//    int[] leftArray = new int[middle];
//    int[] rightArray = new int[length - middle];

//    int i = 0; // left array
//    int j = 0; // right array

//    for (; i < length; i++)
//    {
//        if (i < middle)
//        {
//            leftArray[i] = numbersToSort[i];
//        }
//        else
//        {
//            rightArray[j] = numbersToSort[i];
//            j++;
//        }
//    }
//    mergeSort(leftArray);
//    mergeSort(rightArray);
//    merge(leftArray, rightArray, numbersToSort);
//}

//static void merge(int[] leftArray, int[] rightArray, int[] array)
//{
//    int leftSize = array.Length / 2;
//    int rightSize = array.Length - leftSize;
//    int i = 0, l = 0, r = 0; // indices

//    // check conditions for merging.
//    while (l < leftSize && r < rightSize)
//    {
//        if (leftArray[l] < rightArray[r])
//        {
//            array[i] = leftArray[l];
//            i++;
//            l++;
//        }
//        else
//        {
//            array[i] = rightArray[r];
//            i++;
//            r++;
//        }
//    }
//    while (l < leftSize)
//    {
//        array[i] = leftArray[l];
//        i++;
//        l++;
//    }
//    while (r < rightSize)
//    {
//        array[i] = rightArray[r];
//        i++;
//        r++;
//    }
//}

//-----------------------------------------------------------------------

int[] numbersToSort = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0, 10 };

quickSort(numbersToSort, 0, numbersToSort.Length - 1);

Console.WriteLine("Sorted!\n");
foreach (var item in numbersToSort)
{
    Console.WriteLine(item);
}

static void quickSort(int[] array, int beginning, int ending)
{
    if (ending <= beginning) return; // base case.

    int pivot = partition(array, beginning, ending);

    quickSort(array, beginning, pivot - 1);
    quickSort(array, pivot + 1, ending);
}

static int partition(int[] array, int beginning, int ending)
{
    int pivot = array[ending];
    int i = beginning - 1;

    for (int j = beginning; j <= ending - 1; j++)
    {
        if (array[j] < pivot)
        {
            i++;

            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
    i++;
    int swap = array[i];
    array[i] = array[ending];
    array[ending] = swap;

    return i;
}