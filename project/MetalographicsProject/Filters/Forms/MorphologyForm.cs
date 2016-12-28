using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MetalographicsProject.Filters.Morphology;

namespace MetalographicsProject.Filters.Forms {
    public partial class MorphologyForm : Form {
        private readonly short[,] DefaultMatrix3x3 = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
        private readonly Bitmap image;

        public AbstractFilter filter;

        public MorphologyForm(Bitmap image) {
            InitializeComponent();
            this.image = image;
        }

        public MorphologyForm(Bitmap image, MorphologyFilterType type) {
            InitializeComponent();
            this.image = image;

            switch (type) {
                case MorphologyFilterType.Erode:
                    erodeRB.Checked = true;
                    break;

                case MorphologyFilterType.Dilate:
                    dilateRB.Checked = true;
                    break;

                case MorphologyFilterType.Open:
                    openRB.Checked = true;
                    break;

                case MorphologyFilterType.Close:
                    closeRB.Checked = true;
                    break;
            }
        }
        
        private void applyButton_Click(object sender, EventArgs e) {
            if (erodeRB.Checked) {
                filter = new ErodeFilter(DefaultMatrix3x3);
            }

            if (dilateRB.Checked) {
                filter = new DilateFilter(DefaultMatrix3x3);
            }

            if (openRB.Checked) {
                filter = new OpeningFilter(DefaultMatrix3x3);
            }

            if (closeRB.Checked) {
                filter = new ClosingFilter(DefaultMatrix3x3);
            }

            DialogResult = DialogResult.OK;
        }
        
        private void radioButton_CheckedChanged(object sender, EventArgs e) {
            RenderPreview();
        }

        private void RenderPreview() {
            if (erodeRB.Checked) {
                previewPictureBox.Image = new ErodeFilter(DefaultMatrix3x3).ApplyFilter(new List<Bitmap>() { image });
            }

            if (dilateRB.Checked) {
                previewPictureBox.Image = new DilateFilter(DefaultMatrix3x3).ApplyFilter(new List<Bitmap>() { image });
            }

            if (openRB.Checked) {
                previewPictureBox.Image = new OpeningFilter(DefaultMatrix3x3).ApplyFilter(new List<Bitmap>() { image });
            }

            if (closeRB.Checked) {
                previewPictureBox.Image = new ClosingFilter(DefaultMatrix3x3).ApplyFilter(new List<Bitmap>() { image });
            }

            if (noneRB.Checked) {
                previewPictureBox.Image = image;
            }
        }
    }

    public enum MorphologyFilterType {
        Erode, Dilate, Open, Close
    }
}
