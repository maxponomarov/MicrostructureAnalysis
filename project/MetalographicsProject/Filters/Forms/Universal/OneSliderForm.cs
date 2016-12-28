using System;
using System.Windows.Forms;

namespace MetalographicsProject.Filters.Forms.Universal {
    public partial class OneSliderForm : Form {
        public int value;

        public OneSliderForm() {
            InitializeComponent();
        }

        public void SetValues(string formText, string labelText, int minValue, int maxValue, int value) {
            Text = formText;
            infoLabel.Text = labelText;
            valueTrackBar.Minimum = minValue;
            valueTrackBar.Maximum = maxValue;
            valueTrackBar.Value = value;
        }
        
        private void applyButton_Click(object sender, EventArgs e) {
            value = valueTrackBar.Value;
            DialogResult = DialogResult.OK;
        }

        private void valueTrackBar_Scroll(object sender, EventArgs e) {
            valueTextBox.Text = valueTrackBar.Value.ToString();
        }
    }
}
