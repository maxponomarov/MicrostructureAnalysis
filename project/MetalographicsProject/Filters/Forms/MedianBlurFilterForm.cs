using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MetalographicsProject.Filters.Forms {
    public partial class MedianBlurFilterForm : Form {
        private Bitmap image;
        public MedianBlurFilter filter;

        //стандартный конструктор
        public MedianBlurFilterForm(Bitmap image) {
            InitializeComponent();
            this.image = image;
            RenderImage();
        }

        //конструктор при вызовы фильтра на редактирование
        public MedianBlurFilterForm(Bitmap image, int size) {
            InitializeComponent();
            this.image = image;
            radiusTrackBar.Value = size;
            radiusLabel.Text = size.ToString();
            RenderImage();
        }

        private void applyButton_Click(object sender, EventArgs e) {
            filter = new MedianBlurFilter(radiusTrackBar.Value);
            DialogResult = DialogResult.OK;
        }

        private void radiusTrackBar_Scroll(object sender, EventArgs e) {
            radiusLabel.Text = radiusTrackBar.Value.ToString();
            applyButton.Enabled = radiusTrackBar.Value != 0;
            RenderImage();
        }

        private void RenderImage() {
            previewPictureBox.Image = new MedianBlurFilter(radiusTrackBar.Value).ApplyFilter(new List<Bitmap>() { image });
        }
    }
}
