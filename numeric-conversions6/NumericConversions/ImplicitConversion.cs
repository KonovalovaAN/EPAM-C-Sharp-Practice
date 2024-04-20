namespace NumericConversions
{
    public static class ImplicitConversion
    {
        public static long IntToLong(int intValue)
        {
            return intValue;
        }

        public static float IntToFloat(int intValue)
        {
            return (float)intValue;
        }

        public static double IntToDouble(int intValue)
        {
            return (double)intValue;
        }

        public static decimal IntToDecimal(int intValue)
        {
            return (decimal)intValue;
        }

        public static float LongToFloat(long longValue)
        {
            return (float)longValue;
        }

        public static double LongToDouble(long longValue)
        {
            return (double)longValue;
        }

        public static decimal LongToDecimal(long longValue)
        {
            return (decimal)longValue;
        }

        public static short ByteToShort(byte byteValue)
        {
            return (short)byteValue;
        }

        public static int ByteToInt(byte byteValue)
        {
            return (int)byteValue;
        }
    }
}
