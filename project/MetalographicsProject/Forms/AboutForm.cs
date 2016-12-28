using System.Windows.Forms;

namespace MetalographicsProject.Forms {
    public partial class AboutForm : Form {
        public AboutForm() {
            InitializeComponent();
        }

        private void siteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            MessageBox.Show("Сайт находится в разработке");
        }
    }
}
