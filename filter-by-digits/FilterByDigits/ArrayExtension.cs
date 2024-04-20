using System;
using System.Collections.Generic;

namespace FilterTask
{
    public static class ArrayExtension
    {
        public static int[] FilterByDigit(int[] source, int digit)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("array is empty.", nameof(source));
            }

            if (digit < 0 || digit > 9)
            {
                throw new ArgumentOutOfRangeException(nameof(digit), "digit value is out of range (0..9)");
            }

            List<int> listOfFilterByDigit = new List<int>();
            for (int i = 0; i < source.Length; i++)
            {
                if (IsContainDigit(source[i], digit))
                {
                    listOfFilterByDigit.Add(source[i]);
                }
            }

            return listOfFilterByDigit.ToArray();
        }

        public static bool IsContainDigit(int number, int digit)
        {
            number = Math.Abs(number);
            do
            {
                if (number % 10 == digit)
                {
                    return true;
                }

                number /= 10;
            }
            while (number > 0);

            return false;
        }
    }
}
