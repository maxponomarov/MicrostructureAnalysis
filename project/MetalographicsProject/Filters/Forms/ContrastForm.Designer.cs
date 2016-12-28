namespace MetalographicsProject.Filters.Forms {
    partial class ContrastForm {
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
            this.valueTrackBar = new System.Windows.Forms.TrackBar();
            this.valueLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contrastStretchCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.Location = new System.Drawing.Point(10, 82);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(478, 369);
            this.previewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewPictureBox.TabIndex = 0;
            this.previewPictureBox.TabStop = false;
            // 
            // valueTrackBar
            // 
            this.valueTrackBar.LargeChange = 10;
            this.valueTrackBar.Location = new System.Drawing.Point(12, 17);
            this.valueTrackBar.Maximum = 255;
            this.valueTrackBar.Minimum = -255;
            this.valueTrackBar.Name = "valueTrackBar";
            this.valueTrackBar.Size = new System.Drawing.Size(328, 45);
            this.valueTrackBar.TabIndex = 1;
            this.valueTrackBar.Scroll += new System.EventHandler(this.valueTrackBar_Scroll);
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(342, 28);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(13, 13);
            this.valueLabel.TabIndex = 2;
            this.valueLabel.Text = "0";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(382, 53);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Контрастность";
            // 
            // contrastStretchCB
            // 
            this.contrastStretchCB.AutoSize = true;
            this.contrastStretchCB.Location = new System.Drawing.Point(382, 17);
            this.contrastStretchCB.Name = "contrastStretchCB";
            this.contrastStretchCB.Size = new System.Drawing.Size(106, 30);
            this.contrastStretchCB.TabIndex = 4;
            this.contrastStretchCB.Text = "Максимизация \r\nконтраста";
            this.contrastStretchCB.UseVisualStyleBackColor = true;
            this.contrastStretchCB.CheckedChanged += new System.EventHandler(this.contrastStretchCB_CheckedChanged);
            // 
            // ContrastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 465);
            this.Controls.Add(this.contrastStretchCB);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.valueTrackBar);
            this.Controls.Add(this.previewPictureBox);
            this.Name = "ContrastForm";
            this.Text = "Корректировка контрастности";
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.TrackBar valueTrackBar;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox contrastStretchCB;
    }
}