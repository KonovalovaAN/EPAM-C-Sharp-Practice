namespace IfStatements
{
    public static class Task12
    {
        public static int DoSomething(int i)
        {
            if (i == 0 || i == 1)
            {
                return 0;
            }

            if (i == 2)
            {
                return 2;
            }

            if (i == 3)
            {
                return 6;
            }

            if (i == 4)
            {
                return 12;
            }

            if (i >= 5 && i <= 9)
            {
                return i;
            }

            if (i == 10)
            {
                return -100;
            }

            if (i <= -1 && i >= -5)
            {
                return i * (i - 1);
            }

            if (i <= -6 && i >= -8)
            {
                return i;
            }

            if (i == -9 || i == -10)
            {
                return i * i;
            }

            return 0;
        }
    }
}
