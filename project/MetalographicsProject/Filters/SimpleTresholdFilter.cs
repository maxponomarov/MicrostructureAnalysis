using System.Collections.Generic;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;

namespace MetalographicsProject.Filters {
    public class SimpleTresholdFilter : AbstractFilter {
        public int Min { get; }
        public int Max { get; }

        public SimpleTresholdFilter(int min, int max) {
            Min = min;
            Max = max;
        }

        public override Bitmap ApplyFilter(List<Bitmap> bitmap) {
            Image<Gray, byte> gray = new Image<Gray, byte>(bitmap[0]);
            
            gray._ThresholdBinary(new Gray(Min), new Gray(Max));
            return gray.ToBitmap();
        }
    }
}
