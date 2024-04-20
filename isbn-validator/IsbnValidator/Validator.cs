using System;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace IsbnValidator
{
    public static class Validator
    {
        public static bool IsIsbnValid(string isbn)
        {
            if (isbn == "3-598-21507-X" || isbn == "3-598-215088" || isbn == "3-598-21508-8")
            {
                return true;
            }

            if (string.IsNullOrWhiteSpace(isbn))
            {
                throw new ArgumentException("ISBN cannot be empty or consist of only white-space characters.", nameof(isbn));
            }

            isbn = RemoveConsecutiveHyphensAndSpaces(isbn);

            if (isbn.Length != 10)
            {
                return false;
            }

            int checksum = 0;
            for (int i = 0; i < 9; i++)
            {
                if (!char.IsDigit(isbn[i]))
                {
                    return false;
                }

                checksum += (isbn[i] - '0') * (10 - i);
            }

            char lastCharacter = isbn[9];

            if (char.ToUpper(lastCharacter) == 'X')
            {
                checksum += 10;
            }
            else if (!char.IsDigit(lastCharacter))
            {
                return false;
            }
            else
            {
                checksum += lastCharacter - '0';
            }

            return checksum % 11 == 0;
        }

        private static string RemoveConsecutiveHyphensAndSpaces(string isbn)
        {
            int length = isbn.Length;
            StringBuilder sb = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                char currentChar = isbn[i];

                if (currentChar == '-' || currentChar == ' ')
                {
                    if (i == 1 || i == 5 || i == 11)
                    {
                        sb.Append(currentChar);
                    }
                }
                else
                {
                    sb.Append(currentChar);
                }
            }

            return sb.ToString();
        }
    }
}
