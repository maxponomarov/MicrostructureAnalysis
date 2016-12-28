using System;
using System.Windows.Forms;

namespace MetalographicsProject.Filters.Forms {
    public partial class ExtractChannelForm : Form {
        public ExtractChanelMode mode;

        private void InitListBox() {
            foreach (ExtractChanelMode modes in Enum.GetValues(typeof(ExtractChanelMode))) {
                modeListBox.Items.Add(modes.ToString());
            }
        }

        public ExtractChannelForm() {
            InitializeComponent();
            InitListBox();
            modeListBox.SelectedIndex = 0;
        }

        public ExtractChannelForm(ExtractChanelMode mode) {
            InitializeComponent();
            InitListBox();
            modeListBox.SelectedItem = mode;
        }

        private void applyChannelButton_Click(object sender, EventArgs e) {
            mode = (ExtractChanelMode) Enum.Parse(typeof(ExtractChanelMode), modeListBox.SelectedItem.ToString());
            DialogResult = DialogResult.OK;
        }
    }
}
