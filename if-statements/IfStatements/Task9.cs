namespace IfStatements
{
    public static class Task9
    {
        public static bool DoSomething(bool b, int i)
        {
            if (b is true && ((i >= 1 && i <= 4) || (i >= 9 && i <= 10) || (i >= -4 && i <= -1) || (i >= -10 && i <= -9)))
            {
                return true;
            }

            if (b is false && ((i >= 1 && i <= 3) || (i >= 8 && i <= 10) || (i >= -10 && i <= -9)))
            {
                return true;
            }

            if (i >= -4 && i <= -1)
            {
                return true;
            }

            return false;
        }
    }
}
