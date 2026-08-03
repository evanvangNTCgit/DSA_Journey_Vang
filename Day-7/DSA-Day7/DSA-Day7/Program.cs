List<int> numbers = new List<int> { 5, 9, 8, 7, 3, 2, 1 };
var numbersToSort = numbers.ToArray();

insertionSort(numbersToSort);

Console.WriteLine("Sorted!\n");
foreach (var item in numbersToSort)
{
    Console.WriteLine(item);
}

static void insertionSort(int[] numbers)
{
    for(int i = 1; i < numbers.Length; i++)
    {
        int temp = numbers[i];
        int j = i - 1;

        while(j >= 0 && numbers[j] > temp)
        {
            numbers[j + 1] = numbers[j];
            j--;
        }

        numbers[j + 1] = temp;
    }
};