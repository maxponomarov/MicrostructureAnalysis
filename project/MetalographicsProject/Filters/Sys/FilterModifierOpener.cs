using System;
using System.Drawing;
using System.Windows.Forms;
using MetalographicsProject.Controllers;
using MetalographicsProject.Filters.Forms;

namespace MetalographicsProject.Filters.Sys {
    class FilterModifierOpener {

        public static bool ModifyFilter(int index) {
            Model.Node selectedNode = ImageProcessingController.Instance.GetNode(index);
            AbstractFilter filter = selectedNode.Filter;
            Type t = filter.GetType();

            /*
            #region Gaussian Blur Filter : Update
            if (t == typeof(GaussianBlurFilter)) {
                GaussianBlurFilter updatedFilter = (GaussianBlurFilter)filter;
                updatedFilter = GaussianBlurForm(updatedFilter);

                if (updatedFilter != null) {
                    ImageProcessingController.Instance.GetNode(index).SetFilter(updatedFilter);
                    return true;
                }
            }
            #endregion

            #region Gaussian Sharpen Filter : Update
            if (t == typeof(GaussianSharpenFilter)) {
                GaussianSharpenFilter updatedFilter = (GaussianSharpenFilter)filter;
                updatedFilter = GaussianSharpenForm(updatedFilter);

                if (updatedFilter != null) {
                    ImageProcessingController.Instance.GetNode(index).SetFilter(updatedFilter);
                    return true;
                }
            }
            #endregion
            */

            /*
            #region Median Blur Filter : Update
            if (t == typeof(MedianBlurFilter)) {
                MedianBlurFilter updatedFilter = (MedianBlurFilter)filter;
                updatedFilter = MedianBlurForm(updatedFilter);

                if (updatedFilter != null) {
                    ImageProcessingController.Instance.GetNode(index).SetFilter(updatedFilter);
                    return true;
                }
            }
            #endregion
            */

            #region Black White Filter : Update
            if (t == typeof(BlackWhiteFilter)) {
                BlackWhiteFilter updatedFilter = (BlackWhiteFilter)filter;
                updatedFilter = BlackWhiteForm(selectedNode.Input, updatedFilter);

                if (updatedFilter != null) {
                    ImageProcessingController.Instance.GetNode(index).SetFilter(updatedFilter);
                    return true;
                }
            }
            #endregion
            

            #region Brightness Filter
            if (t == typeof(BrightnessFilter)) {
                BrightnessFilter updatedFilter = (BrightnessFilter)filter;
                updatedFilter = BrightnessForm(selectedNode.Input, updatedFilter.Value);

                if (updatedFilter != null) {
                    ImageProcessingController.Instance.GetNode(index).SetFilter(updatedFilter);
                    return true;
                }
            }
            #endregion

            #region Contrast Filter
            if (t == typeof(ContrastFilter)) {
                ContrastFilter oldFilter = (ContrastFilter)filter;
                AbstractFilter newFilter = ContrastForm(selectedNode.Input, oldFilter.Value);

                if (newFilter != null) {
                    ImageProcessingController.Instance.GetNode(index).SetFilter(newFilter);
                    return true;
                }
            }
            #endregion

            #region Contrast Stretch Filter
            if (t == typeof(ContrastStretchFilter)) {
                AbstractFilter updatedFilter = ContrastStretchForm(selectedNode.Input);

                if (updatedFilter != null) {
                    ImageProcessingController.Instance.GetNode(index).SetFilter(updatedFilter);
                    return true;
                }
            }
            #endregion

            return false;
        }

        //TODO сделать рефактор схемы вызова окон для редактирования
        
        private static AbstractFilter ContrastStretchForm(Bitmap image) {
            using (ContrastForm form = new ContrastForm(image, 0, true)) {
                if (form.ShowDialog() == DialogResult.OK) {
                    AbstractFilter newFilter = form.resultFilter;
                    return newFilter;
                }
                return null;
            }
        }

        private static AbstractFilter ContrastForm(Bitmap image, int value) {
            using (ContrastForm form = new ContrastForm(image, value, false)  ) {
                if (form.ShowDialog() == DialogResult.OK) {
                    AbstractFilter newFilter = form.resultFilter;
                    return newFilter;
                }
                return null;
            }
        }

        /*
        private static GaussianBlurFilter GaussianBlurForm(GaussianBlurFilter filter) {
            using (GaussianFilterForm form = new GaussianFilterForm(filter.Size, filter.Sigma)) {
                if (form.ShowDialog() == DialogResult.OK) {
                    GaussianBlurFilter newFilter = new GaussianBlurFilter(form.size, form.sigma);
                    return newFilter;
                }
                return null;
            }
        }
        */
        /*
        private static MedianBlurFilter MedianBlurForm(MedianBlurFilter filter) {
            using (MedianBlurFilterForm form = new MedianBlurFilterForm(filter.Size)) {
                if (form.ShowDialog() == DialogResult.OK) {
                    MedianBlurFilter newFilter = new MedianBlurFilter(form.size);
                    return newFilter;
                }
                return null;
            }
        }
        */

        /*
        private static GaussianSharpenFilter GaussianSharpenForm(GaussianSharpenFilter filter) {
            using (GaussianFilterForm form = new GaussianFilterForm(filter.Size, filter.Sigma)) {
                if (form.ShowDialog() == DialogResult.OK) {
                    GaussianSharpenFilter newFilter = new GaussianSharpenFilter(form.Radius, form.Sigma);
                    return newFilter;
                }
                return null;
            }
        }
        */

        private static BlackWhiteFilter BlackWhiteForm(Bitmap image, BlackWhiteFilter filter) {
            using (BlackWhiteFilterForm form = new BlackWhiteFilterForm(image, filter.Red, filter.Green, filter.Blue)) {
                if (form.ShowDialog() == DialogResult.OK) {
                    BlackWhiteFilter newFilter = form.filter;
                    return newFilter;
                }
                return null;
            }
        }

        private static BrightnessFilter BrightnessForm(Bitmap bitmap, int value) {
            using (BrightnessForm form = new BrightnessForm(bitmap, value)) {

                if (form.ShowDialog() == DialogResult.OK) {
                    BrightnessFilter newFilter = form.resultFilter;
                    return newFilter;
                }
                return null;
            }
        }
    }
}
