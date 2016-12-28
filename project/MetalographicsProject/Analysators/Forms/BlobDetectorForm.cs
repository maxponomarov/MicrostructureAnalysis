using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MetalographicsProject.Analysators.Objects;

namespace MetalographicsProject.Analysators.Forms {
    public partial class BlobDetectorForm : Form {
        private Bitmap image;
        public BlobDetector detector;

        public BlobDetectorForm(Bitmap image) {
            InitializeComponent();
            this.image = image;
            RenderPreview();
        }

        private void applyButton_Click(object sender, EventArgs e) {
            detector = new BlobDetector(image, minimalHeightTB.Value, minimalWidthTB.Value);
            DialogResult = DialogResult.OK;
        }

        private void RenderPreview() {
            detector = new BlobDetector(image, minimalHeightTB.Value, minimalWidthTB.Value);
            previewPictureBox.Image = detector.RenderPreview(new Pen(Color.Red, 1));
        }

        private void minimalHeightTB_Scroll(object sender, EventArgs e) {
            minHeightLabel.Text = minimalHeightTB.Value.ToString();
            if (sameValuesCB.Checked) {
                minimalWidthTB.Value = minimalHeightTB.Value;
                minWidthLabel.Text = minimalWidthTB.Value.ToString();
            }

            RenderPreview();
        }

        private void minimalWidthTB_Scroll(object sender, EventArgs e) {
            minWidthLabel.Text = minimalWidthTB.Value.ToString();
            RenderPreview();
        }

        private void sameValuesCB_CheckedChanged(object sender, EventArgs e) {
            if (sameValuesCB.Checked) {
                minimalWidthTB.Enabled = false;
                minimalWidthTB.Value = minimalHeightTB.Value;
            } else {
                minimalWidthTB.Enabled = true;
            }
        }
    }
}
