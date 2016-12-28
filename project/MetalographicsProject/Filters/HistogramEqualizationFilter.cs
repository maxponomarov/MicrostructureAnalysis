using System.Collections.Generic;
using System.Drawing;
using AForge.Imaging.Filters;

namespace MetalographicsProject.Filters {
    class HistogramEqualizationFilter : AbstractFilter {
        public override Bitmap ApplyFilter(List<Bitmap> bitmaps) {
            HistogramEqualization filter = new HistogramEqualization();
            return filter.Apply(bitmaps[0]);
        }
    }
}
