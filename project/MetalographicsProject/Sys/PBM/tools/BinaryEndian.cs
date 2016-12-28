using System;
using System.IO;

namespace MetalographicsProject.Sys.PBM.tools
{
    class BinaryEndian
    {
        public enum ByteOrder : int
        {
            LittleEndian,
            BigEndian
        }

        public static byte[] ReadBytes(BinaryReader reader, int fieldSize, ByteOrder
        byteOrder)
        {
            byte[] bytes = new byte[fieldSize];
            if (byteOrder == ByteOrder.LittleEndian)
                return reader.ReadBytes(fieldSize);
            else
            {
                for (int i = fieldSize - 1; i > -1; i--)
                    bytes[i] = reader.ReadByte();
                return bytes;
            }
        }

        public static int ReadInt32(BinaryReader reader, ByteOrder byteOrder)
        {
            if (byteOrder == ByteOrder.LittleEndian)
            {
                return (int)reader.ReadInt32();
            }
            else // Big-Endian
            {
                return BitConverter.ToInt32(ReadBytes(reader, 32, ByteOrder.BigEndian), 0);
            }
        }

        public Int32 combine(BinaryReader reader, int fieldSize, ByteOrder
        byteOrder)
        {
            byte[] j = ReadBytes(reader, fieldSize, byteOrder);
            Int32 k = 0;
            int h = 0;

            for (int i = j.Length - 1; i >= 0; i--, h++)
            {
                k += ((Int32)j[h]) << (8*i);
            }

            return k;
        }
    }
}
