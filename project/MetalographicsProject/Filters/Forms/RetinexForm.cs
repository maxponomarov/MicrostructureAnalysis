using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MetalographicsProject.Filters.Forms {
    public partial class RetinexForm : Form {
        private readonly Bitmap image;
        public RetinexBrightness filter;

        public RetinexForm(Bitmap image) {
            InitializeComponent();
            this.image = image;
            RenderImage();
        }

        public RetinexForm(Bitmap image, byte value) {
            InitializeComponent();
            this.image = image;
            valueTB.Value = value;
            valueUpDown.Value = value;
            RenderImage();
        }

        private void valueTB_Scroll(object sender, EventArgs e) {
            valueUpDown.Value = valueTB.Value;
            RenderImage();
        }

        private void applyButton_Click(object sender, EventArgs e) {
            filter = new RetinexBrightness(Convert.ToByte(valueTB.Value));
            DialogResult = DialogResult.OK;
        }

        private void RenderImage() {
            filter = new RetinexBrightness(Convert.ToByte(valueTB.Value));
            previewPB.Image = filter.ApplyFilter(new List<Bitmap>() { image });
        }

        private void valueUpDown_ValueChanged(object sender, EventArgs e) {
            valueTB.Value = Convert.ToByte(valueUpDown.Value);
            RenderImage();
        }
    }
}
