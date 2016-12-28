using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetalographicsProject.Forms {
    public partial class MeasureValueForm : Form {
        public double value;

        public MeasureValueForm() {
            InitializeComponent();
        }

        private void applyButton_Click(object sender, EventArgs e) { 
            switch (comboBox1.SelectedIndex) {
                case 0: //m
                    value = Convert.ToInt32(valueTB.Text);
                    DialogResult = DialogResult.OK;
                    break;
                case 1: //dc
                    value = Convert.ToInt32(valueTB.Text) * Math.Pow(10, -1);
                    DialogResult = DialogResult.OK;
                    break;
                case 2: //sm
                    value = Convert.ToInt32(valueTB.Text) * Math.Pow(10, -2);
                    DialogResult = DialogResult.OK;
                    break;
                case 3: //mm
                    value = Convert.ToInt32(valueTB.Text) * Math.Pow(10, -3);
                    DialogResult = DialogResult.OK;
                    break;
                case 4: //mk
                    value = Convert.ToInt32(valueTB.Text) * Math.Pow(10, -6);
                    DialogResult = DialogResult.OK;
                    break;
                case 5: //nm
                    value = Convert.ToInt32(valueTB.Text) * Math.Pow(10, -9);
                    DialogResult = DialogResult.OK;
                    break;
            }
        }
    }
}
