namespace MetalographicsProject.Filters.Forms {
    partial class BinarizationForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.thresholdSlider = new AForge.Controls.ColorSlider();
            this.rangeRB = new System.Windows.Forms.RadioButton();
            this.adaptiveRB = new System.Windows.Forms.RadioButton();
            this.applyButton = new System.Windows.Forms.Button();
            this.noFilterCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.Location = new System.Drawing.Point(308, 12);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(565, 469);
            this.previewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewPictureBox.TabIndex = 0;
            this.previewPictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maxLabel);
            this.groupBox1.Controls.Add(this.minLabel);
            this.groupBox1.Controls.Add(this.thresholdSlider);
            this.groupBox1.Controls.Add(this.rangeRB);
            this.groupBox1.Controls.Add(this.adaptiveRB);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 404);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(259, 73);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(25, 13);
            this.maxLabel.TabIndex = 2;
            this.maxLabel.Text = "255";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(11, 73);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(13, 13);
            this.minLabel.TabIndex = 2;
            this.minLabel.Text = "0";
            // 
            // thresholdSlider
            // 
            this.thresholdSlider.EndColor = System.Drawing.Color.DimGray;
            this.thresholdSlider.Location = new System.Drawing.Point(7, 42);
            this.thresholdSlider.Name = "thresholdSlider";
            this.thresholdSlider.Size = new System.Drawing.Size(277, 28);
            this.thresholdSlider.StartColor = System.Drawing.Color.Gainsboro;
            this.thresholdSlider.TabIndex = 1;
            this.thresholdSlider.Text = "colorSlider1";
            this.thresholdSlider.Type = AForge.Controls.ColorSlider.ColorSliderType.Threshold;
            this.thresholdSlider.ValuesChanged += new System.EventHandler(this.thresholdSlider_ValuesChanged);
            // 
            // rangeRB
            // 
            this.rangeRB.AutoSize = true;
            this.rangeRB.Location = new System.Drawing.Point(7, 19);
            this.rangeRB.Name = "rangeRB";
            this.rangeRB.Size = new System.Drawing.Size(90, 17);
            this.rangeRB.TabIndex = 0;
            this.rangeRB.TabStop = true;
            this.rangeRB.Text = "Стандартная";
            this.rangeRB.UseVisualStyleBackColor = true;
            this.rangeRB.CheckedChanged += new System.EventHandler(this.modeRB_CheckedChanged);
            // 
            // adaptiveRB
            // 
            this.adaptiveRB.AutoSize = true;
            this.adaptiveRB.Location = new System.Drawing.Point(7, 107);
            this.adaptiveRB.Name = "adaptiveRB";
            this.adaptiveRB.Size = new System.Drawing.Size(85, 17);
            this.adaptiveRB.TabIndex = 0;
            this.adaptiveRB.TabStop = true;
            this.adaptiveRB.Text = "Адаптивная";
            this.adaptiveRB.UseVisualStyleBackColor = true;
            this.adaptiveRB.CheckedChanged += new System.EventHandler(this.modeRB_CheckedChanged);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(122, 458);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // noFilterCB
            // 
            this.noFilterCB.AutoSize = true;
            this.noFilterCB.Location = new System.Drawing.Point(18, 12);
            this.noFilterCB.Name = "noFilterCB";
            this.noFilterCB.Size = new System.Drawing.Size(91, 17);
            this.noFilterCB.TabIndex = 1;
            this.noFilterCB.Text = "Без фильтра";
            this.noFilterCB.UseVisualStyleBackColor = true;
            this.noFilterCB.CheckedChanged += new System.EventHandler(this.noFilterCB_CheckedChanged);
            // 
            // BinarizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 493);
            this.Controls.Add(this.noFilterCB);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.previewPictureBox);
            this.Name = "BinarizationForm";
            this.Text = "BinarizationForm";
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.RadioButton rangeRB;
        private System.Windows.Forms.RadioButton adaptiveRB;
        private System.Windows.Forms.CheckBox noFilterCB;
        private AForge.Controls.ColorSlider thresholdSlider;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
    }
}