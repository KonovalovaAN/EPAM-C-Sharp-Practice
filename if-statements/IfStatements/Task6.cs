namespace IfStatements
{
    public static class Task6
    {
        public static int DoSomething(int i)
        {
            if (i == 0 || i == 1)
            {
                return 0;
            }

            if (i == 2)
            {
                return -2;
            }

            if (i == 3)
            {
                return -6;
            }

            if (i >= 4 && i <= 10)
            {
                return i;
            }

            if (i <= -1 && i >= -3)
            {
                return i * 3;
            }

            if (i >= -10 && i <= -4)
            {
                return i;
            }

            return 0;
        }
    }
}
