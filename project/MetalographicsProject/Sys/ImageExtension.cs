using System;
using System.Drawing;
using System.Drawing.Imaging;
using Image = System.Drawing.Image;

namespace MetalographicsProject.Sys {
    static class ImageExtension {
        public static Image ScaleImage(this Image image, int maxWidth, int maxHeight) {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }

        public static Bitmap Clone2(this Bitmap img) {
            return img.Clone(new Rectangle(0, 0, img.Width, img.Height), img.PixelFormat);
        }

        public static Bitmap ConvertPixelFormat(this Bitmap image, PixelFormat newFormat) {
            Bitmap clone = new Bitmap(image.Width, image.Height, newFormat);
            using (Graphics gr = Graphics.FromImage(clone)) {
                gr.DrawImage(image, new Rectangle(0, 0, clone.Width, clone.Height));
            }
            return clone;
        }

        public static double DistanceTo(this Point point, Point target) {
            return Math.Sqrt(Math.Pow(point.X - target.X, 2) + Math.Pow(point.Y - target.Y, 2));
        }

    }
}
