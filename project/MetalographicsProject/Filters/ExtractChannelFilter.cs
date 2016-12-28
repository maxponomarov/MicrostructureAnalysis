using System.Collections.Generic;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;

namespace MetalographicsProject.Filters {
    class ExtractChannelFilter : AbstractFilter {
        private readonly ExtractChanelMode mode;
        public ExtractChanelMode Mode => mode;

        public ExtractChannelFilter(ExtractChanelMode mode) { this.mode = mode; }

        public override Bitmap ApplyFilter(List<Bitmap> bitmap) {
            Image<Bgr, byte> rbg = new Image<Bgr, byte>(bitmap[0]);
            Image<Hsv, byte> hsv = rbg.Convert<Hsv, byte>();

            switch (mode) {
                case ExtractChanelMode.Hue:
                    return hsv.Split()[0].Bitmap;

                case ExtractChanelMode.Saturation:
                    return hsv.Split()[1].Bitmap;

                case ExtractChanelMode.Brightness:
                    return hsv.Split()[2].Bitmap;

                default:
                    return bitmap[0];
            }
        }
    }

    public enum ExtractChanelMode {
        Hue,
        Saturation,
        Brightness
    }
}
