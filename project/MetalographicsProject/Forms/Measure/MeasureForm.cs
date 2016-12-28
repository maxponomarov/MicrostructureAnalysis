using System;
using System.Drawing;
using System.Windows.Forms;
using MetalographicsProject.Controllers;
using MetalographicsProject.Controllers.Measure;

namespace MetalographicsProject.Forms {
    public enum MeasureStatus {
        None,
        MeasureRequested,
        MeasureSelected
    }

    public partial class MeasureForm : Form {
        public MeasureStatus status;
        public Measure SelectedMeasure;

        //MeasureNotDone
        public MeasureForm() {
            InitializeComponent();
            LoadMeasures();
        }

        //Measure done
        public MeasureForm(Size imageSize, double pixelLength) {
            InitializeComponent();

            //получаем значение масштаба
            using (MeasureValueForm form = new MeasureValueForm()) {
                if (form.ShowDialog() == DialogResult.OK) {
                    Measure measure = MeasureController.AddMeasure(new Measure(form.value/pixelLength, imageSize));
                    measureDGV.Rows.Add(
                        measure.Guid.ToString(), 
                        $"{measure.ImageSize.Width}x{measure.ImageSize.Height}",
                        measure.Scale);
                }
            }

            LoadMeasures();
        }

        private void LoadMeasures() {
            Measure[] measures = MeasureController.GetMeasures();
            if (measures.Length < 1)
                return;

            measureDGV.Rows.Clear();

            foreach (Measure measure in measures) {
                measureDGV.Rows.Add(
                    measure.Guid.ToString(),
                    $"{measure.ImageSize.Width}x{measure.ImageSize.Height}",
                    measure.Scale);
            }

        }

        private void measureDGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            status = MeasureStatus.MeasureSelected;
            string measureGuid = Convert.ToString(measureDGV.Rows[e.RowIndex].Cells[0].Value);
            SelectedMeasure = MeasureController.GetMeasure(measureGuid);
            DialogResult = DialogResult.OK;
        }

        private void addLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            status = MeasureStatus.MeasureRequested;
            DialogResult = DialogResult.OK;
        }

        private void deleteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (measureDGV.SelectedRows.Count > 0) {
                measureDGV.Rows.Remove(measureDGV.SelectedRows[0]);
            }
        }
    }
}
