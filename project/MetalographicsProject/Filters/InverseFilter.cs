using System.Collections.Generic;
using AForge.Imaging.Filters;
using System.Drawing;

namespace MetalographicsProject.Filters {
    class InverseFilter : AbstractFilter {
        public override Bitmap ApplyFilter(List<Bitmap> bitmap) {
            Invert filter = new Invert();
            return filter.Apply(bitmap[0]);
        }
    }
}
