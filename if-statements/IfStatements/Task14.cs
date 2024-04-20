namespace IfStatements
{
    public static class Task14
    {
        public static int DoSomething(bool b1, bool b2, int i)
        {
            bool tmpB1 = b1;
            bool tmpB2 = b2;
            int tmpI = i;
            if (tmpB1)
            {
                if (tmpI == 0)
                {
                    return 0;
                }

                if (tmpB2)
                {
                    if ((tmpI > 0 && tmpI < 6) || (tmpI > -5 && tmpI < 0))
                    {
                        return -tmpI * 2;
                    }

                    if (tmpI == 6)
                    {
                        return -2;
                    }

                    if (tmpI == 7)
                    {
                        return -4;
                    }

                    if (tmpI == 8)
                    {
                        return -6;
                    }

                    if (tmpI == 9)
                    {
                        return -8;
                    }

                    if (tmpI == 10)
                    {
                        return -tmpI;
                    }

                    if (tmpI == -5)
                    {
                        return 20;
                    }

                    if (tmpI == -6)
                    {
                        return 22;
                    }

                    if (tmpI == -7)
                    {
                        return 24;
                    }

                    if (tmpI == -8)
                    {
                        return 26;
                    }

                    if (tmpI == -9)
                    {
                        return 28;
                    }

                    if (tmpI == -10)
                    {
                        return 30;
                    }

                    return tmpI;
                }
                else
                {
                    if (tmpI < 6 && tmpI > -5)
                    {
                        return tmpI * tmpI;
                    }
                    else
                    {
                        return tmpI * tmpI * tmpI;
                    }
                }
            }
            else
            {
                if (tmpI == 0)
                {
                    return 0;
                }

                if (tmpB2)
                {
                    if ((tmpI < 8 && tmpI > 0) || (tmpI < 0 && tmpI > -4) || tmpI == -8 || tmpI == -9)
                    {
                        return tmpI;
                    }

                    if (tmpI < -2 && tmpI > -8)
                    {
                        return tmpI * 10;
                    }

                    return -tmpI;
                }
                else
                {
                    if ((tmpI < 8 && tmpI > 4) || (tmpI < -3 && tmpI > -10))
                    {
                        return tmpI;
                    }

                    if ((tmpI < 0 && tmpI > -4) || (tmpI < 5 && tmpI > 0))
                    {
                        return -tmpI * 100;
                    }

                    return -tmpI;
                }
            }
        }
    }
}
