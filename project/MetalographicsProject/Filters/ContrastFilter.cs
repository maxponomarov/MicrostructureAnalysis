using System.Collections.Generic;
using System.Drawing;
using AForge.Imaging.Filters;

namespace MetalographicsProject.Filters {
    class ContrastFilter : AbstractFilter {
        public int Value { get; }

        public ContrastFilter(int value) {
            Value = value;
        }

        public override Bitmap ApplyFilter(List<Bitmap> bitmap) {
            ContrastCorrection filter = new ContrastCorrection(Value);
            return filter.Apply(bitmap[0]);
        }
    }
}
