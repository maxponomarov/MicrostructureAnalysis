using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using AForge.Imaging.Filters;
using MetalographicsProject.Sys;

namespace MetalographicsProject.Filters.EdgeDetectors {
    class SobelFilter : AbstractFilter {
        public override Bitmap ApplyFilter(List<Bitmap> bitmaps) {
            SobelEdgeDetector filter = new SobelEdgeDetector();
            return filter.Apply(bitmaps[0].ConvertPixelFormat(PixelFormat.Format8bppIndexed));
        }
    }
}
