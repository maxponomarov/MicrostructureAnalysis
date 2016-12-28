using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace MetalographicsProject.Filters {
    class DistanceTranformFilter : AbstractFilter {
        public override Bitmap ApplyFilter(List<Bitmap> bitmap) {
            //get tmp file name
            string fileNameIn = Path.GetTempFileName() + "distanceIN.pbm";
            string fileNameOut = Path.GetTempFileName() + "distanceOUT.pgm";

            //save image to tmp folder
            ShaniSoft.Drawing.PNM.WritePNM(fileNameIn, bitmap[0]);

            //start process and give it path to image and result path
            //value in out
            Process process = new Process {
                StartInfo = {
                    //RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    FileName = "consoletools\\DistanceTransformProject.exe",
                    Arguments = $"{fileNameIn} {fileNameOut}"
                }
            };

            process.Start();
            process.WaitForExit();
            //load new image
            //var fs = new FileStream(fileNameOut, FileMode.Open);
            //Bitmap newBitmap = new Bitmap(fs);
            //fs.Close();

            Bitmap newBitmap = new Bitmap(ShaniSoft.Drawing.PNM.ReadPNM(fileNameOut));

            File.Delete(fileNameIn);
            File.Delete(fileNameOut);

            //return
            return newBitmap;

        }
    }
}
