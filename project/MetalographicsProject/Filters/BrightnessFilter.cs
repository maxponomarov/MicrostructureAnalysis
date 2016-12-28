using System.Collections.Generic;
using System.Drawing;
using AForge.Imaging.Filters;

namespace MetalographicsProject.Filters {
    public class BrightnessFilter : AbstractFilter {
        public int Value { get; }

        public BrightnessFilter(int value) { Value = value; }

        public override Bitmap ApplyFilter(List<Bitmap> bitmap) {
            BrightnessCorrection filter = new BrightnessCorrection(Value);
            return filter.Apply(bitmap[0]);
        }
    }
}
