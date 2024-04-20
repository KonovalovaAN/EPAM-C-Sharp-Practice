using System;

namespace LookingForArrayElements
{
    public static class FloatCounter
    {
        /// <summary>
        /// Searches an array of floats for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="rangeStart">One-dimensional, zero-based <see cref="Array"/> of the range starts.</param>
        /// <param name="rangeEnd">One-dimensional, zero-based <see cref="Array"/> of the range ends.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetFloatsCount(float[] arrayToSearch, float[] rangeStart, float[] rangeEnd)
        {
            _ = rangeStart ?? throw new ArgumentNullException(nameof(rangeStart));
            _ = rangeEnd ?? throw new ArgumentNullException(nameof(rangeEnd));
            if (rangeStart.Length != 0 && rangeEnd.Length != 0 && rangeStart[0] > rangeEnd[0])
            {
                throw new ArgumentException("rangeStart[index] > rangeEnd[index]");
            }

            return GetFloatsCount(arrayToSearch, rangeStart, rangeEnd, 0);
        }

        /// <summary>
        /// Searches an array of floats for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="rangeStart">One-dimensional, zero-based <see cref="Array"/> of the range starts.</param>
        /// <param name="rangeEnd">One-dimensional, zero-based <see cref="Array"/> of the range ends.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetFloatsCount(float[] arrayToSearch, float[] rangeStart, float[] rangeEnd, int startIndex, int count = -1)
        {
            _ = arrayToSearch ?? throw new ArgumentNullException(nameof(arrayToSearch));
            _ = rangeStart ?? throw new ArgumentNullException(nameof(rangeStart));
            _ = rangeEnd ?? throw new ArgumentNullException(nameof(rangeEnd));
            if (rangeStart.Length != rangeEnd.Length)
            {
                throw new ArgumentException("rangeStart.Length != rangeEnd.Length");
            }

            if (startIndex < 0 || startIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (startIndex + count > arrayToSearch.Length)
            {
                throw new ArgumentException(null);
            }

            if (startIndex == arrayToSearch.Length || count == 0)
            {
                return 0;
            }

            int cnt = RecursSearchInFloatArray(arrayToSearch[startIndex], rangeStart, rangeEnd, 0);
            return GetFloatsCount(arrayToSearch, rangeStart, rangeEnd, startIndex + 1, count - 1) + cnt;
        }

        public static int RecursSearchInFloatArray(float n, float[] rangeStart, float[] rangeEnd, int index)
        {
            _ = rangeStart ?? throw new ArgumentNullException(nameof(rangeStart));
            _ = rangeEnd ?? throw new ArgumentNullException(nameof(rangeEnd));

            if (index == rangeStart.Length)
            {
                return 0;
            }

            int count = (n >= rangeStart[index] && n <= rangeEnd[index]) ? 1 : 0;
            return RecursSearchInFloatArray(n, rangeStart, rangeEnd, index + 1) + count;
        }
    }
}
