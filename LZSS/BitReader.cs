namespace LZSS
{
    class BitReader
    {
        private byte[] inputBytes;
        private byte currentByte;
        private int numBitsRemaining;
        private int currentIndex;
        public bool reading;

        public BitReader(byte[] inputBytes)
        {
            this.inputBytes = inputBytes;
            currentByte = 0;
            numBitsRemaining = 0;
            currentIndex = 0;
            reading = true;
        }

        public int Read(int numBits)
        {
            int result = 0;

            for (int i = 0; i < numBits; i++)
            {
                if (numBitsRemaining == 0)
                {
                    currentByte = inputBytes[currentIndex++];
                    if (currentIndex == inputBytes.Length)
                        reading = false;
                    numBitsRemaining = 8;
                }

                int bit = (currentByte >> (8 - numBitsRemaining)) & 1;
                result |= bit << i;

                numBitsRemaining--;
            }

            return result;
        }
    }
}
