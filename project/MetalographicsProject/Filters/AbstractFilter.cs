using System.Collections.Generic;
using System.Drawing;

namespace MetalographicsProject.Filters {
    public abstract class AbstractFilter {
        public abstract Bitmap ApplyFilter(List<Bitmap> bitmaps);
        
        public override string ToString() { return "Abstract filter"; }
    }
}
