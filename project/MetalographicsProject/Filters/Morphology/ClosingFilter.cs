using System.Collections.Generic;
using System.Drawing;
using AForge.Imaging.Filters;

namespace MetalographicsProject.Filters.Morphology {
    class ClosingFilter : AbstractFilter {
        public short[,] Matrix { get; }
        
        public ClosingFilter(short[,] matrix) {
            Matrix = matrix;
        }

        public override Bitmap ApplyFilter(List<Bitmap> bitmap) {
            Closing filter = new Closing(Matrix);
            return filter.Apply(bitmap[0]);
        }
        
    }
}
