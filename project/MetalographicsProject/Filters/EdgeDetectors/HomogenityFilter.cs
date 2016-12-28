using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using AForge.Imaging.Filters;
using MetalographicsProject.Sys;

namespace MetalographicsProject.Filters.EdgeDetectors {
    class HomogenityFilter : AbstractFilter {
        public override Bitmap ApplyFilter(List<Bitmap> bitmaps) {
            HomogenityEdgeDetector filter = new HomogenityEdgeDetector();
            return filter.Apply(bitmaps[0].ConvertPixelFormat(PixelFormat.Format16bppGrayScale));
        }
    }
}
