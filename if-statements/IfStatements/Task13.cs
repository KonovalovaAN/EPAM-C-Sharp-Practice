namespace IfStatements
{
    public static class Task13
    {
        public static int DoSomething(bool b, int i)
        {
            bool tmpB = b;
            int tmpI = i;
            if (tmpI == 0)
            {
                return 10;
            }

            if (tmpB)
            {
                if (tmpI > 0 && tmpI < 4)
                {
                    return tmpI - 5;
                }

                if ((tmpI < 0 && tmpI > -5) || tmpI == -10 || tmpI == -9)
                {
                    return tmpI + 5;
                }

                if (tmpI > -9 && tmpI < -4)
                {
                    return tmpI;
                }

                return -tmpI;
            }
            else
            {
                if ((tmpI > 5 && tmpI < 11) || (tmpI > -11 && tmpI < -4))
                {
                    return -tmpI;
                }

                if (tmpI > 0 && tmpI < 5)
                {
                    return 10 - tmpI;
                }

                if (tmpI > -6 && tmpI < 0)
                {
                    return 10 - tmpI;
                }

                return tmpI;
            }
        }
    }
}
