using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MetalographicsProject.Filters.EdgeDetectors;

namespace MetalographicsProject.Filters.Forms {
    public partial class EdgeDetectorForm : Form {
        private readonly Bitmap image;
        public AbstractFilter filter;

        public EdgeDetectorForm(Bitmap image) {
            InitializeComponent();
            this.image = image;
            homogenityRB.Checked = true;
        }

        public EdgeDetectorForm(Bitmap image, AbstractFilter oldFilter) {
            InitializeComponent();
            this.image = image;
            if (oldFilter is HomogenityFilter)
                homogenityRB.Checked = true;
            else
            if (oldFilter is CannyFilter)
                cannyRB.Checked = true;
            else
            if (oldFilter is DifferenceFilter)
                differenceRB.Checked = true;
            else
            if (oldFilter is SobelFilter)
                sobelRB.Checked = true;
            else
                throw new ArgumentException("Переданый тип фильтра не является фильтром определния границ");
        }

        private void applyFilter_Click(object sender, EventArgs e) {
            filter = GetFilter();
        }

        private void noFilterCB_CheckedChanged(object sender, EventArgs e) {
            if (noFilterCB.Checked) {
                applyFilter.Enabled = true;
            } else {
                noFilterCB.Checked = false;
            }

            RenderPreview();
        }

        private void RB_CheckedChanged(object sender, EventArgs e) {
            RenderPreview();
        }

        private AbstractFilter GetFilter() {
            AbstractFilter tmpFilter = null;
            if (homogenityRB.Checked)
                tmpFilter = new HomogenityFilter();
            if (differenceRB.Checked)
                tmpFilter = new DifferenceFilter();
            if (sobelRB.Checked)
                tmpFilter = new SobelFilter();
            if (cannyRB.Checked)
                tmpFilter = new CannyFilter();
            return tmpFilter;
        }

        private void RenderPreview() {
            previewPB.Image = noFilterCB.Checked ? image : GetFilter().ApplyFilter(new List<Bitmap> { image });
        }
    }
}
