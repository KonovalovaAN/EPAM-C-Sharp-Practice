using System;

namespace FindMaximum
{
    /// <summary>
    /// Class for operations with array.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Finds the element of the array with the maximum value recursively.
        /// </summary>
        /// <param name="array"> Source array. </param>
        /// <returns>The element of the array with the maximum value.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        public static int GetMax(int[] array)
        {
            if (array == Array.Empty<int>())
            {
                throw new ArgumentException("Array is empty.", nameof(array));
            }
            else if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            return Maxsimum(array, 0, array.Length);
        }

        public static int Maxsimum(int[] array, int left, int right)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (right - left == 1)
            {
                return array[left];
            }

            int middle = (left + right) / 2;
            int maxLeft = Maxsimum(array, left, middle);
            int maxRight = Maxsimum(array, middle, right);
            return maxLeft > maxRight ? maxLeft : maxRight;
        }
    }
}
