namespace WhilePractice
{
    public static class Task6
    {
        /// <summary>
        /// Calculate the following sum
        /// -1/3 + 1/5 - 1/7 + ... + (-1)^n / (2 * n + 1), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double SumSequenceElements(int n)
        {
            double i = 1;
            double result = 0;
            while (i < n + 1)
            {
                if (i % 2 == 0)
                {
                    result += 1 / ((2 * i) + 1);
                }
                else
                {
                    result += -1 / ((2 * i) + 1);
                }

                i++;
            }

            return result;
        }
    }
}
