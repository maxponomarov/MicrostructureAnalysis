using System.Collections.Generic;
using System.Drawing;
using AForge.Imaging.Filters;

namespace MetalographicsProject.Filters {
    public class MedianBlurFilter : AbstractFilter {
        public int Size { get; }

        public MedianBlurFilter(int size) { Size = size; }

        public override Bitmap ApplyFilter(List<Bitmap> bitmap) {
            Median filter = new Median(Size);
            return filter.Apply(bitmap[0]);
        }

        public override string ToString() {
            return $"Median Blur Filter Size:{Size}";
        }
    }
}
