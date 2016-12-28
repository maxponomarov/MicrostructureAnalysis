using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using AForge.Imaging.Filters;
using MetalographicsProject.Sys;

namespace MetalographicsProject.Filters.EdgeDetectors {
    class DifferenceFilter : AbstractFilter {
        public override Bitmap ApplyFilter(List<Bitmap> bitmaps) {
            DifferenceEdgeDetector filter = new DifferenceEdgeDetector();
            return filter.Apply(bitmaps[0].ConvertPixelFormat(PixelFormat.Format8bppIndexed));
        }
    }
}
