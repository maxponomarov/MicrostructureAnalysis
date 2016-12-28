using System.Collections.Generic;
using AForge.Imaging;
using System.Drawing;
using System.Drawing.Imaging;
using MetalographicsProject.Analysators.Objects;
using Point = System.Drawing.Point;

namespace MetalographicsProject.Analysators {
    public class BlobDetector : AbstractDetector {
        private Bitmap image;
        private int minHeight;
        private int minWidth; 

        public BlobDetector(Bitmap image, int minHeight, int minWidth) {
            this.image = image;
            this.minHeight = minHeight;
            this.minWidth = minWidth;
        }

        public Bitmap RenderPreview(Pen pen) {
            Bitmap bmp = new Bitmap(image.Width, image.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            using (var gr = Graphics.FromImage(bmp)) {
                gr.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height));
            }

            Graphics g = Graphics.FromImage(bmp);

            foreach (Spot spot in DetectBlobs()) {
                g.DrawRectangle(pen, new Rectangle(spot.Position.X, spot.Position.Y, spot.Width, spot.Heigth));
            }

            return bmp;
        }

        public List<Spot> DetectBlobs() {
            BlobCounterBase counter = new BlobCounter {
                FilterBlobs = true,
                MinHeight = minHeight,
                MinWidth = minWidth,
                ObjectsOrder = ObjectsOrder.Area
            };
            counter.ProcessImage(image);
            Blob[] blobs = counter.GetObjectsInformation();

            List<Spot> spots = new List<Spot>();
            foreach (Blob blob in blobs) {
                
                counter.ExtractBlobsImage(image, blob, false);
                Point position = new Point(blob.Rectangle.X, blob.Rectangle.Y);
                int width = blob.Rectangle.Width;
                int heigth = blob.Rectangle.Height;
                
                Spot spot = new Spot(blob.Image.ToManagedImage(), position, width, heigth, blob.Area, counter.GetBlobsEdgePoints(blob));
                spots.Add(spot);
            }

            return spots;
        }

        public override Bitmap GetResultBitmap() {
            return RenderPreview(new Pen(Color.Red, 1));
        }
    }
}
