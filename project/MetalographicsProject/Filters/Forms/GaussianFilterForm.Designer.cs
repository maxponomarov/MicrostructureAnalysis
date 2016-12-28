namespace MetalographicsProject.Filters.Forms {
    partial class GaussianFilterForm {
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
            this.radiusTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.sigmaTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.modeCB = new System.Windows.Forms.ComboBox();
            this.sigmaLabel = new System.Windows.Forms.Label();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.radiusTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigmaTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radiusTrackBar
            // 
            this.radiusTrackBar.Location = new System.Drawing.Point(111, 14);
            this.radiusTrackBar.Maximum = 30;
            this.radiusTrackBar.Minimum = 1;
            this.radiusTrackBar.Name = "radiusTrackBar";
            this.radiusTrackBar.Size = new System.Drawing.Size(260, 45);
            this.radiusTrackBar.TabIndex = 1;
            this.radiusTrackBar.Value = 1;
            this.radiusTrackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Радиус";
            // 
            // sigmaTrackBar
            // 
            this.sigmaTrackBar.Location = new System.Drawing.Point(402, 14);
            this.sigmaTrackBar.Maximum = 30;
            this.sigmaTrackBar.Minimum = 1;
            this.sigmaTrackBar.Name = "sigmaTrackBar";
            this.sigmaTrackBar.Size = new System.Drawing.Size(260, 45);
            this.sigmaTrackBar.TabIndex = 1;
            this.sigmaTrackBar.Value = 1;
            this.sigmaTrackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сигма";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(20, 38);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Применить";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewPictureBox.Location = new System.Drawing.Point(3, 77);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(693, 435);
            this.previewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewPictureBox.TabIndex = 5;
            this.previewPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.modeCB);
            this.panel1.Controls.Add(this.sigmaLabel);
            this.panel1.Controls.Add(this.radiusLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radiusTrackBar);
            this.panel1.Controls.Add(this.sigmaTrackBar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.okButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 68);
            this.panel1.TabIndex = 6;
            // 
            // modeCB
            // 
            this.modeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeCB.FormattingEnabled = true;
            this.modeCB.Items.AddRange(new object[] {
            "Резкость",
            "Размытие"});
            this.modeCB.Location = new System.Drawing.Point(9, 9);
            this.modeCB.Name = "modeCB";
            this.modeCB.Size = new System.Drawing.Size(96, 21);
            this.modeCB.TabIndex = 5;
            this.modeCB.SelectedIndexChanged += new System.EventHandler(this.modeCB_SelectedIndexChanged);
            // 
            // sigmaLabel
            // 
            this.sigmaLabel.AutoSize = true;
            this.sigmaLabel.Location = new System.Drawing.Point(668, 22);
            this.sigmaLabel.Name = "sigmaLabel";
            this.sigmaLabel.Size = new System.Drawing.Size(13, 13);
            this.sigmaLabel.TabIndex = 4;
            this.sigmaLabel.Text = "0";
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(377, 22);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(13, 13);
            this.radiusLabel.TabIndex = 4;
            this.radiusLabel.Text = "0";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.previewPictureBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(699, 515);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // GaussianFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 515);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(715, 554);
            this.Name = "GaussianFilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Фильтр Гаусса";
            ((System.ComponentModel.ISupportInitialize)(this.radiusTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigmaTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar radiusTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar sigmaTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.Label sigmaLabel;
        private System.Windows.Forms.ComboBox modeCB;
    }
}