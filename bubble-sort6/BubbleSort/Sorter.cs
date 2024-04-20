using System;

// ReSharper disable InconsistentNaming
#pragma warning disable IDE0079 // Удалить ненужное подавление
#pragma warning disable SA1611

namespace BubbleSort
#pragma warning restore IDE0079 // Удалить ненужное подавление
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with bubble sort algorithm.
        /// </summary>
        public static void BubbleSort(this int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            for (int i = array.Length; i > 0; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    if (array[j] < array[j - 1])
                    {
                        (array[j], array[j - 1]) = (array[j - 1], array[j]);
                    }
                }
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive bubble sort algorithm.
        /// </summary>
        public static void RecursiveBubbleSort(this int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            array.RecursiveBubbleSort(array.Length);
        }

        public static void RecursiveBubbleSort(this int[] array, int n)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (n == 1 || n == 0)
            {
                return;
            }

            for (int j = 1; j < n; j++)
            {
                if (array[j] < array[j - 1])
                {
                    (array[j], array[j - 1]) = (array[j - 1], array[j]);
                }
            }

            RecursiveBubbleSort(array, n - 1);
        }
    }
}
