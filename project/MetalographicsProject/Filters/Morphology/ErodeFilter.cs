using System.Collections.Generic;
using System.Drawing;
using AForge.Imaging.Filters;

namespace MetalographicsProject.Filters.Morphology {
    class ErodeFilter : AbstractFilter {
        public short[,] Matrix { get; }

        public ErodeFilter(short[,] matrix) {
            Matrix = matrix;
        }

        public override Bitmap ApplyFilter(List<Bitmap> bitmap) {
            Erosion filter = new Erosion(Matrix);
            return filter.Apply(bitmap[0]);
        }
        
    }
}
