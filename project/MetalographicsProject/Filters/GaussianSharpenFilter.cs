using System.Collections.Generic;
using System.Drawing;
using AForge.Imaging.Filters;

namespace MetalographicsProject.Filters {
    public class GaussianSharpenFilter : AbstractFilter {
        private readonly int sigma;
        private readonly int size;

        public int Sigma => sigma;
        public int Size => size;

        public GaussianSharpenFilter(int size, int sigma) {
            this.sigma = sigma;
            this.size = size;
        }

        public override Bitmap ApplyFilter(List<Bitmap> bitmap) {
            GaussianSharpen sharpen = new GaussianSharpen(sigma, size);
            return sharpen.Apply(bitmap[0]);
        }

        public override string ToString() {
            return $"Gaussian Sharpen Filter Sigma:{sigma} Size:{size}";
        }
    }
}
