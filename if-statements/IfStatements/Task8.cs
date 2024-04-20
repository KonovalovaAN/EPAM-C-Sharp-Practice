namespace IfStatements
{
    public static class Task8
    {
        public static bool DoSomething(bool b, int i)
        {
            if (b && (i == -1 || i == -2 || i == -3 || i == 1 || i == 10 || i == 2 || i == 3 || (i >= 7 && i <= 9)))
            {
                return true;
            }

            if (b && i >= -7 && i <= -10)
            {
                return true;
            }

            if (i == 1 || i == 2)
            {
                return true;
            }

            if (i >= 7 && i <= 10)
            {
                return true;
            }

            if (i == -2 || i == -1)
            {
                return true;
            }

            if (i >= -10 && i <= -7)
            {
                return true;
            }

            return false;
        }
    }
}
