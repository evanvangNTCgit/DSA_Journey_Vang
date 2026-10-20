namespace LeetCodeVang
{
    public static class ContainerWithMostWater
    {
        public static void Main(string[] args)
        {
            var test = MaxArea([2, 2, 2]);
            Console.WriteLine(test);
            Console.ReadLine();
        }

        /*
         * Given an integer array heights. 
         * Where heights[i]] repsents the height of i'th bar
         * Choose two bars that form the container to store the maximum amount of water.
         * 
         * EX:
         * Input: height = [1,7,2,5,4,7,3,6]
         * Output: 36
         * indices 1,7 = 7 and 6, the width (7-1) = 6.
         * thus 6(shortest tower) * 6(width) = 36
         */
        public static int MaxArea(int[] heights)
        {
            int l = 0;
            int r = heights.Length - 1;
            int width = heights.Length - 1;

            int mostHeight = 0;

            // So for using two pointers we want to decrement the pointer
            // Who points at the shorter tower
            // Since we want the taller tower no matter what.

            while (l < r)
            {
                int leftTower = heights[l];
                int rightTower = heights[r];

                // First find width
                // Determined by shortest tower multiplied by width...
                if (leftTower < rightTower)
                {
                    int area = leftTower * width;
                    mostHeight = area > mostHeight ? area : mostHeight;

                    if (l + 1 < heights.Length)
                        l++;
                }
                else if (rightTower < leftTower)
                {
                    int area = rightTower * width;
                    mostHeight = area > mostHeight ? area : mostHeight;

                    if (r - 1 >= 0)
                        r--;
                }
                // Right tower == left Tower
                else
                {
                    int area = rightTower * width;
                    mostHeight = area > mostHeight ? area : mostHeight;

                    // Decrement the one with the tallest one next to it..
                    if (heights[l + 1] > heights[r - 1])
                    {
                        if (l + 1 < heights.Length)
                            l++;
                    }
                    else
                    {
                        if (r - 1 >= 0)
                            r--;
                    }
                }
                width--;
            }

            return mostHeight;
        }
    }
}
