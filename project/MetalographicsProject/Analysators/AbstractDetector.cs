using System.Drawing;
using MetalographicsProject.Model;

namespace MetalographicsProject.Analysators {
    public abstract class AbstractDetector : IImageGenerator {
        public abstract Bitmap GetResultBitmap();
    }
}