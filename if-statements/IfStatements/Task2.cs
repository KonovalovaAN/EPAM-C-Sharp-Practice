namespace IfStatements
{
    public static class Task2
    {
        public static int DoSomething1(int i)
        {
            if (i > 0)
            {
                return i;
            }

            if ((i < 0) && (i >= -5))
            {
                return -i;
            }

            if (i < -5)
            {
                return i * -i;
            }

            return 0;
        }

        public static int DoSomething2(int i)
        {
            if ((i < 0) && (i >= -5))
            {
                return -i;
            }

            if (i < -5)
            {
                return i * -i;
            }

            return i;
        }
    }
}
