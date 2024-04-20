namespace ForStatements
{
    public static class QuadraticSequences
    {
        public static uint CountQuadraticSequenceTerms(long a, long b, long c, long maxTerm)
        {
            // Count the number of quadratic sequence terms that are less than or equal to the maxTerm
            uint count = 0;
            for (long n = 1; n <= maxTerm; n++)
            {
                long term = (a * n * n) + (b * n) + c;
                if (term <= maxTerm)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }

        public static ulong GetQuadraticSequenceTermsProduct1(uint count)
        {
            ulong product = 1;

            for (uint i = 0; i < count; i++)
            {
                ulong term = (7 * (i + 1) * (i + 1)) + (4 * (i + 1)) + 2;
                product *= term;
            }

            return product;
        }

        public static ulong GetQuadraticSequenceProduct2(long a, long b, long c, long startN, long count)
        {
            // Calculate the product of count quadratic sequence terms starting with the startN term
            ulong product = 1;
            long term = (a * startN * startN) + (b * startN) + c;
            for (long i = 0; i < count; i++)
            {
                if (i != 0)
                {
                    term = (a * (startN + i) * (startN + i)) + (b * (startN + i)) + c;
                }

                product *= (ulong)term;
            }

            return product;
        }
    }
}
