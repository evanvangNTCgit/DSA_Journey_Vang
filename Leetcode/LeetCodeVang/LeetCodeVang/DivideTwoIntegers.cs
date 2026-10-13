namespace LeetCodeVang
{
    public static class DivideTwoIntegers
    {
        public static void Main(string[] args)
        {
            var test = Divide(-2147483648, 2);
            Console.WriteLine(test);
        }

        // GIven two integers a divident and divisor.
        // Divide two integers WITHOUT multiplicaiton, division, and mod operator

        // Integer should truncate toward zero, meaning total loss of fractional part.
        // 8.345 => 8, -2.79 ==> -2

        // Return quotient after dividing divident by divisor.
        // Constraint DIVISOR IS NEVER 0.
        public static int Divide(int dividend, int divisor)
        {
            //// base case(s)
            //if (divisor == 1) return dividend;
            //if (divisor == -1)
            //{
            //    if (dividend <= int.MinValue)
            //        dividend = int.MinValue + 1;

            //    return -dividend;
            //}
            //if (dividend == divisor)
            //    return 1;

            //bool negativeDivisor = divisor < 0;
            //bool negativeDivident = dividend < 0;
            //int quotient = 0;
            //if (negativeDivisor)
            //{
            //    while ((Math.Abs(dividend) >= (Math.Abs(divisor))))
            //    {
            //        dividend -= Math.Abs(divisor);
            //        quotient++;
            //    }

            //    if (negativeDivident) {
            //        // return quotient;
            //    } else
            //    {
            //        quotient = -quotient;
            //    }
            //}
            //else // positive divisor.
            //{
            //    while (Math.Abs(dividend) >= Math.Abs(divisor))
            //    {
            //        dividend -= (divisor);
            //        quotient++;
            //    }

            //    if (negativeDivident)
            //        quotient = -quotient;
            //}


            //// If quotient greater than 2^31 - 1, return 2^31 - 1;
            //// if the quotient is strictly less than -2^31, then return -2^31.
            //if (quotient >= (int.MaxValue - 1))
            //    return int.MaxValue - 1;
            //if (quotient <= int.MinValue)
            //    return int.MinValue;

            //return quotient;

            return 0;
        }
    }
}
