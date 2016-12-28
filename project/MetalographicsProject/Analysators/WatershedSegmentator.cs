using System;
using System.Collections.Generic;
using System.Drawing;
using AForge.Imaging.Filters;
using MetalographicsProject.Analysators.Objects;

namespace MetalographicsProject.Analysators {
    class WatershedSegmentator : AbstractDetector {
        public WatershedSegmentator() {
            
        }
        
        public List<Segment> DetectSegments(Bitmap image) {
            throw new NotImplementedException();
        }

        public Bitmap WatershedTest(Bitmap image) {
            Threshold threshold = new Threshold(150);
            threshold.ApplyInPlace(image);

            

            return image;
        }

        public override Bitmap GetResultBitmap() {
            throw new NotImplementedException();
        }
    }
}
