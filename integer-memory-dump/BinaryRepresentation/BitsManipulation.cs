using System;
using System.Text;

namespace BinaryRepresentation
{
    public static class BitsManipulation
    {
        /// <summary>
        /// Get binary memory representation of signed long integer.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>Binary memory representation of signed long integer.</returns>
        public static string GetMemoryDumpOf(long number)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 63; i >= 0; i--)
            {
                long k = number >> i;
                if ((k & 1) > 0)
                {
                    result.Append("1");
                }
                else
                {
                    result.Append("0");
                }
            }

            return result.ToString();
        }
    }
}
