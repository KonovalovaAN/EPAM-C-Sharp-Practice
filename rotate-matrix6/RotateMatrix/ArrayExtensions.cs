using System;

namespace RotateMatrix
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Rotates the image clockwise by 90° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate90DegreesClockwise(this int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            int n = (int)Math.Sqrt(matrix.Length);
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = i; j < n - i - 1; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[n - 1 - j, i];
                    matrix[n - 1 - j, i] = matrix[n - 1 - i, n - 1 - j];
                    matrix[n - 1 - i, n - 1 - j] = matrix[j, n - 1 - i];
                    matrix[j, n - 1 - i] = temp;
                }
            }
        }

        /// <summary>
        /// Rotates the image counterclockwise by 90° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate90DegreesCounterClockwise(this int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            int n = (int)Math.Sqrt(matrix.Length);
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = i; j < n - i - 1; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, n - 1 - i];
                    matrix[j, n - 1 - i] = matrix[n - 1 - i, n - 1 - j];
                    matrix[n - 1 - i, n - 1 - j] = matrix[n - 1 - j, i];
                    matrix[n - 1 - j, i] = temp;
                }
            }
        }

        /// <summary>
        /// Rotates the image clockwise by 180° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate180DegreesClockwise(this int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            int n = (int)Math.Sqrt(matrix.Length);
            int[,] tempMatrix = new int[n, n];
            Array.Copy(matrix, 0, tempMatrix, 0, matrix.Length);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = tempMatrix[n - 1 - i, n - 1 - j];
                }
            }
        }

        /// <summary>
        /// Rotates the image counterclockwise by 180° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate180DegreesCounterClockwise(this int[,] matrix)
        {
            matrix.Rotate180DegreesClockwise();
        }

        /// <summary>
        /// Rotates the image clockwise by 270° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate270DegreesClockwise(this int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            int nubber = (int)Math.Sqrt(matrix.Length);
            for (int i = 0; i < nubber / 2; i++)
            {
                for (int j = i; j < nubber - i - 1; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, nubber - 1 - i];
                    matrix[j, nubber - 1 - i] = matrix[nubber - 1 - i, nubber - 1 - j];
                    matrix[nubber - 1 - i, nubber - 1 - j] = matrix[nubber - 1 - j, i];
                    matrix[nubber - 1 - j, i] = temp;
                }
            }
        }

        /// <summary>
        /// Rotates the image counterclockwise by 270° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate270DegreesCounterClockwise(this int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            int number = (int)Math.Sqrt(matrix.Length);
            for (int i = 0; i < number / 2; i++)
            {
                for (int j = i; j < number - i - 1; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[number - 1 - j, i];
                    matrix[number - 1 - j, i] = matrix[number - 1 - i, number - 1 - j];
                    matrix[number - 1 - i, number - 1 - j] = matrix[j, number - 1 - i];
                    matrix[j, number - 1 - i] = temp;
                }
            }
        }

        /// <summary>
        /// Rotates the image clockwise by 360° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate360DegreesClockwise(this int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }
        }

        /// <summary>
        /// Rotates the image counterclockwise by 360° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate360DegreesCounterClockwise(this int[,] matrix)
        {
            matrix.Rotate360DegreesClockwise();
        }
    }
}
