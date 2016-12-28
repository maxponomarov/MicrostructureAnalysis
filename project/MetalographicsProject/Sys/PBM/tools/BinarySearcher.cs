using System;
using System.IO;

namespace MetalographicsProject.Sys.PBM.tools
{
    public class BinarySearcher
    {
        public int Search(Int32 searchString, string filePath)
        {
            FileStream s = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            int ByteRead;

            using (BinaryReader b = new BinaryReader(s))
            {
                if (b.BaseStream.Length > 4)
                {
                    for (int i = 0; i < b.BaseStream.Length - 4; i++)
                    {
                        ByteRead = b.ReadInt32();

                        b.BaseStream.Position -= 3;

                        if (ByteRead == searchString)
                            return i;

                    }//for
                }//if
            }//using

            return -1;

        }//functions

        public int[] SearchToArray(byte searchString, string filePath, int count)
        {
            FileStream s = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            int[] array = new int[count];
            Int32 ByteRead;
            int k = 0;

            using (BinaryReader b = new BinaryReader(s))
            {
                 for (int i = 0; i < b.BaseStream.Length && k < count; i++)
                 {
                    ByteRead = b.ReadByte();

                    if (ByteRead == searchString)
                    {
                        array[k] = i;
                        k++;
                    }

                }//for
            }//using
            return array;
        }//functions
    }//class
}//namespace
