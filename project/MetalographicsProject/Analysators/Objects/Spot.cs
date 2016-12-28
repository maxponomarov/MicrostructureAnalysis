using System.Collections.Generic;
using System.Drawing;
using AForge;
using Point = System.Drawing.Point;

namespace MetalographicsProject.Analysators.Objects {
    public class Spot {
        public Bitmap Image { get; }
        public Point Position { get; }
        public int Width { get; }
        public int Heigth { get; }
        public List<IntPoint> OutPoints { get; }
        public int PixelArea;
        
        public Spot(Bitmap image, Point position, int width, int heigth, int pixelArea, List<IntPoint> points) {
            Image = image;
            Position = position;
            Width = width;
            Heigth = heigth;
            OutPoints = points;
            PixelArea = pixelArea;
        }
    }
}
