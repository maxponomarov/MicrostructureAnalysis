namespace MetalographicsProject.Filters.Forms {
    partial class ExtractColorForm {
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
            this.previewPB = new System.Windows.Forms.PictureBox();
            this.colorWheel = new Cyotek.Windows.Forms.ColorWheel();
            this.applyCB = new System.Windows.Forms.CheckBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectedColorPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radiusTB = new System.Windows.Forms.TrackBar();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.previewPB)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusTB)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // previewPB
            // 
            this.previewPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewPB.Location = new System.Drawing.Point(3, 171);
            this.previewPB.Name = "previewPB";
            this.previewPB.Size = new System.Drawing.Size(398, 339);
            this.previewPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewPB.TabIndex = 0;
            this.previewPB.TabStop = false;
            // 
            // colorWheel
            // 
            this.colorWheel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.colorWheel.Location = new System.Drawing.Point(3, 3);
            this.colorWheel.Name = "colorWheel";
            this.colorWheel.Size = new System.Drawing.Size(157, 148);
            this.colorWheel.TabIndex = 1;
            this.colorWheel.ColorChanged += new System.EventHandler(this.colorWheel_ColorChanged);
            // 
            // applyCB
            // 
            this.applyCB.AutoSize = true;
            this.applyCB.Checked = true;
            this.applyCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.applyCB.Location = new System.Drawing.Point(169, 134);
            this.applyCB.Name = "applyCB";
            this.applyCB.Size = new System.Drawing.Size(89, 17);
            this.applyCB.TabIndex = 2;
            this.applyCB.Text = "Предосмотр";
            this.applyCB.UseVisualStyleBackColor = true;
            this.applyCB.CheckedChanged += new System.EventHandler(this.applyCheckBox_CheckedChanged);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(271, 131);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(89, 23);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выбранный цвет";
            // 
            // selectedColorPanel
            // 
            this.selectedColorPanel.Location = new System.Drawing.Point(169, 22);
            this.selectedColorPanel.Name = "selectedColorPanel";
            this.selectedColorPanel.Size = new System.Drawing.Size(101, 43);
            this.selectedColorPanel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radiusTB);
            this.panel2.Controls.Add(this.colorWheel);
            this.panel2.Controls.Add(this.selectedColorPanel);
            this.panel2.Controls.Add(this.applyCB);
            this.panel2.Controls.Add(this.radiusLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.applyButton);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 162);
            this.panel2.TabIndex = 6;
            // 
            // radiusTB
            // 
            this.radiusTB.LargeChange = 10;
            this.radiusTB.Location = new System.Drawing.Point(162, 84);
            this.radiusTB.Maximum = 127;
            this.radiusTB.Minimum = 1;
            this.radiusTB.Name = "radiusTB";
            this.radiusTB.Size = new System.Drawing.Size(220, 45);
            this.radiusTB.TabIndex = 6;
            this.radiusTB.Value = 1;
            this.radiusTB.Scroll += new System.EventHandler(this.radiusTrackBar_Scroll);
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(215, 68);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(13, 13);
            this.radiusLabel.TabIndex = 4;
            this.radiusLabel.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Радиус:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.previewPB, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(404, 513);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // ExtractColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 513);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(420, 542);
            this.Name = "ExtractColorForm";
            this.Text = "Выделение цвета";
            ((System.ComponentModel.ISupportInitialize)(this.previewPB)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusTB)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox previewPB;
        private Cyotek.Windows.Forms.ColorWheel colorWheel;
        private System.Windows.Forms.CheckBox applyCB;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel selectedColorPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TrackBar radiusTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label radiusLabel;
    }
}