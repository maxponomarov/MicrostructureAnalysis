using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using AForge.Imaging.Filters;
using Image = AForge.Imaging.Image;

namespace MetalographicsProject.Filters {
    public class BlackWhiteFilter : AbstractFilter {
        private readonly float red;
        private readonly float green;
        private readonly float blue;

        public float Red => red;
        public float Green => green;
        public float Blue => blue;

        public BlackWhiteFilter(float red, float green, float blue) {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public override Bitmap ApplyFilter(List<Bitmap> bitmap) {
            Grayscale filter = new Grayscale(red, green, blue);
            Bitmap newBitmap = Image.Clone(bitmap[0], PixelFormat.Format32bppRgb);
            
            return filter.Apply(newBitmap);
        }

        public override string ToString() {
            return $"BlackWhilte Filter R:{red:f3} G:{green:f3} B:{blue:f3}";
        }
    }
}
