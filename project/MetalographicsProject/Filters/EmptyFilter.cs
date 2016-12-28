using System.Collections.Generic;
using System.Drawing;

namespace MetalographicsProject.Filters {
    class EmptyFilter : AbstractFilter{
        public override Bitmap ApplyFilter(List<Bitmap> bitmap) {
            return bitmap[0];
        }

        public override string ToString() { return "Empty Filter"; }
    }
}
