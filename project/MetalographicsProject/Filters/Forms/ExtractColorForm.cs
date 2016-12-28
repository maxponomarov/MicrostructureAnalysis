using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MetalographicsProject.Filters.Forms {
    public partial class ExtractColorForm : Form {
        private readonly Bitmap image;
        public AbstractFilter filter;

        public ExtractColorForm(Bitmap image) {
            InitializeComponent();
            this.image = image;
        }

        public ExtractColorForm(Bitmap image, Color color, short radius) {
            InitializeComponent();
            this.image = image;
            colorWheel.Color = color;
            radiusTB.Value = radius;
            radiusLabel.Text = radius.ToString();
        }

        private void colorWheel_ColorChanged(object sender, EventArgs e) {
            RenderPreview();
        }

        private void radiusTrackBar_Scroll(object sender, EventArgs e) {
            RenderPreview();
            radiusLabel.Text = radiusTB.Value.ToString();
        }

        private void applyCheckBox_CheckedChanged(object sender, EventArgs e) {
            RenderPreview();
        }

        private void applyButton_Click(object sender, EventArgs e) {
            filter = new EuclidColorFilter(colorWheel.Color, Convert.ToSByte(radiusTB.Value));
            DialogResult = DialogResult.OK;
        }

        private void RenderPreview() {
            previewPB.Image = applyCB.Checked ? new EuclidColorFilter(colorWheel.Color, Convert.ToSByte(radiusTB.Value)).ApplyFilter(new List<Bitmap>() { image }) : image;
        }
    }
}
