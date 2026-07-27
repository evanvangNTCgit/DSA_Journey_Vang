//List<int> numbers = new() { 10, 8, 9, 7, 6, 4, 5, 3, 2, 1 };
//var numbersToSort = numbers.ToArray();

//Console.WriteLine("Un-Sorted...");
//foreach (var item in numbersToSort)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine("Sorting....");
//Console.WriteLine();
//bubbleSort(numbersToSort);
//foreach (var item in numbersToSort)
//{
//    Console.WriteLine(item);
//}

//static void bubbleSort(int[] listOfInts)
//{
//    for (int i = 0; i < listOfInts.Length - 1; i++)
//    {
//        for (int j = 0; j < listOfInts.Length - i - 1; j++)
//        {
//            if (listOfInts[j] > listOfInts[j + 1])
//            {
//                int temp = listOfInts[j];
//                listOfInts[j] = listOfInts[j + 1];
//                listOfInts[j + 1] = temp;
//            }
//        }
//    }
//}

List<int> numbers = new() { 10, 8, 9, 7, 6, 4, 5, 3, 2, 1 };
var numbersToSort = numbers.ToArray();

selectionSort(numbersToSort);

foreach (var item in numbersToSort)
{
    Console.WriteLine(item);
}

static void selectionSort(int[] intsToSort)
{
    for (int i = 0; i < intsToSort.Length - 1; i++)
    {
        int min = i;
        for(int j = i + 1; j < intsToSort.Length; j++)
        {
            if (intsToSort[min] > intsToSort[j])
            {
                min = j;
            }
        }
        //int temp = intsToSort[i];
        //intsToSort[i] = intsToSort[min];
        //intsToSort[min] = temp;

        // https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/ide0180
        (intsToSort[i], intsToSort[min]) = (intsToSort[min], intsToSort[i]);
    }
}