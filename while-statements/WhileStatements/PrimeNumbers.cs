namespace WhileStatements
{
    public static class PrimeNumbers
    {
        public static bool IsPrimeNumber(uint n)
        {
            if (n == 1 || n == uint.MinValue)
            {
                return false;
            }

            uint i = 2;
            while (i < n)
            {
                if (n % i == 0)
                {
                    return false;
                }

                i++;
            }

            return true;
        }

        public static uint GetLastPrimeNumber(uint n)
        {
            if (n == 1)
            {
                return 0;
            }

            while (n > 0)
            {
                bool flag = true;
                uint j = 2;
                while (j < n)
                {
                    if (n % j == 0)
                    {
                        flag = false;
                    }

                    j++;
                }

                if (flag)
                {
                    return n;
                }

                n--;
            }

            return 0;
        }

        public static uint SumLastPrimeNumbers(uint n, uint count)
        {
            if (n == 1 && count == 1)
            {
                return 0;
            }

            uint sum = 0;
            while (n > 0 && count != 0)
            {
                bool flag = true;
                uint j = 2;
                while (j < n)
                {
                    if (n % j == 0)
                    {
                        flag = false;
                    }

                    j++;
                }

                if (flag)
                {
                    sum += n;
                    count--;
                }

                n--;
            }

            return sum;
        }
    }
}
