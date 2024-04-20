namespace ForStatements
{
    public static class ArithmeticSequences
    {
        public static int SumArithmeticSequenceTerms1(int a, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a + i;
            }

            return sum;
        }

        public static int SumArithmeticSequenceTerms2(int n)
        {
            const int FirstTerm = 47;
            const int CommonDifference = 13;

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int term = FirstTerm + (i * CommonDifference);
                sum += term;
            }

            return sum;
        }

        public static int SumArithmeticSequenceTerms3(int a, int n)
        {
            const int commonDifference = 5;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += a + (i * commonDifference);
            }

            return sum;
        }
    }
}
