namespace ForStatements
{
    public static class GeometricSequences
    {
        public static ulong GetGeometricSequenceTermsProduct(uint a, uint r, uint n)
        {
            ulong product = 1;

            for (int i = 1; i <= n; i++)
            {
                ulong term = a * (ulong)Math.Pow(r, i - 1);
                product *= term;
            }

            return product;
        }

        public static ulong SumGeometricSequenceTerms(uint n)
        {
            // Sum of geometric sequence terms calculation when the first term is 5 and the common ratio is 3
            ulong sum = 0;
            uint a = 5; // first term
            uint r = 3; // common ratio
            ulong term = a;
            for (uint i = 0; i < n; i++)
            {
                sum += term;
                term *= r;
            }

            return sum;
        }

        public static ulong CountGeometricSequenceTerms1(uint a, uint r, uint maxTerm)
        {
            // Count of terms in a geometric sequence that are less than or equal to the maxTerm
            ulong count = 0;
            uint term = a;
            while (term <= maxTerm)
            {
                count++;
                term *= r;
            }

            return count;
        }

        public static ulong CountGeometricSequenceTerms2(uint a, uint r, uint n, uint minTerm)
        {
            // Count of terms in a geometric sequence that are greater than or equal to the minTerm
            ulong count = 0;
            uint term = a;
            for (uint i = 0; i < n; i++)
            {
                if (term >= minTerm)
                {
                    count++;
                }

                term *= r;
            }

            return count;
        }
    }
}
