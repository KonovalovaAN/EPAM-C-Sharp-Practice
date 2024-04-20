using System;
using System.Collections;

#pragma warning disable IDE0079 // Удалить ненужное подавление
#pragma warning disable S2368

namespace LookingForArrayElements
#pragma warning restore IDE0079 // Удалить ненужное подавление
{
    public static class DecimalCounter
    {
        /// <summary>
        /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetDecimalsCount(decimal[] arrayToSearch, decimal[][] ranges)
        {
            _ = ranges ?? throw new ArgumentNullException(nameof(ranges));
            _ = arrayToSearch ?? throw new ArgumentNullException(nameof(arrayToSearch));
            RecursFindException(ranges, 0);
            return GetDecimalsCount(arrayToSearch, ranges, 0, arrayToSearch.Length);
        }

        /// <summary>
        /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetDecimalsCount(decimal[] arrayToSearch, decimal[][] ranges, int startIndex, int count = -1)
        {
            _ = ranges ?? throw new ArgumentNullException(nameof(ranges));
            _ = arrayToSearch ?? throw new ArgumentNullException(nameof(arrayToSearch));
            if (count == 0)
            {
                return 0;
            }

            if (startIndex + count > arrayToSearch.Length)
            {
                RecursFindException(ranges, 0);
                throw new ArgumentOutOfRangeException(nameof(arrayToSearch));
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            bool isCount = false;
            int cnt = RecursSearchInDecArray(arrayToSearch[startIndex], ranges, 0, isCount);
            return GetDecimalsCount(arrayToSearch, ranges, startIndex + 1, count - 1) + cnt;
        }

        public static int RecursSearchInDecArray(decimal n, decimal[][] ranges, int index, bool isCount)
        {
            _ = ranges ?? throw new ArgumentNullException(nameof(ranges));

            if (index == ranges.Length || ranges[index].Length == 0 || isCount)
            {
                return 0;
            }

            int count = 0;
            if (n >= ranges[index][0] && n <= ranges[index][1])
            {
                count++;
                isCount = true;
            }

            return RecursSearchInDecArray(n, ranges, index + 1, isCount) + count;
        }

        public static void RecursFindException(decimal[][] ranges, int index)
        {
            _ = ranges ?? throw new ArgumentNullException(nameof(ranges));

            if (index == ranges.Length)
            {
                return;
            }

            if (ranges[index] is null)
            {
                throw new ArgumentNullException(nameof(ranges));
            }

            if (ranges[index].Length == 0)
            {
                return;
            }

            if (ranges[index].Length != 2)
            {
                throw new ArgumentException("the length of one of the ranges is less or greater than 2", nameof(ranges));
            }

            RecursFindException(ranges, index + 1);
        }
    }
}
