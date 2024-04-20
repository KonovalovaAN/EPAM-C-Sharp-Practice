namespace IfStatements
{
    public static class Task7
    {
        public static int DoSomething(bool b, int i)
        {
            if (b && i >= 7 && i <= 10)
            {
                return i;
            }

            if (b && i <= -7 && i >= -10)
            {
                return i;
            }

            if (b)
            {
                return 7 - i;
            }

            if (true)
            {
                if ((i >= 0 && i <= 4) || (i <= -1 && i >= -4))
                {
                    return i;
                }

                if ((i >= 5 && i <= 10) || i <= -5)
                {
                    return i + 5;
                }
            }

            return 0;
        }
    }
}
