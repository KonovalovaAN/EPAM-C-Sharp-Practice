namespace IfStatements
{
    public static class Task5
    {
        public static int DoSomething(int i)
        {
            if (i == 0)
            {
                return 0;
            }

            if (i >= 1 && i <= 5)
            {
                return i - 5;
            }

            if (i >= 6)
            {
                return i;
            }

            if (i >= -5 && i <= -1)
            {
                return i + 5;
            }

            if (i <= -6)
            {
                return i;
            }

            return 0;
        }
    }
}
