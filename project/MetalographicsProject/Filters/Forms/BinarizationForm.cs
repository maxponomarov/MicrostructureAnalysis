using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MetalographicsProject.Filters.Forms {
    public partial class BinarizationForm : Form {
        private readonly Bitmap image;
        
        public AbstractFilter filter;
        public BinarizationForm(Bitmap image, AdaptiveTresholdFilter filter = null) {
            InitializeComponent();
            this.image = image;
        }

        public BinarizationForm(Bitmap image, SimpleTresholdFilter filter) {
            InitializeComponent();
            this.image = image;
            thresholdSlider.Min = filter.Min;
            thresholdSlider.Max = filter.Max;
            rangeRB.Checked = true;
        }

        private void modeRB_CheckedChanged(object sender, EventArgs e) {
            RenderImage();
        }

        private void applyButton_Click(object sender, EventArgs e) {
            if (adaptiveRB.Checked) {
                filter = new AdaptiveTresholdFilter();
            }

            if (rangeRB.Checked) {
                int min = thresholdSlider.Min;
                int max = thresholdSlider.Max;
                filter = new SimpleTresholdFilter(min, max);
            }

            DialogResult = DialogResult.OK;
        }

        private void RenderImage() {
            if (!noFilterCB.Checked) {
                if (adaptiveRB.Checked) {
                    filter = new AdaptiveTresholdFilter();
                    previewPictureBox.Image = filter.ApplyFilter(new List<Bitmap>() { image });
                }

                if (rangeRB.Checked) {
                    int min = thresholdSlider.Min;
                    int max = thresholdSlider.Max;
                    filter = new SimpleTresholdFilter(min, max);
                    previewPictureBox.Image = filter.ApplyFilter(new List<Bitmap>() { image });
                }
            } else {
                previewPictureBox.Image = image;
            }
        }

        private void noFilterCB_CheckedChanged(object sender, EventArgs e) {
            if (noFilterCB.Checked) {
                rangeRB.Enabled = false;
                thresholdSlider.Enabled = false;
                adaptiveRB.Enabled = false;
                applyButton.Enabled = false;
            } else {
                rangeRB.Enabled = true;
                thresholdSlider.Enabled = true;
                adaptiveRB.Enabled = true;
                applyButton.Enabled = true;
            }

            RenderImage();
        }

        private void thresholdSlider_ValuesChanged(object sender, EventArgs e) {
            RenderImage();
        }
    }
}
