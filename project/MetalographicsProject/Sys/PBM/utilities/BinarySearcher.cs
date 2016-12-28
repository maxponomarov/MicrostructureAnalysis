using System;
using System.IO;

namespace MetalographicsProject.Sys.PBM.utilities {
    class BinarySearch
    {
        static void Main_()
        {
            //Read Int32. Compare int32 with IHDR. Increment the BaseStream position and read again. When found, return the int. If not found, return -1.

            string stringToLookFor = "7777";
            string filePath = @"C:\SomePath\pi.txt";

            // convert the string to a binary (ASCII) representation
            byte[] bufferToLookFor = System.Text.Encoding.ASCII.GetBytes(stringToLookFor);

            int matchCounter = 1; // count matches for nicer output

            // open the file in binary mode
            using (Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] readBuffer = new byte[16384]; // our input buffer
                int bytesRead = 0; // number of bytes read
                int offset = 0; // offset inside read-buffer
                long filePos = 0; // position inside the file before read operation
        
                while ((bytesRead = stream.Read(readBuffer, offset, readBuffer.Length-offset)) > 0)
                {
                    for (int i=0; i<bytesRead+offset-bufferToLookFor.Length; i++)
                    {
                        bool match = true;
                    
                        for (int j=0; j<bufferToLookFor.Length; j++)
                        {
                            if (bufferToLookFor[j] != readBuffer[i+j])
                            {
                                match = false;
                                break;
                            }

                            if (match)
                            {
                                Console.WriteLine("{0,5}. \"{1}\" found at {3:x}",
                                    matchCounter++, stringToLookFor, filePath, filePos+i-offset);
                            
                                //return;
                            }
                        }
                    }
                    // store file position before next read http://bytes.com/topic/c-sharp/answers/255263-parsing-binary-files
                    filePos = stream.Position;
                
                    // store the last few characters to ensure matches on "chunk boundaries"
                    offset = bufferToLookFor.Length;
                
                    for (int i=0; i<offset; i++)
                    {
                        readBuffer[i] = readBuffer[readBuffer.Length-offset+i];
                    }
                }
            }
            Console.WriteLine("No match found");
        }
    }
}
