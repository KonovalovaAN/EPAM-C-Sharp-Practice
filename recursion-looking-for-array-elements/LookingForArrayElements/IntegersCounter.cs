using System;

namespace LookingForArrayElements
{
    public static class IntegersCounter
    {
        /// <summary>
        /// Searches an array of integers for elements that are in <paramref name="elementsToSearchFor"/> <see cref="Array"/>, and returns the number of occurrences of the elements.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of integers to search.</param>
        /// <param name="elementsToSearchFor">One-dimensional, zero-based <see cref="Array"/> that contains integers to search for.</param>
        /// <returns>The number of occurrences of the elements that are in <paramref name="elementsToSearchFor"/> <see cref="Array"/>.</returns>
        public static int GetIntegersCount(int[] arrayToSearch, int[] elementsToSearchFor)
        {
            return GetIntegersCount(arrayToSearch, elementsToSearchFor, 0);
        }

        /// <summary>
        /// Searches an array of integers for elements that are in <paramref name="elementsToSearchFor"/> <see cref="Array"/>, and returns the number of occurrences of the elements withing the range of elements in the <see cref="Array"/> that starts at the specified index and contains the specified number of elements.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of integers to search.</param>
        /// <param name="elementsToSearchFor">One-dimensional, zero-based <see cref="Array"/> that contains integers to search for.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the elements that are in <paramref name="elementsToSearchFor"/> <see cref="Array"/>.</returns>
        public static int GetIntegersCount(int[] arrayToSearch, int[] elementsToSearchFor, int startIndex, int count = -1)
        {
            _ = arrayToSearch ?? throw new ArgumentNullException(nameof(arrayToSearch));
            _ = elementsToSearchFor ?? throw new ArgumentNullException(nameof(elementsToSearchFor));

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (startIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater or equals arrayToSearch.Length");
            }

            if (startIndex == arrayToSearch.Length || count == 0)
            {
                return 0;
            }

            int cnt = RecursSearchInIntArray(arrayToSearch[startIndex], elementsToSearchFor, 0);
            return GetIntegersCount(arrayToSearch, elementsToSearchFor, startIndex + 1, count - 1) + cnt;
        }

        public static int RecursSearchInIntArray(int n, int[] arrayToSearch, int index)
        {
            if (arrayToSearch == null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (index == arrayToSearch.Length)
            {
                return 0;
            }

            int count = n == arrayToSearch[index] ? 1 : 0;

            return RecursSearchInIntArray(n, arrayToSearch, index + 1) + count;
        }
    }
}
