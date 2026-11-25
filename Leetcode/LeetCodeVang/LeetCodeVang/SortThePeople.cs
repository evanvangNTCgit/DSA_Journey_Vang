namespace LeetCodeVang
{
    public static class SortThePeople
    {
        public static void Main(string[] args)
        {
            SortPeople(["Mary", "John", "Emma"], [180, 165, 170]);
        }

        public static string[] SortPeople(string[] names, int[] heights)
        {
            for (int i = 0; i < heights.Length; i++)
            {
                for (int j = i + 1; j < heights.Length; j++)
                {
                    if (heights[i] < heights[j])
                    {
                        var temp = heights[j];
                        heights[j] = heights[i];
                        heights[i] = temp;

                        var nameTemp = names[j];
                        names[j] = names[i];
                        names[i] = nameTemp;
                    }
                }
            }

            return names;
        }
    }
}
