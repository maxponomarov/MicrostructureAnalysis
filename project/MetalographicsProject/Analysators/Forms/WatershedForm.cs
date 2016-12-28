using System;
using System.Drawing;
using System.Windows.Forms;

namespace MetalographicsProject.Analysators.Forms {
    public partial class WatershedForm : Form {
        WatershedSegmentator segmentator;

        Bitmap image;
        public WatershedForm(Bitmap image) {
            InitializeComponent();
            segmentator = new WatershedSegmentator();
            pictureBox1.Image = segmentator.WatershedTest(image);
            this.image = image;
        }

        private void button1_Click(object sender, EventArgs e) {

        }
    }
}
