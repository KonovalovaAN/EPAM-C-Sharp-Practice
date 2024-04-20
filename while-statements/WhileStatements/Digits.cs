namespace WhileStatements
{
    public static class Digits
    {
        public static ulong GetDigitsSum(ulong n)
        {
            ulong sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }

            return sum;
        }

        public static ulong GetDigitsProduct(ulong n)
        {
            ulong result = n % 10;
            n /= 10;
            while (n > 0)
            {
                result *= n % 10;
                n /= 10;
            }

            return result;
        }
    }
}
