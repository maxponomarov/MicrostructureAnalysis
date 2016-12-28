using System.Collections.Generic;
using System.Drawing;
using AForge.Imaging.Filters;

namespace MetalographicsProject.Filters.Morphology {
    class DilateFilter : AbstractFilter {
        public short[,] Matrix { get; }

        public DilateFilter(short[,] matrix) {
            Matrix = matrix;
        }

        public override Bitmap ApplyFilter(List<Bitmap> bitmap) {
            Dilatation filter = new Dilatation(Matrix);
            return filter.Apply(bitmap[0]);
        }
        
    }
}
