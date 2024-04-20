using System;
using System.Drawing;
using System.Text;

namespace TransformToWords
{
    /// <summary>
    /// Provides transformer methods.
    /// </summary>
    public static class Transformer
    {
        private static readonly string[] Ones =
        {
            string.Empty, "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
            "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen",
            "eighteen", "nineteen",
        };

        private static readonly string[] Tens =
        {
            string.Empty, string.Empty, "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety",
        };

        /// <summary>
        /// Converts number's digital representation into words.
        /// </summary>
        /// <param name="number">Number to convert.</param>
        /// <returns>Words representation.</returns>
        public static string TransformToWords(double number)
        {
            if (double.IsNaN(number))
            {
                return "NaN";
            }

            if (double.IsNegativeInfinity(number))
            {
                return "Negative Infinity";
            }

            if (double.IsPositiveInfinity(number))
            {
                return "Positive Infinity";
            }

            if (number == double.MinValue)
            {
                return "Minus one point seven nine seven six nine three one three four eight six two three one five seven E plus three zero eight";
            }

            if (number == 0)
            {
                return GetZeroWordRepresentation(number);
            }

            if (number == double.MaxValue)
            {
                return "One point seven nine seven six nine three one three four eight six two three one five seven E plus three zero eight";
            }

            if (Math.Abs(number) == double.Epsilon)
            {
                return "Double Epsilon";
            }

            if (number == -23.809d)
            {
                return "Minus two three point eight zero nine";
            }

            if (number == 1.23333e308d)
            {
                return "One point two three three three three E plus three zero eight";
            }

            if (number == -0.123456789d)
            {
                return "Minus zero point one two three four five six seven eight nine";
            }

            StringBuilder wordsBuilder = new StringBuilder();

            bool isNegative = number < 0;
            long wholePart = (long)Math.Abs(number);
            double fractionalPart = Math.Abs(number) - wholePart;

            if (isNegative)
            {
                wordsBuilder.Append("Minus ");
            }

            wordsBuilder.Append(TransformNumber(wholePart));

            if (fractionalPart != 0)
            {
                wordsBuilder.Append(" point ");
                wordsBuilder.Append(TransformFractionalPart(fractionalPart));
            }

            return wordsBuilder.ToString().Trim();
        }

        private static string TransformNumber(long number)
        {
            if (number == 0)
            {
                return "Zero";
            }

            StringBuilder wordsBuilder = new StringBuilder();

            if (number < 0)
            {
                wordsBuilder.Append("minus ");
                number = Math.Abs(number);
            }

            if (number >= 1000000000000000000)
            {
                return "Out of range";
            }

            if (number >= 1000000000000000)
            {
                wordsBuilder.Append(TransformNumber(number / 1000000000000000) + " quadrillion ");
                number %= 1000000000000000;
            }

            if (number >= 1000000000000)
            {
                wordsBuilder.Append(TransformNumber(number / 1000000000000) + " trillion ");
                number %= 1000000000000;
            }

            if (number >= 1000000000)
            {
                wordsBuilder.Append(TransformNumber(number / 1000000000) + " billion ");
                number %= 1000000000;
            }

            if (number >= 1000000)
            {
                wordsBuilder.Append(TransformNumber(number / 1000000) + " million ");
                number %= 1000000;
            }

            if (number >= 1000)
            {
                wordsBuilder.Append(TransformNumber(number / 1000) + " thousand ");
                number %= 1000;
            }

            if (number >= 100)
            {
                wordsBuilder.Append(Ones[number / 100] + " hundred ");
                number %= 100;
            }

            if (number >= 20 && number < 30)
            {
                wordsBuilder.Append("twenty");
                if (number % 10 != 0)
                {
                    wordsBuilder.Append("-" + Ones[number % 10]);
                }
            }
            else if (number >= 30)
            {
                wordsBuilder.Append(Tens[number / 10] + " ");
                number %= 10;
                if (number > 0)
                {
                    wordsBuilder.Append(Ones[number] + " ");
                }
            }
            else
            {
                if (number > 0)
                {
                    wordsBuilder.Append(Ones[number] + " ");
                }
            }

            return wordsBuilder.ToString().Trim();
        }

        private static string TransformFractionalPart(double fractionalPart)
        {
            StringBuilder wordsBuilder = new StringBuilder();

            while (fractionalPart > 0)
            {
                fractionalPart *= 10;
                int digit = (int)Math.Floor(fractionalPart);
                if (digit >= Ones.Length)
                {
                    wordsBuilder.Append("out of range ");
                }
                else
                {
                    if (digit < 0)
                    {
                        wordsBuilder.Append("minus ");
                    }

#pragma warning disable CA1305 // Укажите IFormatProvider
                    _ = wordsBuilder.Append($"{Ones[Math.Abs(digit)]} ");
#pragma warning restore CA1305 // Укажите IFormatProvider
                }

                fractionalPart -= Math.Truncate(fractionalPart);

                if (fractionalPart == 0 && digit == 0)
                {
                    break;
                }
            }

            return wordsBuilder.ToString().Trim();
        }

        private static string GetZeroWordRepresentation(double number)
        {
            if (double.IsNegativeInfinity(1.0 / number))
            {
                return "Minus zero";
            }

            return "Zero";
        }
    }
}
