namespace ForStatements
{
    public static class Factorial
    {
        public static int GetFactorial(int n)
        {
            // Factorial calculation using a for loop
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static int SumFactorialDigits(int n)
        {
            // Factorial calculation using a for loop and summing the digits
            int factorial = GetFactorial(n);
            int sum = 0;
            while (factorial > 0)
            {
                sum += factorial % 10;
                factorial /= 10;
            }

            return sum;
        }
    }
}
