namespace MetalographicsProject.Filters.Forms {
    partial class BrightnessForm {
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
            this.valueTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.okButton = new System.Windows.Forms.Button();
            this.valueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.valueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // valueTrackBar
            // 
            this.valueTrackBar.LargeChange = 10;
            this.valueTrackBar.Location = new System.Drawing.Point(15, 25);
            this.valueTrackBar.Maximum = 255;
            this.valueTrackBar.Minimum = -255;
            this.valueTrackBar.Name = "valueTrackBar";
            this.valueTrackBar.Size = new System.Drawing.Size(375, 45);
            this.valueTrackBar.TabIndex = 0;
            this.valueTrackBar.Scroll += new System.EventHandler(this.valueTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Яркость";
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.Location = new System.Drawing.Point(15, 62);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(486, 374);
            this.previewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewPictureBox.TabIndex = 2;
            this.previewPictureBox.TabStop = false;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(426, 25);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "ОК";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(396, 30);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(13, 13);
            this.valueLabel.TabIndex = 4;
            this.valueLabel.Text = "0";
            // 
            // BrightnessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 451);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.previewPictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valueTrackBar);
            this.Name = "BrightnessForm";
            this.Text = "Корректировка яркости";
            ((System.ComponentModel.ISupportInitialize)(this.valueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar valueTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label valueLabel;
    }
}