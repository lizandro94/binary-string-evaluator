namespace BinaryEvaluatorTest
{
    public class Evaluator
    {
        public static bool IsGoodBinaryString(string binaryString)
        {
            int zeroCount = 0;
            int oneCount = 0;
            int prefixZeroCount = 0;
            int prefixOneCount = 0;

            foreach (char c in binaryString)
            {
                if (c == '0')
                {
                    zeroCount++;
                    prefixZeroCount++;
                }
                else if (c == '1')
                {
                    oneCount++;
                    prefixOneCount++;
                }

                if (prefixOneCount < prefixZeroCount)
                {
                    return false;
                }
            }

            return zeroCount == oneCount;
        }
    }
}
