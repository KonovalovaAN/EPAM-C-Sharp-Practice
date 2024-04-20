using System;

namespace BitOperationsTask
{
    public static class NumbersExtension
    {
        public static int InsertNumberIntoAnother(int destinationNumber, int sourceNumber, int i, int j)
        {
            if (i < 0 || i > 31)
            {
                throw new ArgumentOutOfRangeException(nameof(i));
            }

            if (j < 0 || j > 31)
            {
                throw new ArgumentOutOfRangeException(nameof(j));
            }

            if (i > j)
            {
                throw new ArgumentException("Thrown when i is more than j.");
            }

            var binaryString = string.Empty;
            int result = 0;

            for (int x = 31; x >= 0; x--)
            {
                if (x >= i && x <= j)
                {
                    binaryString += (char)(((sourceNumber & (1 << ((x - i) % 32))) >> ((x - i) % 32)) | 48);
                }
                else
                {
                    binaryString += (char)(((destinationNumber & (1 << (x % 32))) >> (x % 32)) | 48);
                }
            }

            for (int x = 0; x < binaryString.Length; x++)
            {
                result += (binaryString[^(x + 1)] & 1) << (x % 32);
            }

            return result;
        }
    }
}
