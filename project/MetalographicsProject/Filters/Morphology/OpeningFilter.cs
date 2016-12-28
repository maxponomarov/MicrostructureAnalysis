using System.Collections.Generic;
using System.Drawing;
using AForge.Imaging.Filters;

namespace MetalographicsProject.Filters.Morphology {
    class OpeningFilter : AbstractFilter {
        public short[,] Matrix { get; }

        public OpeningFilter(short[,] matrix) {
            Matrix = matrix;
        }

        public override Bitmap ApplyFilter(List<Bitmap> bitmap) {
            Opening filter = new Opening(Matrix);
            return filter.Apply(bitmap[0]);
        }
        
    }
}
