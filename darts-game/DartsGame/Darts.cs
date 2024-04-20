using System;

namespace DartsGame
{
    public static class Darts
    {
        public static int GetScore(double x, double y)
        {
            if ((x * x) + (y * y) > 100)
            {
                return 0;
            }

            if ((x * x) + (y * y) <= 100 && (x * x) + (y * y) > 25)
            {
                return 1;
            }

            if ((x * x) + (y * y) <= 25 && (x * x) + (y * y) > 1)
            {
                return 5;
            }

            return 10;
        }
    }
}
