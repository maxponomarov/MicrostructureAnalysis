using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using AForge.Imaging.Filters;
using MetalographicsProject.Sys;

namespace MetalographicsProject.Filters.EdgeDetectors {
    class CannyFilter : AbstractFilter {
        public override Bitmap ApplyFilter(List<Bitmap> bitmaps) {
            CannyEdgeDetector filter = new CannyEdgeDetector();
            return filter.Apply(bitmaps[0].ConvertPixelFormat(PixelFormat.Format8bppIndexed));
        }
    }
}
