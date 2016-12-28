//---------------------------------------
//
//Created by James L. Broun, 2011 (14/04/2011 (UK format))
//Copyright (c) 2011, J. L. Broun
//
//---------------------------------------
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using MetalographicsProject.Sys.PBM.tools;

namespace MetalographicsProject.Sys.PBM.decoders {
    class PBM {
        public int readMagicNumber(string fname)
        {
            FileStream pbm_name = new FileStream(fname, FileMode.Open, FileAccess.Read, FileShare.None);

            using (BinaryReader r = new BinaryReader(pbm_name))
            {
                Int16 test = r.ReadInt16();

                if (test == 0x3150)//P1
                {
                    return 1;
                }

                else if (test == 0x3450)//P4
                {
                    return 0;
                }

                else //Get in a tantrum
                {
                    return -1;
                }
            }
        }

        public void readData(string fname, out int Height, out int Width, out char[] byteAndCharArray)//string[] stringBytes)
        {
            string input = File.ReadAllText(fname);

            input = input.Replace("\r", "");

            string[] StringArray = input.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);//Array of all values in the file

            int mNumberCounter = 0, dimCounter = 0, result;

            Width = 0;
            Height = 0;

            bool result1;

            byteAndCharArray = null;
            //stringBytes = null;

            for (int i = 0; i < StringArray.Length; i++)
            {
                //Check to see whether or not the line starts with "# "

                if (StringArray[i].StartsWith("# "))
                {
                    continue;
                }

                //This line is not a comment.
                
                else if (mNumberCounter == 0)
                {
                    string[] BrokenUp = StringArray[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                    switch (BrokenUp.Length)
                    {
                        case 1:
                            //we have only got the mn
                            mNumberCounter = 1;
                            break;
                        case 2:
                            //we have only got the Width
                            mNumberCounter = 1;
                            result1 = int.TryParse(BrokenUp[1], NumberStyles.Integer, CultureInfo.CurrentCulture, out result);
                            if (result1)
                            {
                                Width = result;
                                dimCounter++;
                            }

                            else
                            {
                                continue;
                            }
                           
                            break;

                        case 3:
                            //we have everything
                            mNumberCounter = 1;

                            result1 = int.TryParse(BrokenUp[1], NumberStyles.Integer, CultureInfo.CurrentCulture, out result);
                            if (result1)
                            {
                                Width = result;
                                dimCounter++;
                            }

                            else
                            {
                                continue;
                            }

                            result1 = int.TryParse(BrokenUp[2], NumberStyles.Integer, CultureInfo.CurrentCulture, out result);
                            
                            if (result1)
                            {
                                Height = result;
                                dimCounter++;
                            }

                            else
                            {
                                continue;
                            }

                            break;
                    }
                }

                else if (dimCounter == 0)
                {
                    string[] BrokenUp = StringArray[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                    switch (BrokenUp.Length)
                    {
                        case 1:
                            //we have only got the Width
                            result1 = int.TryParse(BrokenUp[0], NumberStyles.Integer, CultureInfo.CurrentCulture, out result);
                            if (result1)
                            {
                                Width = result;
                                dimCounter++;
                            }

                            else
                            {
                                continue;
                            }
                            break;
                        case 2:
                            //we have only got the Height
                            mNumberCounter = 1;

                            result1 = int.TryParse(BrokenUp[0], NumberStyles.Integer, CultureInfo.CurrentCulture, out result);
                            if (result1)
                            {
                                Width = result;
                                dimCounter++;
                            }

                            else
                            {
                                continue;
                            }

                            result1 = int.TryParse(BrokenUp[1], NumberStyles.Integer, CultureInfo.CurrentCulture, out result);
                            
                            if (result1)
                            {
                                Height = result;
                                dimCounter++;
                            }

                            else
                            {
                                continue;
                            }

                            break;
                    }
                }

                else if (dimCounter == 1)//Width and Height will be found hopefully
                {
                    string[] BrokenUp = StringArray[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                    result1 = int.TryParse(BrokenUp[0], NumberStyles.Integer, CultureInfo.CurrentCulture, out result);

                    if (result1)
                    {
                        Height = result;
                        dimCounter++;
                    }

                    else
                    {
                        continue;
                    }

                }

                else //take it that this is the start of the pixel data.
                {
                    //string main="";

                   // for (int k = i; k < StringArray.Length; k++)
                   //     main += StringArray[k] + " ";

                    string main = ConvertStringArrayToString(StringArray, i);

                    //main = main.Replace("\f", ""); main = main.Replace("\v", ""); main = main.Replace("\t", ""); //remove tabs, formfeeds and vertical tabs

                    //stringBytes = main.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                    bool booleanFlag = false;
                    byteAndCharArray = new char[Width*Height];
                    int j = 0;

                    foreach (char c in main)
                    {
                        if (booleanFlag && c != '\n')//If we're in a comment, just carry on
                            continue;

                        else if (booleanFlag && c == '\n')//A newline character can mark the end of a comment. 
                                                          //If we've met one, then set the flag to false, so that at the next loop, we read the data
                            booleanFlag = false;

                        else if (c == '0' || c == '1')//If we've met a 1 or 0 and we're not in a comment, then add it to the array.
                        {
                            byteAndCharArray[j] = c;
                            j++;
                        }

                        else if (c == '#')//This marks the start of a comment.
                            booleanFlag = true;

                        else//If it's not met any of the above conditions, it's just junk and we can get rid of (i.e. ignore) it.
                            continue;
                    }

                    break;
                }
            }
        }

        static string ConvertStringArrayToString(string[] array, int i)
        {
            //
            // Concatenate all the elements into a StringBuilder.
            //
            StringBuilder builder = new StringBuilder();
            for (int k = i; k < array.Length; k++)
            {
                builder.Append(array[k]);
                builder.Append('\n');
            }
            return builder.ToString();
        }

        public byte[] ConvertBytes(byte[] stuff)
        {
            byte[] stuff1 = new byte[stuff.Length * 8];
            int counter = 0;
            int k;

            for (int j = 0; j < stuff.Length; j++)
            {
                k = 1;

                for (int i = 0; i < 8 && k < 129; i++, k *= 2, counter++)//Skip forward three bytes for each pixel, eight pixels for each entry in pixels[]
                {
                    byte colour = ((stuff[j] & (128 / k)) == 0 ? (byte)(255) : (byte)0);//Determine if the bit is set

                    stuff1[counter] = colour;//The pixels are moved along
                }
            }

            return stuff1;
        }

        public System.Windows.Media.Imaging.BitmapImage bmpFromPBM(char[] pixels, int width, int height)
        {
            //Remember that pixels is simply a string of "0"s and "1"s. Width and Height are integers.
            
            int Width = width;
            int Height = height;

            //Create our bitmap
            using (Bitmap B = new Bitmap(Width, Height))
            {
                //Will hold our byte as a string of bits
                //string Bits = null;

                //Current X,Y co-ordinates of the Bitmap object
                int X = 0;
                int Y = 0;

                //Loop through all of the bits
                for (int i = 0; i < pixels.Length; i++)
                {
                    //Below, we're comparing the value with "0". If it is a zero, then we change the pixel white, else make it black.
                    B.SetPixel(X, Y, pixels[i] == '0' ? System.Drawing.Color.White : System.Drawing.Color.Black);
                        
                    //Increment our X position
                    
                    X += 1;//Move along the right

                    //If we're passed the right boundry, reset the X and move the Y to the next line
                    
                    if (X >= Width)
                    {
                        X = 0;//reset
                        Y += 1;//Add another row
                    }
                }

                //return B;
                MemoryStream ms = new MemoryStream();
                B.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                ms.Position = 0;
                System.Windows.Media.Imaging.BitmapImage bi = new System.Windows.Media.Imaging.BitmapImage();
                bi.BeginInit();
                bi.StreamSource = ms;
                bi.EndInit();

                return bi;
                //Output the bitmap to the desktop
                //B.Save(System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop), "Output3.bmp"), System.Drawing.Imaging.ImageFormat.Bmp);
            }
        }

        public System.Windows.Media.Imaging.BitmapImage bmpFromBinaryPBM(byte[] pixels, int width, int height) {
            int stride = ((width * ((1 + 7) / 8)) + 4 - ((width * ((1 + 7) / 8)) % 4));
            Bitmap B = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format8bppIndexed);

            unsafe
            {
                System.Drawing.Imaging.BitmapData bmd = B.LockBits(new Rectangle(0, 0, B.Width, B.Height), System.Drawing.Imaging.ImageLockMode.ReadWrite, B.PixelFormat);
                
                int j = 0;
                int y = 0;
                
                IntPtr ptr = bmd.Scan0;
                int bytes = Math.Abs(pixels.Length);//This gives us the bitmap data size
                byte[] rgbValues = new byte[bytes];

                System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

                for (int counter = 0; counter < rgbValues.Length && j < pixels.Length; )
                {
                    int k = 1;//bring k back to 1
                    //Move pixel byte from array along

                    for (int i = 0; i < 8 && k < 129; i++, k *= 2, counter++, j++)//Skip forward three bytes for each pixel, eight pixels for each entry in pixels[]
                    {
                        if (bmd.Stride - width == 0 & y == B.Width) {
                            y = 0;
                            //When we reach the width, we skip the padding
                            break;
                        } else if (bmd.Stride - width != 0 & y == B.Width) {
                            y = 0;
                            counter += bmd.Stride - width;//When we reach the width, we skip the padding
                            j += (bmd.Stride - width) + (pixels.Length - rgbValues.Length) / height;// (width % 8);
                            break;
                        }

                        byte colour = pixels[j];//((pixels[j] & (128 / k)) == 0 ? (byte)(255) : (byte)0);//Determine if the bit is set

                        rgbValues[counter] = colour;//The pixels are moved along

                        y++; //Move y along (that is, move forward by a pixel)
                    }
                   
                     //We don't move along until all the values are sorted.
                }

                System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

                B.UnlockBits(bmd);
            }

            MemoryStream ms = new MemoryStream();
            B.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            ms.Position = 0;
            System.Windows.Media.Imaging.BitmapImage bi = new System.Windows.Media.Imaging.BitmapImage();
            bi.BeginInit();
            bi.StreamSource = ms;
            bi.EndInit();
            return bi;
        }

        public void readBinaryData(string fname, out int Height, out int Width, out byte[] stringBytes)
        {            
            string input = File.ReadAllText(fname);

            input = input.Replace("\r", "");

            string[] StringArray = input.Split(new string[] { "\n" }, StringSplitOptions.None );//Array of all values in the file

            int mNumberCounter = 0, dimCounter = 0, result;

            Width = 0;
            Height = 0;

            bool result1;

            stringBytes = null;

            for (int i = 0; i < StringArray.Length; i++)
            {
                //Check to see whether or not the line starts with "# "

                if (StringArray[i].StartsWith("# "))
                {
                    continue;
                }

                //This line is not a comment.

                else if (mNumberCounter == 0)
                {
                    string[] BrokenUp = StringArray[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                    switch (BrokenUp.Length)
                    {
                        case 1:
                            //we have only got the mn
                            mNumberCounter = 1;
                            break;
                        case 2:
                            //we have only got the Width
                            mNumberCounter = 1;
                            result1 = int.TryParse(BrokenUp[1], NumberStyles.Integer, CultureInfo.CurrentCulture, out result);
                            if (result1)
                            {
                                Width = result;
                                dimCounter++;
                            }

                            else
                            {
                                continue;
                            }

                            break;

                        case 3:
                            //we have everything
                            mNumberCounter = 1;

                            result1 = int.TryParse(BrokenUp[1], NumberStyles.Integer, CultureInfo.CurrentCulture, out result);
                            if (result1)
                            {
                                Width = result;
                                dimCounter++;
                            }

                            else
                            {
                                continue;
                            }

                            result1 = int.TryParse(BrokenUp[2], NumberStyles.Integer, CultureInfo.CurrentCulture, out result);

                            if (result1)
                            {
                                Height = result;
                                dimCounter++;
                            }

                            else
                            {
                                continue;
                            }

                            break;
                    }
                }

                else if (dimCounter == 0)
                {
                    string[] BrokenUp = StringArray[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                    switch (BrokenUp.Length)
                    {
                        case 1:
                            //we have only got the Width
                            result1 = int.TryParse(BrokenUp[0], NumberStyles.Integer, CultureInfo.CurrentCulture, out result);
                            if (result1)
                            {
                                Width = result;
                                dimCounter++;
                            }

                            else
                            {
                                continue;
                            }
                            break;
                        case 2:
                            //we have only got the Height
                            mNumberCounter = 1;

                            result1 = int.TryParse(BrokenUp[0], NumberStyles.Integer, CultureInfo.CurrentCulture, out result);
                            if (result1)
                            {
                                Width = result;
                                dimCounter++;
                            }

                            else
                            {
                                continue;
                            }

                            result1 = int.TryParse(BrokenUp[1], NumberStyles.Integer, CultureInfo.CurrentCulture, out result);

                            if (result1)
                            {
                                Height = result;
                                dimCounter++;
                            }

                            else
                            {
                                continue;
                            }

                            break;
                    }
                }

                else if (dimCounter == 1)//Width and Height will be found hopefully
                {
                    string[] BrokenUp = StringArray[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                    result1 = int.TryParse(BrokenUp[0], NumberStyles.Integer, CultureInfo.CurrentCulture, out result);

                    if (result1)
                    {
                        Height = result;
                        dimCounter++;
                    }

                    else
                    {
                        continue;
                    }

                }

                else //take it that this is the start of the pixel data.
                {
                    int nCount = i;//This is the number of \n's that we've encountered.

                    BinarySearcher b = new BinarySearcher();

                    FileStream fs = new FileStream(fname, FileMode.Open, FileAccess.Read);

                    int[] offsets = b.SearchToArray(0x0a, fname, nCount);

                    int stride = ((Width * ((1 + 7) / 8)) + 4 - ((Width * ((1 + 7) / 8)) % 4));
                    int X = 0;


                    using (BinaryReader e = new BinaryReader(fs))
                    {
                        e.BaseStream.Position = offsets[nCount-1] + 1;
                        long bufferSize = e.BaseStream.Length;

                        stringBytes = e.ReadBytes((int)bufferSize - offsets[nCount-1] + ((stride - Width) * Height));

                        stringBytes = ConvertBytes(stringBytes);
                    }

                    break;
                }
            }
        }

        //Everything below is not used. It is retained for reference.

        public int readHeight(string fname)
        {
            string input = File.ReadAllText(fname);

            string[] StringArray = input.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            if (!StringArray[1].StartsWith("# "))
            {
                StringArray[0].Replace("\t", " ");
                StringArray[0].Replace("\r", " ");

                string[] DimensionsArray = StringArray[0].Split(new string[] { "\r" }, StringSplitOptions.RemoveEmptyEntries);
                string[] DimensionsArray2 = StringArray[0].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                DimensionsArray2[0] = DimensionsArray2[1].Trim();

                int result;

                bool result1 = int.TryParse(DimensionsArray2[0], NumberStyles.Integer, CultureInfo.CurrentCulture, out result);
                if (result1)
                    return result;

                else
                    return -1;
            }

            else
            {
                StringArray[1].Replace("\t", " ");
                StringArray[1].Replace("\r", " ");

                string[] DimensionsArray = StringArray[2].Split(new string[] { "\r" }, StringSplitOptions.RemoveEmptyEntries);
                string[] DimensionsArray2 = StringArray[2].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                DimensionsArray2[0] = DimensionsArray2[0].Trim();

                int result;

                bool result1 = int.TryParse(DimensionsArray2[0], NumberStyles.Integer, CultureInfo.CurrentCulture, out result);
                if (result1)
                    
                    return result;

                else
                    return -1;
            }
        }

        public int readWidth(string fname)
        {
            string input = File.ReadAllText(fname);

            string[] StringArray = input.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            
            if (!StringArray[1].StartsWith("# "))
            {
                StringArray[0].Replace("\t", " ");
                StringArray[0].Replace("\r", " ");

                string[] DimensionsArray = StringArray[0].Split(new string[] { "\r" }, StringSplitOptions.RemoveEmptyEntries);
                string[] DimensionsArray2 = StringArray[0].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                DimensionsArray2[0] = DimensionsArray2[2].Trim();
                DimensionsArray2[0] = DimensionsArray2[2].Replace("\r", "");

                int result;

                bool result1 = int.TryParse(DimensionsArray2[0], NumberStyles.Integer, CultureInfo.CurrentCulture, out result);

                if (result1)
                    return result;

                else
                    return -1;
            }

            else
            {
                StringArray[1].Replace("\t", " ");
                StringArray[1].Replace("\r", " ");

                string[] DimensionsArray = StringArray[2].Split(new string[] { "\r" }, StringSplitOptions.RemoveEmptyEntries);
                string[] DimensionsArray2 = StringArray[2].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                DimensionsArray2[0] = DimensionsArray2[1].Trim();
                DimensionsArray2[0] = DimensionsArray2[1].Replace("\r", "");

                int result;

                bool result1 = int.TryParse(DimensionsArray2[1], NumberStyles.Integer, CultureInfo.CurrentCulture, out result);
                if (result1)
                    return result;

                else
                    return -1;
            }
        }

        public string[] getPixels(string fname)
        {
            string input = File.ReadAllText(fname);

            string[] StringArray = input.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            string StringToContainData = null;

            if (!StringArray[1].StartsWith("# "))
            {
                for (int i = 2; i < StringArray.Length; i++)
                {
                    StringToContainData += StringArray[i];
                }

                StringToContainData = StringToContainData.Trim();
                StringToContainData = StringToContainData.Replace("\r", " ");
                StringToContainData = StringToContainData.Replace('\n', ' ');

                string[] StringArray2 = StringToContainData.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                return StringArray2;
            }

            else
            {
                for (int i = 3; i < StringArray.Length; i++)
                {
                    StringToContainData += StringArray[i];
                }

                //StringToContainData = StringToContainData.Trim();
                StringToContainData = StringToContainData.Replace("\r", " ");
                StringToContainData = StringToContainData.Replace("\n", " ");

                string[] StringArray2 = StringToContainData.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                return StringArray2;
            }
        }

        public string[] readpixelsTemp(string fname)
        {
            string input = File.ReadAllText(fname);

            input = input.Trim();
            input = input.Replace("\r", " ");
            input = input.Replace("\n", " ");

            int result = 0;

            foreach (char c in input)
            {
                if (!char.IsWhiteSpace(c))
                {
                    result++;
                }
            }

            string[] StringArray = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            int k = 0;

            return StringArray;
        }

    }
}
