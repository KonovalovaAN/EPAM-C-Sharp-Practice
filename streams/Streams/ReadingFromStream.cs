using System.Text;

namespace Streams
{
    public static class ReadingFromStream
    {
        public static string ReadAllStreamContent(StreamReader streamReader)
        {
            return streamReader.ReadToEnd();
        }

        public static string[] ReadLineByLine(StreamReader streamReader)
        {
            var readLineByLine = new List<string>();
            string str;
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            while ((str = streamReader.ReadLine()) != null)
            {
                readLineByLine.Add(str);
            }
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.

            return readLineByLine.ToArray();
        }

        public static StringBuilder ReadOnlyLettersAndNumbers(StreamReader streamReader)
        {
            var readOnlyLettersAndNumbers = new StringBuilder();
            while (char.IsLetterOrDigit((char)streamReader.Peek()))
            {
#pragma warning disable IDE0058 // Значение выражения никогда не используется
                readOnlyLettersAndNumbers.Append((char)streamReader.Read());
#pragma warning restore IDE0058 // Значение выражения никогда не используется
            }

            return readOnlyLettersAndNumbers;
        }

        public static char[][] ReadAsCharArrays(StreamReader streamReader, int arraySize)
        {
            long stremReaderLenght = streamReader.BaseStream.Length;
            int len = (int)(stremReaderLenght / arraySize) + ((stremReaderLenght % arraySize > 0) ? 1 : 0);
            var readAsCharArrays = new char[len][];
            int i = 0;
            int j = 0;
            var tempList = new List<char>();
            while (j != len)
            {
                if (i == arraySize)
                {
                    readAsCharArrays[j++] = tempList.ToArray();
                    i = 0;
                    tempList = new List<char>();
                    continue;
                }

                if (streamReader.Peek() > 0)
                {
                    tempList.Add((char)streamReader.Read());
                }

                i++;
            }

            return readAsCharArrays;
        }
    }
}
