using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using AForge.Imaging.Filters;

namespace MetalographicsProject.Filters {
    public class AdaptiveTresholdFilter : AbstractFilter {
        
        public override Bitmap ApplyFilter(List<Bitmap> bitmaps) {
            BradleyLocalThresholding filter = new BradleyLocalThresholding();

            if (bitmaps[0].PixelFormat != PixelFormat.Format16bppGrayScale) {
                BlackWhiteFilter filterGray = new BlackWhiteFilter(0.33f, 0.33f, 0.33f);
                bitmaps[0] = filterGray.ApplyFilter(bitmaps);
                return filter.Apply(bitmaps[0]);
            }
            return bitmaps[0];
        }
    }
}
