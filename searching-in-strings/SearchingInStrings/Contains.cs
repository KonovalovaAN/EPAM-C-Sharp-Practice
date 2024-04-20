using System;
using System.Globalization;

namespace SearchingInStrings
{
    public static class Contains
    {
        public static bool IsContainsChar(string str, char value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str), "Argument cannot be null.");
            }

            return str.Contains(value);
        }

        public static bool IsContainsCharWithStringComparison(string str, char value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str), "Argument cannot be null.");
            }

            return str.Contains(value.ToString(), StringComparison.Ordinal);
        }

        public static bool IsContainsString(string str, string value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str), "Argument cannot be null.");
            }

            return str.Contains(value);
        }

        public static bool IsContainsStringWithStringComparison(string str, string value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str), "Argument cannot be null.");
            }

            return str.Contains(value, StringComparison.InvariantCulture);
        }
    }
}
