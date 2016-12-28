using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MetalographicsProject.Filters.Forms {
    public partial class GaussianFilterForm : Form {
        public AbstractFilter filter;
        private readonly Bitmap image;

        public GaussianFilterForm(Bitmap image) {
            InitializeComponent();
            this.image = image;
            modeCB.SelectedIndex = 0;
        }

        public GaussianFilterForm(Bitmap image, GaussianBlurFilter gaussianFilter) {
            InitializeComponent();
            this.image = image;

            radiusTrackBar.Value = gaussianFilter.Radius;
            sigmaTrackBar.Value = gaussianFilter.Sigma;

            radiusLabel.Text = gaussianFilter.Radius.ToString();
            sigmaLabel.Text = gaussianFilter.Sigma.ToString();

            modeCB.SelectedIndex = 0;
        }

        public GaussianFilterForm(Bitmap image, GaussianSharpenFilter gaussianFilter) {
            InitializeComponent();
            this.image = image;

            radiusTrackBar.Value = gaussianFilter.Size;
            sigmaTrackBar.Value = gaussianFilter.Sigma;
            
            radiusLabel.Text = gaussianFilter.Size.ToString();
            sigmaLabel.Text = gaussianFilter.Sigma.ToString();
            modeCB.SelectedIndex = 0;
        }

        private void okButton_Click(object sender, EventArgs e) {
            int size = radiusTrackBar.Value;
            int sigma = sigmaTrackBar.Value;
            switch (modeCB.SelectedIndex) {
                case 0:
                    //резкость
                    filter = new GaussianSharpenFilter(size, sigma);
                    break;
                case 1:
                    //размытие
                    filter = new GaussianBlurFilter(size, sigma);
                    break;
            }
                
            DialogResult = DialogResult.OK;
        }

        private void trackBar_Scroll(object sender, EventArgs e) {
            RenderImage();


            radiusLabel.Text = radiusTrackBar.Value.ToString();
            sigmaLabel.Text = sigmaTrackBar.Value.ToString();
        }

        private void modeCB_SelectedIndexChanged(object sender, EventArgs e) {
            RenderImage();
        }

        private void RenderImage() {
            if (radiusTrackBar.Value == 0 && sigmaTrackBar.Value == 0) {
                previewPictureBox.Image = image;
                okButton.Enabled = false;
                return;
            }

            okButton.Enabled = true;
            int size = radiusTrackBar.Value;
            int sigma = sigmaTrackBar.Value;
            switch (modeCB.SelectedIndex) {
                case 0:
                    //резкость
                    filter = new GaussianSharpenFilter(size, sigma);
                    break;
                case 1:
                    //размытие
                    filter = new GaussianBlurFilter(size, sigma);
                    break;
            }

            previewPictureBox.Image = filter.ApplyFilter(new List<Bitmap>() { image });
        }
        
    }
}
