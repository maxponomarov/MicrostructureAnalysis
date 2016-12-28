using System.Collections.Generic;
using System.Drawing;
using AForge.Imaging.Filters;

namespace MetalographicsProject.Filters {
    class ContrastStretchFilter : AbstractFilter{
        public override Bitmap ApplyFilter(List<Bitmap> bitmap) {
            ContrastStretch filter = new ContrastStretch();
            return filter.Apply(bitmap[0]);
        }
    }
}
