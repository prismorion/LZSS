using System.Collections.Generic;

namespace LZSS
{
    class BitWriter
    {
        private List<byte> outputByte;
        private byte currentByte;
        private int numBitsFilled;

        public BitWriter(List<byte> outputByte)
        {
            this.outputByte = outputByte;
            currentByte = 0;
            numBitsFilled = 0;
        }

        public void Write(int value, int numBits)
        {
            for (int i = 0; i < numBits; i++)
            {
                int bit = (value >> i) & 1;
                currentByte |= (byte)(bit << numBitsFilled);
                numBitsFilled++;

                if (numBitsFilled == 8)
                {
                    outputByte.Add(currentByte);
                    currentByte = 0;
                    numBitsFilled = 0;
                }
            }
        }

        public void Close()
        {
            while (numBitsFilled != 0)
            {
                Write(0, 1);
            }
        }
    }
}
