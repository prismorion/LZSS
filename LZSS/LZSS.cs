using System;
using System.Collections.Generic;

namespace LZSS
{
    class LZSS
    {      
        public static byte[] Compress(int windowSize, int bufferSize, byte[] inputBytes)
        {
            List<byte> compressBytes = new List<byte> { };

            BitWriter bitWriter = new BitWriter(compressBytes);
            
            bitWriter.Write(windowSize, 10);
            bitWriter.Write(bufferSize, 10);

            int bitLengthWindowSize = (int)Math.Ceiling(Math.Log(windowSize, 2));
            int bitLengthBufferSize = (int)Math.Ceiling(Math.Log(bufferSize, 2));

            int index = 0;

            while (index < inputBytes.Length)
            {
                int bestMatchIndex = -1;
                int bestMatchLength = 0;

                for (int i = Math.Max(0, index - windowSize); i < index; i++)
                {
                    int j = 0;
                    while (j < bufferSize && index + j < inputBytes.Length && inputBytes[i + j] == inputBytes[index + j])
                    {
                        j++;
                    }

                    if (j > bestMatchLength)
                    {
                        bestMatchIndex = i;
                        bestMatchLength = j;
                    }
                }

                if (bestMatchLength > 0)
                {
                    bitWriter.Write(1, 1);
                    bitWriter.Write(index - bestMatchIndex - 1, bitLengthWindowSize);
                    bitWriter.Write(bestMatchLength - 1, bitLengthBufferSize);
                    index += bestMatchLength;
                }
                else
                {
                    bitWriter.Write(0, 1);
                    bitWriter.Write(inputBytes[index++], 8);
                }
            }

            bitWriter.Close();

            return compressBytes.ToArray();
        }

        public static byte[] Decompress(byte[] inputBytes)
        {
            List<byte> decompressBytes = new List<byte> { };

            BitReader bitReader = new BitReader(inputBytes);
            int windowSize = bitReader.Read(10);
            int bufferSize = bitReader.Read(10);

            int bitLengthWindowSize = (int)Math.Ceiling(Math.Log(windowSize, 2));
            int bitLengthBufferSize = (int)Math.Ceiling(Math.Log(bufferSize, 2));

            int index = 0;

            while (bitReader.reading)
            {
                int flag = bitReader.Read(1);
                if (flag == 0)
                {
                    int byteValue = bitReader.Read(8);
                    decompressBytes.Add((byte)byteValue);
                    index += 9;
                }
                else
                {
                    int offset = bitReader.Read(bitLengthWindowSize) + 1;
                    int length = bitReader.Read(bitLengthBufferSize) + 1;

                    for (int i = 0; i < length; i++)
                    {
                        decompressBytes.Add(decompressBytes[decompressBytes.Count - offset]);
                    }
                    index += offset + length + 1;
                }
            }

            return decompressBytes.ToArray();
        }
    }
}
