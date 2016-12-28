using System.Collections.Generic;
using System.Drawing;
using AForge.Imaging.Filters;


namespace MetalographicsProject.Filters {
    public class GaussianBlurFilter : AbstractFilter {
        public int Sigma { get; }
        public int Radius { get; }

        public GaussianBlurFilter(int radius, int sigma) {
            Sigma = sigma;
            Radius = radius;
        }

        public override Bitmap ApplyFilter(List<Bitmap> bitmap) {
            GaussianBlur filter = new GaussianBlur(Sigma, Radius);
            return filter.Apply(bitmap[0]);
        }

        public override string ToString() {
            return $"Gaussian Blur Filter Sigma:{Sigma} Size:{Radius}";
        }
    }
}
