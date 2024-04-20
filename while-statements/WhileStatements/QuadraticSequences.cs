namespace WhileStatements
{
    public static class QuadraticSequences
    {
        public static long SumQuadraticSequenceTerms1(long a, long b, long c, long maxTerm)
        {
            int sum = 0;
            int i = 1;
            int term = 0;
            while (term <= maxTerm)
            {
                term = (int)((a * i * i) + (b * i) + c);
                if (term <= maxTerm)
                {
                    sum += term;
                }

                i++;
            }

            return sum;
        }

        public static long SumQuadraticSequenceTerms2(long a, long b, long c, long startN, long count)
        {
            long sum = 0;
            int i = 0;
            while (i < count)
            {
                sum += (a * (i + startN) * (i + startN)) + (b * (i + startN)) + c;
                i++;
            }

            return sum;
        }
    }
}
