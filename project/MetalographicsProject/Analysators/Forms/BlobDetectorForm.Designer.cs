namespace MetalographicsProject.Analysators.Forms {
    partial class BlobDetectorForm {
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
            this.minimalHeightTB = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.minimalWidthTB = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.minHeightLabel = new System.Windows.Forms.Label();
            this.minWidthLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.applyButton = new System.Windows.Forms.Button();
            this.sameValuesCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimalHeightTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimalWidthTB)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewPictureBox.Location = new System.Drawing.Point(3, 112);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(532, 387);
            this.previewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewPictureBox.TabIndex = 0;
            this.previewPictureBox.TabStop = false;
            // 
            // minimalHeightTB
            // 
            this.minimalHeightTB.Location = new System.Drawing.Point(9, 24);
            this.minimalHeightTB.Maximum = 100;
            this.minimalHeightTB.Name = "minimalHeightTB";
            this.minimalHeightTB.Size = new System.Drawing.Size(205, 45);
            this.minimalHeightTB.TabIndex = 1;
            this.minimalHeightTB.Scroll += new System.EventHandler(this.minimalHeightTB_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Минимальная высота";
            // 
            // minimalWidthTB
            // 
            this.minimalWidthTB.Location = new System.Drawing.Point(220, 24);
            this.minimalWidthTB.Maximum = 100;
            this.minimalWidthTB.Name = "minimalWidthTB";
            this.minimalWidthTB.Size = new System.Drawing.Size(215, 45);
            this.minimalWidthTB.TabIndex = 1;
            this.minimalWidthTB.Scroll += new System.EventHandler(this.minimalWidthTB_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Минимальная ширина";
            // 
            // minHeightLabel
            // 
            this.minHeightLabel.AutoSize = true;
            this.minHeightLabel.Location = new System.Drawing.Point(187, 8);
            this.minHeightLabel.Name = "minHeightLabel";
            this.minHeightLabel.Size = new System.Drawing.Size(13, 13);
            this.minHeightLabel.TabIndex = 3;
            this.minHeightLabel.Text = "1";
            // 
            // minWidthLabel
            // 
            this.minWidthLabel.AutoSize = true;
            this.minWidthLabel.Location = new System.Drawing.Point(406, 8);
            this.minWidthLabel.Name = "minWidthLabel";
            this.minWidthLabel.Size = new System.Drawing.Size(13, 13);
            this.minWidthLabel.TabIndex = 4;
            this.minWidthLabel.Text = "1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.previewPictureBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 502);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sameValuesCB);
            this.panel1.Controls.Add(this.applyButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.minWidthLabel);
            this.panel1.Controls.Add(this.minimalHeightTB);
            this.panel1.Controls.Add(this.minHeightLabel);
            this.panel1.Controls.Add(this.minimalWidthTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 103);
            this.panel1.TabIndex = 0;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(441, 24);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // sameValuesCB
            // 
            this.sameValuesCB.AutoSize = true;
            this.sameValuesCB.Location = new System.Drawing.Point(12, 62);
            this.sameValuesCB.Name = "sameValuesCB";
            this.sameValuesCB.Size = new System.Drawing.Size(140, 17);
            this.sameValuesCB.TabIndex = 6;
            this.sameValuesCB.Text = "Одинаковые значения";
            this.sameValuesCB.UseVisualStyleBackColor = true;
            this.sameValuesCB.CheckedChanged += new System.EventHandler(this.sameValuesCB_CheckedChanged);
            // 
            // BlobDetectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 502);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BlobDetectorForm";
            this.Text = "BlobDetectorForm";
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimalHeightTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimalWidthTB)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.TrackBar minimalHeightTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar minimalWidthTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label minHeightLabel;
        private System.Windows.Forms.Label minWidthLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.CheckBox sameValuesCB;
    }
}