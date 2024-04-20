using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml;

namespace TransformerToWords
{
    /// <summary>
    /// Implements transformer class.
    /// </summary>
    public class Transformer
    {
        private static string CharToWord(char digit) =>
        digit switch
            {
                '-' => " minus",
                '+' => " plus",
                ',' => " point",
                'E' => " E",
                '0' => " zero",
                '1' => " one",
                '2' => " two",
                '3' => " three",
                '4' => " four",
                '5' => " five",
                '6' => " six",
                '7' => " seven",
                '8' => " eight",
                '9' => " nine",
                _ => " point"
            };

#pragma warning disable CA1822 // Пометьте члены как статические
#pragma warning disable SA1202 // Elements should be ordered by access
        public string[] Transform(double[]? source)
#pragma warning restore SA1202 // Elements should be ordered by access
#pragma warning restore CA1822 // Пометьте члены как статические
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source), "array is null");
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("array length is null", nameof(source));
            }

            string[] result = new string[source.Length];

            for (int i = 0; i < source.Length; i++)
            {
                result[i] = NumberToWord(source[i]);
            }

            return result;
        }

        private static string NumberToWord(double number)
        {
            switch (number)
            {
                case double.NaN:
                    return "Not a Number";
                case double.Epsilon:
                    return "Double Epsilon";
                case double.NegativeInfinity:
                    return "Negative Infinity";
                case double.PositiveInfinity:
                    return "Positive Infinity";
            }

            string stringNumber = number.ToString(CultureInfo.InvariantCulture);
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < stringNumber.Length; i++)
            {
                result.Append(CharToWord(stringNumber[i]));
            }

            return char.ToUpper(result[1], CultureInfo.InvariantCulture) + result.ToString()[2..];
        }
    }
}
