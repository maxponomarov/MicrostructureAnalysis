using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using MetalographicsProject.Analysators;
using MetalographicsProject.Controllers;
using MetalographicsProject.Filters;
using MetalographicsProject.Filters.Forms;
using MetalographicsProject.Filters.Sys;
using MetalographicsProject.Model;
using MetalographicsProject.Sys;
using MetalographicsProject.Analysators.Forms;

namespace MetalographicsProject.Forms {
    public enum MouseMode {
        Arrow,
        Measure,
        Ruler,
        Square
    }

    public partial class MainForm : Form {
        private Size PictureBoxSize => mainPictureBox.Size;
        private Size PictureSize => mainPictureBox.Image.Size;

        private MouseMode MouseMode;
        private int ThumbsSize = 50;
        private ImageProcessingController imageController;
        MouseEventArgs MouseState;
        bool MousePressed;

        Point lastPoint;
        bool clicked;

        private void aboutButton_Click(object sender, EventArgs e) {
            using (AboutForm form = new AboutForm()) {
                form.ShowDialog();
            }
        }
        private void helpButton_Click(object sender, EventArgs e) {
            using (HelpForm form = new HelpForm()) {
                form.ShowDialog();
            }
        }

        #region Form controllers and builders
        public MainForm() {
            InitializeComponent();
            filterThumbsGrid.Visible = false;
            MouseMode = MouseMode.Arrow;
        }

        private void RebuildImageView(int index = 1) {
            imageController.RebuildNodes(index);
            List<Bitmap> thumbs = imageController.GetOutputImages();
            filterThumbsGrid.Rows.Clear();

            foreach (Bitmap bmp in thumbs) {
                filterThumbsGrid.Rows.Add(bmp.ScaleImage(ThumbsSize - 1, ThumbsSize));
            }

            filterThumbsGrid.Visible = true;
            filterThumbsGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private int SelectedNodeIndex = 0;
        private void SelectNode(int index) {
            //получаем нод по индексу
            Node node = imageController.GetNode(index);

            SelectedNodeIndex = index;

            //устанавливаем главным изображением - результат текущего фильтра
            mainPictureBox.Image = node.Output;

            //показываем информацию о фильтре
            statusLabel.Text = $"Selection: {selectedRowIndex} | Filter name: {node.Filter}";
        }
        #endregion
        
        #region File munu buttons
        //open from file
        private void openImageButton_Click(object sender, EventArgs e) {
            using (OpenFileDialog dialog = new OpenFileDialog()) {
                dialog.Multiselect = false;

                if (dialog.ShowDialog() == DialogResult.OK) {
                    //Reset measure
                    filterInfoGrid.Rows.Clear();
                    MeasureController.ResetMeasure();


                    //open image
                    Bitmap openedImage = (Bitmap)Image.FromFile(dialog.FileName);
                    imageController = new ImageProcessingController(openedImage);

                    //config interface
                    selectedRowIndex = 0;
                    RebuildImageView();
                    SelectNode(0);
                }
            }
        }

        private void saveCurrentImage_Click(object sender, EventArgs e) {
            using (SaveFileDialog dialog = new SaveFileDialog()) {
                if (dialog.ShowDialog() == DialogResult.OK) {
                    mainPictureBox.Image.Save(dialog.FileName, ImageFormat.Jpeg);
                }
            }
        }
        #endregion

        #region Filter grid events
        private int selectedRowIndex;

        private void filterThumbsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            try {
                //получаем индекс выбранного фильтра
                foreach (DataGridViewRow row in filterThumbsGrid.Rows) {
                    row.Cells[0].Style.Padding = new Padding(0);
                }
                filterThumbsGrid.Rows[e.RowIndex].Cells[0].Style.Padding = new Padding(0, 2, 0, 2);

                selectedRowIndex = e.RowIndex;
                SelectNode(selectedRowIndex);
            } catch (ArgumentOutOfRangeException) {
                statusLabel.Text = "Selection: none";
            }
        }

        private void filterThumbsGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (selectedRowIndex >= 0) {
                if (FilterModifierOpener.ModifyFilter(selectedRowIndex)) {
                    RebuildImageView(selectedRowIndex);
                    SelectNode(selectedRowIndex);
                }
            }
        }
        
        //click
        private void filterThumbsGrid_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                int currentMouseOverRow = filterThumbsGrid.HitTest(e.X, e.Y).RowIndex;
                selectedRowIndex = currentMouseOverRow;

                //создаем пункты меню
                ContextMenu m = new ContextMenu();
                MenuItem delete = new MenuItem("Удалить");
                MenuItem modify = new MenuItem("Изменить");

                //присваиваем им тэг - номер строки, для которой вызывается меню
                delete.Tag = currentMouseOverRow;
                modify.Tag = currentMouseOverRow;

                //привязваем к ним обработчик события нажатия
                delete.Click += filterThumbsGrid_ContextMenuItemDelete;
                modify.Click += filterThumbsGrid_ContextMenuItemModify;

                //добавляем пункты к меню
                m.MenuItems.Add(delete);
                m.MenuItems.Add(modify);

                //показываем меню
                m.Show(filterThumbsGrid, new Point(e.X, e.Y));
            }
        }
        //delete
        private void filterThumbsGrid_ContextMenuItemDelete(object sender, EventArgs e) {
            //MenuItem item = (MenuItem) sender;
            if (selectedRowIndex >= 0) {
                //TODO добавить диалог закрытия документа при попытке удаления корневого элемента, если попытка удалить корневой элемент
                if (selectedRowIndex == 0) {
                    MessageBox.Show("Удалять корневой элемент нельзя.");
                } else {
                    ImageProcessingController.Instance.DeleteNode(selectedRowIndex);
                    RebuildImageView(--selectedRowIndex);
                    SelectNode(selectedRowIndex);
                }
            }
        }
        //modify
        private void filterThumbsGrid_ContextMenuItemModify(object sender, EventArgs e) {
            MessageBox.Show("Modify");
        }
        #endregion

        #region Filters menu buttons
        private void edgeDetectorButton_Click(object sender, EventArgs e) {
            using (EdgeDetectorForm form = new EdgeDetectorForm(ImageProcessingController.Instance.GetNode(SelectedNodeIndex).Output)) {
                if (form.ShowDialog() == DialogResult.OK) {
                    imageController.AddNode(form.filter);
                    RebuildImageView(ImageProcessingController.Instance.NodesCount - 1);
                    SelectNode(filterThumbsGrid.Rows.Count - 1);
                }
            }
        }

        private void equalizeHistButton_Click(object sender, EventArgs e) {
            imageController.AddNode(new HistogramEqualizationFilter());
            RebuildImageView(ImageProcessingController.Instance.NodesCount - 1);
            SelectNode(filterThumbsGrid.Rows.Count - 1);
        }

        private void inverseImageButton_Click(object sender, EventArgs e) {
            InverseFilter filter = new InverseFilter();
            imageController.AddNode(filter);
            RebuildImageView(ImageProcessingController.Instance.NodesCount - 1);
            SelectNode(filterThumbsGrid.Rows.Count - 1);
        }

        private void gaussFilterButton_Click(object sender, EventArgs e) {
            using (GaussianFilterForm form = new GaussianFilterForm(ImageProcessingController.Instance.GetNode(SelectedNodeIndex).Output)) {
                if (form.ShowDialog() == DialogResult.OK) {
                    imageController.AddNode(form.filter);
                    RebuildImageView(ImageProcessingController.Instance.NodesCount - 1);
                    SelectNode(filterThumbsGrid.Rows.Count - 1);
                }
            }
        }

        private void medianBlurFilter_Click(object sender, EventArgs e) {
            using (MedianBlurFilterForm form = new MedianBlurFilterForm(ImageProcessingController.Instance.GetNode(SelectedNodeIndex).Output)) {
                if (form.ShowDialog() == DialogResult.OK) {
                    MedianBlurFilter filter = form.filter;
                    ImageProcessingController.Instance.AddNode(filter);
                    RebuildImageView(ImageProcessingController.Instance.NodesCount - 1);
                    SelectNode(filterThumbsGrid.Rows.Count - 1);
                }
            }
        }

        private void blackWhiteButton_Click(object sender, EventArgs e) {
            using (BlackWhiteFilterForm form = new BlackWhiteFilterForm(ImageProcessingController.Instance.GetNode(SelectedNodeIndex).Output)) {
                if (form.ShowDialog() == DialogResult.OK) {
                    BlackWhiteFilter filter = form.filter;
                    ImageProcessingController.Instance.AddNode(filter);
                    RebuildImageView(ImageProcessingController.Instance.NodesCount - 1);
                    SelectNode(filterThumbsGrid.Rows.Count - 1);
                }
            }
        }

        private void extractChanelButton_Click(object sender, EventArgs e) {
            using (ExtractChannelForm form = new ExtractChannelForm()) {
                if (form.ShowDialog() == DialogResult.OK) {
                    ExtractChannelFilter filter = new ExtractChannelFilter(form.mode);
                    ImageProcessingController.Instance.AddNode(filter);
                    RebuildImageView();
                    SelectNode(filterThumbsGrid.Rows.Count - 1);
                }
            }
        }

        private void brightnessButton_Click(object sender, EventArgs e) {
            using (BrightnessForm form = new BrightnessForm(ImageProcessingController.Instance.GetNode(SelectedNodeIndex).Output)) {
                if (form.ShowDialog() == DialogResult.OK) {
                    ImageProcessingController.Instance.AddNode(form.resultFilter);
                    RebuildImageView();
                    SelectNode(filterThumbsGrid.Rows.Count - 1);
                }
            }
        }

        private void contrastButton_Click(object sender, EventArgs e) {
            using (ContrastForm form = new ContrastForm(ImageProcessingController.Instance.GetNode(SelectedNodeIndex).Output)) {
                if (form.ShowDialog() == DialogResult.OK) {
                    ImageProcessingController.Instance.AddNode(form.resultFilter);
                    RebuildImageView();
                    SelectNode(filterThumbsGrid.Rows.Count - 1);
                }
            }
        }

        private void morphologyButton_Click(object sender, EventArgs e) {
            using (MorphologyForm form = new MorphologyForm(ImageProcessingController.Instance.GetNode(SelectedNodeIndex).Output)) {
                if (form.ShowDialog() == DialogResult.OK) {
                    ImageProcessingController.Instance.AddNode(form.filter);
                    RebuildImageView();
                    SelectNode(filterThumbsGrid.Rows.Count - 1);
                }
            }
        }

        private void binaryThresholdButton_Click(object sender, EventArgs e) {
            using (BinarizationForm form = new BinarizationForm(ImageProcessingController.Instance.GetNode(SelectedNodeIndex).Output)) {
                if (form.ShowDialog() == DialogResult.OK) {
                    ImageProcessingController.Instance.AddNode(form.filter);
                    RebuildImageView();
                    SelectNode(filterThumbsGrid.Rows.Count - 1);
                }
            }
        }

        private void extractColorButton_Click(object sender, EventArgs e) {
            using (ExtractColorForm form = new ExtractColorForm(ImageProcessingController.Instance.GetNode(SelectedNodeIndex).Output)) {
                if (form.ShowDialog() == DialogResult.OK) {
                    ImageProcessingController.Instance.AddNode(form.filter);
                    RebuildImageView();
                    SelectNode(filterThumbsGrid.Rows.Count - 1);
                }
            }
        }

        private void retinexButton_Click(object sender, EventArgs e) {
            using (RetinexForm form = new RetinexForm(ImageProcessingController.Instance.GetNode(SelectedNodeIndex).Output)) {
                if (form.ShowDialog() == DialogResult.OK) {
                    ImageProcessingController.Instance.AddNode(form.filter);
                    RebuildImageView();
                    SelectNode(filterThumbsGrid.Rows.Count - 1);
                }
            }
        }

        private void distanceTransformButton_Click(object sender, EventArgs e) {
            ImageProcessingController.Instance.AddNode(new DistanceTranformFilter());
            RebuildImageView();
            SelectNode(filterThumbsGrid.Rows.Count - 1);
        }
        #endregion

        #region Detectors menu buttons
        private void watershedButton_Click(object sender, EventArgs e) {
            using (WatershedForm form = new WatershedForm(ImageProcessingController.Instance.GetNode(SelectedNodeIndex).Output)) {
                if (form.ShowDialog() == DialogResult.OK) {
                    
                }
            }
        }

        private void blobDetectionButton_Click(object sender, EventArgs e) {
            using (BlobDetectorForm form = new BlobDetectorForm(ImageProcessingController.Instance.GetNode(SelectedNodeIndex).Output)) {
                if (form.ShowDialog() == DialogResult.OK) {
                    ImageProcessingController.Instance.AddNode(form.detector);
                    RebuildImageView();
                    SelectNode(filterThumbsGrid.Rows.Count - 1);
                }
            }
        }
        #endregion

        #region Thumbs size buttons
        private void smallThumbsButton_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow row in filterThumbsGrid.Rows) {
                row.Height = 50;
            }

            ThumbsSize = 50;
            RebuildImageView();
        }

        private void mediumThumbsButton_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow row in filterThumbsGrid.Rows) {
                row.Height = 100;
            }

            ThumbsSize = 100;
            RebuildImageView();
        }

        private void largeThumbsButton_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow row in filterThumbsGrid.Rows) {
                row.Height = 150;
            }

            ThumbsSize = 150;
            RebuildImageView();
        }

        #endregion

        private void blobDetailsButton_Click(object sender, EventArgs e) {
            Node selectedNode = ImageProcessingController.Instance.GetNode(SelectedNodeIndex);
            if (selectedNode.NodeType == NodeType.Detector) {
                BlobDetector blobDetector = selectedNode.Detector as BlobDetector;
                if (blobDetector != null) {
                    using (BlobDetailsForm form = new BlobDetailsForm(blobDetector)) {
                        if (form.ShowDialog() == DialogResult.OK) {
                            
                        }
                    }
                }
            }
        }

        private void fillHolesButton_Click(object sender, EventArgs e) {

        }

        private void mainPictureBox_Paint(object sender, PaintEventArgs e) {
            if (MouseMode != MouseMode.Arrow) {
                Bitmap bmp = ImageProcessingController.Instance.GetNode().Output.Clone2();
                Graphics graphics = Graphics.FromImage(bmp);

                switch (MouseMode) {
                    case MouseMode.Arrow:

                        break;
                    case MouseMode.Ruler:
                        if (RulerPoints.Count == 2) {
                            Point p1 = CoordinatesController.PBtoPCoordinates(
                                RulerPoints[0],
                                mainPictureBox.Size,
                                mainPictureBox.Image.Size);
                            Point p2 = CoordinatesController.PBtoPCoordinates(
                                RulerPoints[1],
                                mainPictureBox.Size,
                                mainPictureBox.Image.Size);
                            graphics.DrawLine(new Pen(Color.Red, 3), p1, p2);
                            graphics.DrawString($"{p1.DistanceTo(p2):F1} пикс", Font, new SolidBrush(Color.Red), p2);
                            mainPictureBox.Image = bmp;
                        }
                        break;
                }
            } else {
                if (ImageProcessingController.Instance != null) {
                    mainPictureBox.Image = ImageProcessingController.Instance.GetNode().Output;
                }
            }


        }
        
        private void mainPictureBox_MouseDown(object sender, MouseEventArgs e) {
            MouseState = e;
            MousePressed = true;

            switch (MouseMode) {
                case MouseMode.Measure:
                    if (measureMode == MeasureStatus.MeasureRequested) {
                        Point convertedPoint = CoordinatesController.PBtoPCoordinates(
                            e.Location,
                            PictureBoxSize,
                            PictureSize);

                        if (MeasurePoints.Count == 0) {
                            //добавляем первую точку
                            MeasurePoints.Add(convertedPoint);
                        } else if (MeasurePoints.Count == 1) {
                            //добавляем вторую точку
                            MeasurePoints.Add(convertedPoint);
                            //вызываем форму масштабов
                            double distance = MeasurePoints[0].DistanceTo(MeasurePoints[1]);
                            using (MeasureForm form = new MeasureForm(mainPictureBox.Image.Size, distance)) {
                                if (form.ShowDialog() == DialogResult.OK) {
                                    measureMode = MeasureStatus.MeasureSelected;
                                    MeasureController.SelectMeasure(form.SelectedMeasure);
                                    filterInfoGrid.Rows.Add("Масштаб", form.SelectedMeasure.Scale);
                                }

                                MouseMode = MouseMode.Arrow;
                                MenuButtonsOn();
                            }
                            MeasurePoints.Clear();
                        }
                    }
                    break;

                case MouseMode.Ruler:
                    if (RulerPoints.Count == 2)
                        RulerPoints.Clear();

                    RulerPoints.Add(e.Location);
                    mainPictureBox.Invalidate();
                    mainPictureBox.Update();
                    break;
            }
        }
        
        private void mainPictureBox_MouseUp(object sender, MouseEventArgs e) {
            MouseState = e;
            MousePressed = false;
        }

        private void mainPictureBox_MouseMove(object sender, MouseEventArgs e) {
            
        }

        private void MenuButtonsOff() {
            fileMenuButton.Enabled = false;
            viewMenuButton.Enabled = false;
            editMenuButton.Enabled = false;
            analyseMenuButton.Enabled = false;
        }
        private void MenuButtonsOn() {
            fileMenuButton.Enabled = true;
            viewMenuButton.Enabled = true;
            editMenuButton.Enabled = true;
            analyseMenuButton.Enabled = true;
        }

        #region Instrument Panel
        private readonly List<Point> MeasurePoints = new List<Point>(2);
        MeasureStatus measureMode = MeasureStatus.None;
        private void measureButton_Click(object sender, EventArgs e) {
            using (MeasureForm form = new MeasureForm()) {
                if (form.ShowDialog() == DialogResult.OK) {
                    switch (form.status) {
                        case MeasureStatus.MeasureSelected:
                            //выбрано значение
                            measureMode = MeasureStatus.MeasureSelected;
                            MeasureController.SelectMeasure(form.SelectedMeasure);
                            filterInfoGrid.Rows.Add("Масштаб", form.SelectedMeasure.Scale);
                            MouseMode = MouseMode.Arrow;
                            MenuButtonsOn();
                            break;
                        case MeasureStatus.MeasureRequested:
                            //запрос на создание замеров
                            measureMode = MeasureStatus.MeasureRequested;
                            MouseMode = MouseMode.Measure;
                            MenuButtonsOff();
                            break;
                    }
                }
            }
        }

        List<Point> RulerPoints = new List<Point>(2); 
        private void rulerButton_Click(object sender, EventArgs e) {
            if (MouseMode == MouseMode.Ruler) {
                MenuButtonsOn();
                MouseMode = MouseMode.Arrow;
                RulerPoints.Clear();
                mainPictureBox.Invalidate();
                mainPictureBox.Update();
            } else {
                MenuButtonsOff();
                MouseMode = MouseMode.Ruler;
            }

            
        }

        private void squareButton_Click(object sender, EventArgs e) {

        }
        #endregion


    }
}
