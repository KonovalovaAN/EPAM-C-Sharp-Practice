using System;

namespace PalindromicNumberTask
{
    /// <summary>
    /// Provides static method for working with integers.
    /// </summary>
    public static class NumbersExtension
    {
        /// <summary>
        /// Determines if a number is a palindromic number, see https://en.wikipedia.org/wiki/Palindromic_number.
        /// </summary>
        /// <param name="number">Verified number.</param>
        /// <returns>true if the verified number is palindromic number; otherwise, false.</returns>
        /// <exception cref="ArgumentException"> Thrown when source number is less than zero. </exception>
        public static bool IsPalindromicNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Source number cannot be less than zero.", nameof(number));
            }

            int reversedNumber = 0;
            int originalNumber = number;

            while (number > 0)
            {
                int digit = number % 10;
                reversedNumber = (reversedNumber * 10) + digit;
                number /= 10;
            }

            return originalNumber == reversedNumber;
        }
    }
}
