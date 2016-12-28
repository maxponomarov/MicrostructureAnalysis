namespace MetalographicsProject.Filters.Forms {
    partial class BlackWhiteFilterForm {
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
            this.redTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.greenTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.blueTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.redLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // redTrackBar
            // 
            this.redTrackBar.LargeChange = 100;
            this.redTrackBar.Location = new System.Drawing.Point(10, 22);
            this.redTrackBar.Maximum = 1000;
            this.redTrackBar.Minimum = 1;
            this.redTrackBar.Name = "redTrackBar";
            this.redTrackBar.Size = new System.Drawing.Size(243, 45);
            this.redTrackBar.TabIndex = 0;
            this.redTrackBar.Value = 500;
            this.redTrackBar.Scroll += new System.EventHandler(this.redTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Красный";
            // 
            // greenTrackBar
            // 
            this.greenTrackBar.LargeChange = 100;
            this.greenTrackBar.Location = new System.Drawing.Point(10, 86);
            this.greenTrackBar.Maximum = 1000;
            this.greenTrackBar.Minimum = 1;
            this.greenTrackBar.Name = "greenTrackBar";
            this.greenTrackBar.Size = new System.Drawing.Size(243, 45);
            this.greenTrackBar.TabIndex = 0;
            this.greenTrackBar.Value = 500;
            this.greenTrackBar.Scroll += new System.EventHandler(this.greenTrackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Зеленый";
            // 
            // blueTrackBar
            // 
            this.blueTrackBar.LargeChange = 100;
            this.blueTrackBar.Location = new System.Drawing.Point(10, 150);
            this.blueTrackBar.Maximum = 1000;
            this.blueTrackBar.Minimum = 1;
            this.blueTrackBar.Name = "blueTrackBar";
            this.blueTrackBar.Size = new System.Drawing.Size(243, 45);
            this.blueTrackBar.TabIndex = 0;
            this.blueTrackBar.Value = 500;
            this.blueTrackBar.Scroll += new System.EventHandler(this.blueTrackBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Синий";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(107, 201);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewPictureBox.Location = new System.Drawing.Point(305, 3);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(535, 461);
            this.previewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewPictureBox.TabIndex = 4;
            this.previewPictureBox.TabStop = false;
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(259, 22);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(22, 13);
            this.redLabel.TabIndex = 5;
            this.redLabel.Text = "0.5";
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Location = new System.Drawing.Point(259, 86);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(22, 13);
            this.greenLabel.TabIndex = 5;
            this.greenLabel.Text = "0.5";
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Location = new System.Drawing.Point(259, 150);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(22, 13);
            this.blueLabel.TabIndex = 5;
            this.blueLabel.Text = "0.5";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.blueLabel);
            this.panel1.Controls.Add(this.redTrackBar);
            this.panel1.Controls.Add(this.greenLabel);
            this.panel1.Controls.Add(this.greenTrackBar);
            this.panel1.Controls.Add(this.redLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.blueTrackBar);
            this.panel1.Controls.Add(this.applyButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 228);
            this.panel1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.previewPictureBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(843, 467);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // BlackWhiteFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 467);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BlackWhiteFilterForm";
            this.Text = "BlackWhiteFilterForm";
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar redTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar greenTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar blueTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}