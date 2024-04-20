namespace IfStatements
{
    public static class Task10
    {
        public static int DoSomething(bool b1, bool b2, int i)
        {
            if (b1 && b2)
            {
                if (i == 0)
                {
                    return -1;
                }

                if (i == 1 || i == 10 || i == -1 || i == -10)
                {
                    return i;
                }

                if (i >= 2 && i <= 9)
                {
                    return 10 - i;
                }

                if (i <= -2 && i >= -9)
                {
                    return i + 5;
                }
            }

            if (b1 && b2 is false)
            {
                if (i == 0)
                {
                    return -1;
                }

                if (i == 1)
                {
                    return 1;
                }

                if (i >= 2 && i <= 9)
                {
                    return i + 10;
                }

                if (i == 10 || i == -1 || i == -10)
                {
                    return i;
                }

                if (i <= -2 && i >= -9)
                {
                    return 5 - i;
                }
            }

            if (b1 is false && b2)
            {
                if (i == 0)
                {
                    return 1;
                }

                if ((i >= 1 && i <= 4) || (i <= -1 && i >= -4))
                {
                    return i + 10;
                }

                if ((i >= 5 && i <= 9) || (i <= -5 && i >= -9))
                {
                    return i;
                }

                if (i == 10)
                {
                    return 11;
                }

                if (i == -10)
                {
                    return -9;
                }
            }

            if (i == -10)
            {
                return -11;
            }

            if (i == 0)
            {
                return -1;
            }

            if (i >= 1 && i <= 4)
            {
                return i - 10;
            }

            if ((i >= 5 && i <= 9) || (i <= -5 && i >= -9))
            {
                return i;
            }

            if (i == 10)
            {
                return 9;
            }

            if (i <= -1 && i >= -4)
            {
                return i - 10;
            }

            return 0;
        }
    }
}
