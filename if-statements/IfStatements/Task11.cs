using System.Runtime.InteropServices;

namespace IfStatements
{
    public static class Task11
    {
        public static int DoSomething(bool b1, bool b2, int i)
        {
            if (b1 && b2)
            {
                if (i == 0)
                {
                    return 1;
                }

                if (i >= 1 && i <= 3)
                {
                    return i;
                }

                if (i >= 4 && i <= 7)
                {
                    return 2 * i;
                }

                if (i >= 8 && i <= 10)
                {
                    return i;
                }

                if (i <= -1 && i >= -4)
                {
                    return i;
                }

                if (i <= -5 && i >= -8)
                {
                    return 3 * i;
                }

                if (i == -9 || i == -10)
                {
                    return i;
                }
            }

            if (b1 && b2 is false)
            {
                if (i == 0)
                {
                    return -1;
                }

                if (i >= 1 && i <= 3)
                {
                    return i;
                }

                if (i >= 4 && i <= 7)
                {
                    return (5 - i) * 2;
                }

                if (i >= 8 && i <= 10)
                {
                    return i;
                }

                if (i == -1 || i == -2)
                {
                    return i;
                }

                if (i == -3)
                {
                    return 1;
                }

                if (i <= -4 && i >= -6)
                {
                    return -2 - (3 * (-4 - i));
                }

                if (i <= -7 && i >= -10)
                {
                    return i;
                }
            }

            if (b1 is false && b2)
            {
                if (i == 0)
                {
                    return 1;
                }

                if (i == 1)
                {
                    return 0;
                }

                if (i == 2)
                {
                    return -4;
                }

                if (i == 3)
                {
                    return -18;
                }

                if (i == 4)
                {
                    return -48;
                }

                if (i >= 5 && i <= 7)
                {
                    return i;
                }

                if (i >= 8 && i <= 10)
                {
                    return -i * (i - 1);
                }

                if (i == -1)
                {
                    return 2;
                }

                if (i == -2)
                {
                    return 12;
                }

                if (i == -3)
                {
                    return 36;
                }

                if (i <= -4 && i >= -8)
                {
                    return i;
                }

                if (i == -9 || i == -10)
                {
                    return -i * (i - 1);
                }
            }

            if (i == 10)
            {
                return -990;
            }

            if (i == 0)
            {
                return 1;
            }

            if (i == 2)
            {
                return 4;
            }

            if (i >= 3 && i <= 7)
            {
                return i;
            }

            if (i >= 8 && i < 10)
            {
                return -i * (i - 1) * (i + 1);
            }

            if (i == -1)
            {
                return -2;
            }

            if (i == -2)
            {
                return -12;
            }

            if (i == -3)
            {
                return -36;
            }

            if (i <= -4 && i >= -6)
            {
                return i;
            }

            if (i <= -7 && i >= -10)
            {
                return -i * (-i + 1) * (-i - 1);
            }

            return 0;
        }
    }
}
