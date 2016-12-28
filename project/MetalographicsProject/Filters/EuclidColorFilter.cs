using System.Collections.Generic;
using System.Drawing;
using AForge.Imaging;
using AForge.Imaging.Filters;

namespace MetalographicsProject.Filters {
    class EuclidColorFilter : AbstractFilter {
        public Color Color { get; }
        public short Radius { get; }
        private readonly EuclideanColorFiltering filter;

        public EuclidColorFilter(Color color, short radius) {
            Color = color;
            Radius = radius;
            filter = new EuclideanColorFiltering(new RGB(Color), Radius);
        }


        public override Bitmap ApplyFilter(List<Bitmap> bitmap) {
            return filter.Apply(bitmap[0]);
        }
    }
}
