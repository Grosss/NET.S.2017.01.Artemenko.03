using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class BitInsertion
    {
        public static int PassNumbersAndBits(int firstNumb, int secondNumb, int firstBitPos, int secondBitPos)
        {
            if (firstBitPos > secondBitPos)
                throw new ArgumentException();
            byte[] firstBinaryNumb = TransformIntoBitArray(firstNumb);
            byte[] secondBinaryNumb = TransformIntoBitArray(secondNumb);
            InsertBits(firstBinaryNumb, secondBinaryNumb, firstBitPos, secondBitPos);
            
            return TransformIntoDecimal(firstBinaryNumb);
        }

        #region private methods
        private static byte[] TransformIntoBitArray(int numberToTransform)
        {
            byte[] binaryNumb = new byte[32];
            if (numberToTransform < 0)
            {
                binaryNumb[31] = 1;
                numberToTransform -= int.MinValue;
            }
            for(int i = 0; i < 31; i++)
            {
                binaryNumb[i] = (byte) (numberToTransform % 2);
                numberToTransform /= 2;
            }
            return binaryNumb;
        }

        private static void InsertBits(byte[] firstNumb, byte[] secondNumb, int firstPos, int secondPos)
        {
            int secondNumbIndex = 0;
            for(int i = firstPos; i < secondPos + 1; i++)
            {
                firstNumb[i] = secondNumb[secondNumbIndex++];
            }
        }

        private static int TransformIntoDecimal(byte[] binaryNumb)
        {
            int result = binaryNumb[0];
            for (int i = 1; i < 31; i++)
                result += (int) Math.Pow(binaryNumb[i] * 2, i);
            if (binaryNumb[31] == 1)
                result += int.MinValue;
            return result;
        }
        #endregion
    }
}
