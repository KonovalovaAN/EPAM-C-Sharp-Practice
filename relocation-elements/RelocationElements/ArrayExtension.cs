using System;

namespace RelocationElements
{
    /// <summary>
    /// Class for operations with array.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Moves all of the elements with set value to the end, preserving the order of the other elements.
        /// </summary>
        /// <param name="source"> Source array. </param>
        /// <param name="value">Source value.</param>
        /// <exception cref="ArgumentNullException">Thrown when source array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when source array is empty.</exception>
        public static void MoveToTail(int[] source, int value)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source), "Array cannot be null.");
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("Array cannot be empty.", nameof(source));
            }

            int i = 0;
            while (i <= source.Length - 1)
            {
                if (source[i] == value)
                {
                    int j = i;
                    while (source[j] == value && j <= source.Length - 2)
                    {
                        j++;
                    }

                    (source[i], source[j]) = (source[j], source[i]);
                }

                i++;
            }
        }
    }
}
