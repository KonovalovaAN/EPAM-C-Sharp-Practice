using System;
using System.IO.Pipes;
using System.Text;
using System.Threading;

namespace NumeralSystems
{
    public static class Converter
    {
        /// <summary>
        /// Gets the value of a positive integer to its equivalent string representation in the octal numeral systems.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>The equivalent string representation of the number in the octal numeral systems.</returns>
        /// <exception cref="ArgumentException">Thrown if number is less than zero.</exception>
        public static string GetPositiveOctal(this int number)
        {
            return GetPositiveRadix(number, 8);
        }

        /// <summary>
        /// Gets the value of a positive integer to its equivalent string representation in the decimal numeral systems.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>The equivalent string representation of the number in the decimal numeral systems.</returns>
        /// <exception cref="ArgumentException">Thrown if number is less than zero.</exception>
        public static string GetPositiveDecimal(this int number)
        {
            return GetPositiveRadix(number, 10);
        }

        /// <summary>
        /// Gets the value of a positive integer to its equivalent string representation in the hexadecimal numeral systems.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>The equivalent string representation of the number in the hexadecimal numeral systems.</returns>
        /// <exception cref="ArgumentException">Thrown if number is less than zero.</exception>
        public static string GetPositiveHex(this int number)
        {
            return GetPositiveRadix(number, 16);
        }

        /// <summary>
        /// Gets the value of a positive integer to its equivalent string representation in a specified radix.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <param name="radix">Base of the numeral systems.</param>
        /// <returns>The equivalent string representation of the number in a specified radix.</returns>
        /// <exception cref="ArgumentException">Thrown if radix is not equal 8, 10 or 16.</exception>
        /// <exception cref="ArgumentException">Thrown if number is less than zero.</exception>
        public static string GetPositiveRadix(this int number, int radix)
        {
            if (number < 0)
            {
                throw new ArgumentException("number is must be more than zero", nameof(number));
            }

            return GetRadix(number, radix);
        }

        /// <summary>
        /// Gets the value of a signed integer to its equivalent string representation in a specified radix.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <param name="radix">Base of the numeral systems.</param>
        /// <returns>The equivalent string representation of the number in a specified radix.</returns>
        /// <exception cref="ArgumentException">Thrown if radix is not equal 8, 10 or 16.</exception>
        public static string GetRadix(this int number, int radix)
        {
            if (radix != 8 && radix != 10 && radix != 16)
            {
                throw new ArgumentException("radix is must be equal 8, 10 or 16", nameof(radix));
            }

            StringBuilder result = new StringBuilder();

            uint uNumber = (uint)number;
            uint uRadix = (uint)radix;

            while (uNumber != 0)
            {
                result.Insert(0, GetDigit(uNumber % uRadix));
                uNumber /= uRadix;
            }

            return result.ToString();
        }

#pragma warning disable CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
        private static string GetDigit(uint remainder) =>
            remainder switch
            {
                0 => "0",
                1 => "1",
                2 => "2",
                3 => "3",
                4 => "4",
                5 => "5",
                6 => "6",
                7 => "7",
                8 => "8",
                9 => "9",
                10 => "A",
                11 => "B",
                12 => "C",
                13 => "D",
                14 => "E",
                15 => "F",
                _ => null
            };
#pragma warning restore CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
    }
}
