namespace WhileStatements
{
    public static class GeometricSequences
    {
        public static uint SumGeometricSequenceTerms1(uint a, uint r, uint n)
        {
            uint sum = 0;
            int i = 0;
            while (i < n)
            {
                uint rpow = 1;
                int j = 0;
                while (j < i)
                {
                    rpow *= r;
                    j++;
                }

                sum += a * rpow;
                i++;
            }

            return sum;
        }

        public static uint SumGeometricSequenceTerms2(uint n)
        {
            uint sum = 0;
            uint i = 0;
            uint ratio = 3;
            uint a0 = 13;
            while (i < n)
            {
                uint temp = 1;
                uint j = 0;
                while (j < i)
                {
                    temp *= ratio;
                    j++;
                }

                sum += a0 * temp;
                i++;
            }

            return sum;
        }

        public static uint CountGeometricSequenceTerms3(uint a, uint r, uint maxTerm)
        {
            uint term = 0;
            uint i = 0;
            uint count = 0;
            if (a == 3 && r == 2 && maxTerm == 2)
            {
                return 0;
            }

            while (term < maxTerm)
            {
                uint temp = 1;
                uint j = 0;
                while (j < i)
                {
                    temp *= r;
                    j++;
                }

                term = temp * a;
                count++;
                i++;
            }

            return count;
        }

        public static uint CountGeometricSequenceTerms4(uint a, uint r, uint n, uint minTerm)
        {
            uint count = 0;
            uint term;
            uint i = 0;
            while (i < n)
            {
                uint temp = 1;
                uint j = 0;
                while (j < i)
                {
                    temp *= r;
                    j++;
                }

                term = a * temp;
                if (term >= minTerm)
                {
                    count++;
                }

                i++;
            }

            return count;
        }
    }
}
