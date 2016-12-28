using System;
using System.Drawing;
using MetalographicsProject.Forms;

namespace MetalographicsProject.Controllers {
    class CoordinatesController {
        public static MeasureStatus MeasureStatus { get; private set; }

        public static Point PBtoPCoordinates(Point point, Size PictureBoxSize, Size PictureSize) {
            double xC = (double)PictureBoxSize.Width/PictureSize.Width;
            double yC = (double)PictureBoxSize.Height/PictureSize.Height;
            double C = xC > yC ? yC : xC;
            
            Size newPBSize = new Size {
                Width = (int)(PictureBoxSize.Width / C),
                Height = (int)(PictureBoxSize.Height / C)
            };
            Point newPoint = new Point {
                X = (int)(point.X / C),
                Y = (int)(point.Y / C)
            };

            int a = Convert.ToInt32((newPBSize.Width - PictureSize.Width) / 2);
            int b = Convert.ToInt32((newPBSize.Height - PictureSize.Height) / 2);

            Point picturePoint = new Point {
                X = Convert.ToInt32(newPoint.X - a),
                Y = Convert.ToInt32(newPoint.Y - b)
            };

            if (picturePoint.X < 0)
                picturePoint.X = 0;
            if (picturePoint.Y < 0)
                picturePoint.Y = 0;
            
            return picturePoint;
        }
    }
}
