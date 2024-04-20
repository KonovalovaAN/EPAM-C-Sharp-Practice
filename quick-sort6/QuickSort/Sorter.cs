using System;

namespace QuickSort
{
    public static class Sorter
    {
        public static void QuickSort(this int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array), "Array can not be null.");
            }

            if (array.Length < 2)
            {
                return;
            }

            int startIndex = 0;
            int endIndex = array.Length - 1;
            int top = -1;
            int[] stack = new int[array.Length];

            stack[++top] = startIndex;
            stack[++top] = endIndex;

            while (top >= 0)
            {
                endIndex = stack[top--];
                startIndex = stack[top--];

                int p = array.Partition(startIndex, endIndex);

                if (p - 1 > startIndex)
                {
                    stack[++top] = startIndex;
                    stack[++top] = p - 1;
                }

                if (p + 1 < endIndex)
                {
                    stack[++top] = p + 1;
                    stack[++top] = endIndex;
                }
            }
        }

        public static void RecursiveQuickSort(this int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            array.RecursiveQuickSort(0, array.Length - 1);
        }

        private static int Partition(this int[] array, int left, int right)
        {
            int x = array[right];
            int i = left - 1;

            for (int j = left; j <= right - 1; ++j)
            {
                if (array[j] <= x)
                {
                    ++i;
                    (array[i], array[j]) = (array[j], array[i]);
                }
            }

            (array[i + 1], array[right]) = (array[right], array[i + 1]);
            return i + 1;
        }

        private static void RecursiveQuickSort(this int[] array, int left, int right)
        {
            if (left < right)
            {
                int q = array.Partition(left, right);
                array.RecursiveQuickSort(left, q - 1);
                array.RecursiveQuickSort(q + 1, right);
            }
        }
    }
}
