using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MetalographicsProject.Filters.Forms {
    public partial class BlackWhiteFilterForm : Form {
        private float Red;
        private float Green;
        private float Blue;
        private readonly Bitmap image;

        public BlackWhiteFilter filter;
        public BlackWhiteFilterForm(Bitmap image) {
            InitializeComponent();
            this.image = image;

            ReadParameters();
            previewPictureBox.Image = new BlackWhiteFilter(Red, Green, Blue).ApplyFilter(new List<Bitmap>() { image });
        }

        public BlackWhiteFilterForm(Bitmap image, float Red, float Green, float Blue) {
            InitializeComponent();
            this.image = image;

            this.Red = Red;
            this.Green = Green;
            this.Blue = Blue;

            redTrackBar.Value = Convert.ToInt32(Red * 1000);
            greenTrackBar.Value = Convert.ToInt32(Green * 1000);
            blueTrackBar.Value = Convert.ToInt32(Blue * 1000);

            redLabel.Text = $"{Red:f3}";
            greenLabel.Text = $"{Green:f3}";
            blueLabel.Text = $"{Blue:f3}";

            ReadParameters();
            previewPictureBox.Image = new BlackWhiteFilter(Red, Green, Blue).ApplyFilter(new List<Bitmap>() { image });
        }

        private void ReadParameters() {
            Red = (float)redTrackBar.Value / 1000;
            Green = (float)greenTrackBar.Value / 1000;
            Blue = (float)blueTrackBar.Value / 1000;
        }
        
        private void applyButton_Click(object sender, EventArgs e) {
            ReadParameters();
            DialogResult = DialogResult.OK;
            filter = new BlackWhiteFilter(Red, Green, Blue);
        }

        private void redTrackBar_Scroll(object sender, EventArgs e) {
            Red = ((float)redTrackBar.Value) / 1000;
            redLabel.Text = $"{Red:f3}";
            ReadParameters();
            previewPictureBox.Image = new BlackWhiteFilter(Red, Green, Blue).ApplyFilter(new List<Bitmap>() { image });
        }

        private void greenTrackBar_Scroll(object sender, EventArgs e) {
            Green = ((float)greenTrackBar.Value) / 1000;
            greenLabel.Text = $"{Green:f3}";
            ReadParameters();
            previewPictureBox.Image = new BlackWhiteFilter(Red, Green, Blue).ApplyFilter(new List<Bitmap>() { image });
        }

        private void blueTrackBar_Scroll(object sender, EventArgs e) {
            Blue = ((float)blueTrackBar.Value) / 1000;
            blueLabel.Text = $"{Blue:f3}";
            ReadParameters();
            previewPictureBox.Image = new BlackWhiteFilter(Red, Green, Blue).ApplyFilter(new List<Bitmap>() { image });
        }
    }
}
