using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace MetalographicsProject.Filters {
    public class RetinexBrightness : AbstractFilter {
        public byte Value { get; }

        public RetinexBrightness(byte value) {
            Value = value;
        }
        
        public override Bitmap ApplyFilter(List<Bitmap> bitmap) {
            //get tmp file name
            string fileNameIn = Path.GetTempFileName() + "retinexIN.png";
            string fileNameOut = Path.GetTempFileName() + "retinexOUT.png";

            //save image to tmp folder
            bitmap[0].Save(fileNameIn, ImageFormat.Png);

            //start process and give it path to image and result path
            //value in out
            Process process = new Process {
                StartInfo = {
                    //RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    FileName = "consoletools\\RetinexProject.exe",
                    Arguments = $"{Value} {fileNameIn} {fileNameOut}"
                }
            };
            
            process.Start();
            process.WaitForExit();
            //load new image
            var fs = new FileStream(fileNameOut, FileMode.Open);
            Bitmap newBitmap = new Bitmap(fs);
            fs.Close();
            
            File.Delete(fileNameIn);
            File.Delete(fileNameOut);

            //return
            return newBitmap;
        }
        
    }
}
