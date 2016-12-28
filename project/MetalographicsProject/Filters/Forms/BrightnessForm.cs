using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MetalographicsProject.Filters.Forms {
    public partial class BrightnessForm : Form {
        private readonly Bitmap image;
        public BrightnessFilter resultFilter;

        public BrightnessForm(Bitmap image) {
            InitializeComponent();
            this.image = image;
            previewPictureBox.Image = RenderImage();
        }

        public BrightnessForm(Bitmap image, int value) {
            InitializeComponent();
            this.image = image;
            valueTrackBar.Value = value;
            previewPictureBox.Image = RenderImage();
        }

        private void okButton_Click(object sender, EventArgs e) {
            resultFilter = new BrightnessFilter(valueTrackBar.Value);
            DialogResult = DialogResult.OK;
        }

        private void valueTrackBar_Scroll(object sender, EventArgs e) {
            valueLabel.Text = valueTrackBar.Value.ToString();
            previewPictureBox.Image = RenderImage();
        }

        private Bitmap RenderImage() {
            BrightnessFilter filter = new BrightnessFilter(valueTrackBar.Value);
            return filter.ApplyFilter(new List<Bitmap>() { image });
        }
    }
}
