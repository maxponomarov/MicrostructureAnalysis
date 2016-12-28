using System;
using System.Drawing;

namespace MetalographicsProject.Controllers.Measure {
    public class Measure {
        public Guid Guid { get; private set; }
        public Size ImageSize { get; private set; }
        public double Scale { get; private set; }

        public Measure(double scale) {
            Guid = Guid.NewGuid();
            Scale = scale;
        }

        public Measure(double scale, Size imageSize) {
            Guid = Guid.NewGuid();
            Scale = scale;
            ImageSize = imageSize;
        }
    }
}
