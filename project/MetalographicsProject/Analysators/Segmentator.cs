using System.Collections.Generic;
using System.Drawing;
using MetalographicsProject.Analysators.Objects;

namespace MetalographicsProject.Analysators {
    abstract class Segmentator : AbstractDetector {
        public abstract List<Segment> DetectSegments(Bitmap image);
        //public abstract List<Segment> DetectSegments(Bitmap image, int minSize);
        //public abstract List<Segment> DetectSegments(Bitmap image, int minSize, Point[] markers);

    }
}
