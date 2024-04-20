namespace ForStatements
{
    public static class PrimeNumbers
    {
        public static bool IsPrimeNumber(uint n)
        {
            // Check if n is a prime number
            if (n <= 1)
            {
                return false;
            }

            for (uint i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static ulong SumDigitsOfPrimeNumbers(int start, int end)
        {
            // Calculate the sum of digits of all prime numbers in the [start, end] interval
            ulong sum = 0;
            for (int number = start; number <= end; number++)
            {
                if (IsPrimeNumber((uint)number))
                {
                    sum += SumDigits((ulong)Math.Abs(number));
                }
            }

            return sum;
        }

        private static ulong SumDigits(ulong number)
        {
            // Calculate the sum of digits in a number
            ulong sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}
