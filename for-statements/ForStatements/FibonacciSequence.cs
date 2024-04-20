namespace ForStatements
{
    public static class FibonacciSequence
    {
        public static int GetFibonacciNumber(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }

            int prev = 0;
            int current = 1;

            for (int i = 2; i <= n; i++)
            {
                int temp = current;
                current += prev;
                prev = temp;
            }

            return current;
        }

        public static ulong GetProductOfFibonacciNumberDigits(ulong n)
        {
            int fibonacciNumber = GetFibonacciNumber((int)n);
            ulong product = 1;

            if (fibonacciNumber == 0)
            {
                return 0;
            }

            while (fibonacciNumber > 0)
            {
                int digit = fibonacciNumber % 10;
                product *= (ulong)digit;
                fibonacciNumber /= 10;
            }

            return product;
        }
    }
}
