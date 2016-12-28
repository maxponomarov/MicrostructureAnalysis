using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using MetalographicsProject.Analysators.Objects;

namespace MetalographicsProject.Analysators.Forms {
    public partial class BlobDetailsForm : Form {
        private BlobDetector detector;

        public BlobDetailsForm(BlobDetector detector) {
            InitializeComponent();
            this.detector = detector;

            blobsDGV.RowTemplate.Height = 50;
            foreach (Spot spot in detector.DetectBlobs()) {
                Bitmap image = spot.Image;
                blobsDGV.Rows.Add(image, spot.PixelArea);
                blobsDGV.Rows[blobsDGV.RowCount-1].Cells[0].Style.BackColor = Color.Black;
            }

            blobsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void blobsDGV_CellClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            List<Spot> spots = detector.DetectBlobs();
            for (int i = 0; i < spots.Count; i++) {
                spots[i].Image.Save($"D:\\Blobs\\{i}.png", ImageFormat.Png);
            }
        }
    }
}
