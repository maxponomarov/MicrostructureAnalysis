using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MetalographicsProject.Filters.Forms {
    public partial class ContrastForm : Form {
        private readonly Bitmap originalBitmap;
        public AbstractFilter resultFilter;

        public ContrastForm(Bitmap image) {
            InitializeComponent();
            originalBitmap = image;

            previewPictureBox.Image = RenderImage();
        }

        public ContrastForm(Bitmap image, int value, bool stretchContrast) {
            InitializeComponent();
            originalBitmap = image;
            valueTrackBar.Value = value;
            valueLabel.Text = value.ToString();
            contrastStretchCB.Checked = stretchContrast;

            previewPictureBox.Image = RenderImage();
        }

        private void okButton_Click(object sender, EventArgs e) {
            if (contrastStretchCB.Checked) {
                resultFilter = new ContrastStretchFilter();
            } else {
                resultFilter = new ContrastFilter(valueTrackBar.Value);
            }

            DialogResult = DialogResult.OK;
        }

        private Bitmap RenderImage() {
            if (!contrastStretchCB.Checked) {
                ContrastFilter filter = new ContrastFilter(valueTrackBar.Value);
                return filter.ApplyFilter(new List<Bitmap>() { originalBitmap });
            } else {
                ContrastStretchFilter filter = new ContrastStretchFilter();
                return filter.ApplyFilter(new List<Bitmap>() { originalBitmap });
            }
        }

        private void valueTrackBar_Scroll(object sender, EventArgs e) {
            valueLabel.Text = valueTrackBar.Value.ToString();
            previewPictureBox.Image = RenderImage();
        }

        private void contrastStretchCB_CheckedChanged(object sender, EventArgs e) {
            if (contrastStretchCB.Checked) {
                valueTrackBar.Enabled = false;
                valueLabel.Enabled = false;
                previewPictureBox.Image = RenderImage();
            } else {
                valueTrackBar.Enabled = true;
                valueLabel.Enabled = true;
                previewPictureBox.Image = RenderImage();
            }
        }
    }
}
